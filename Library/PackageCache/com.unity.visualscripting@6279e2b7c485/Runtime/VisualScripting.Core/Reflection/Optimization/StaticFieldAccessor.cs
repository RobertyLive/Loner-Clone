// Copyright 2012 Mark Cavage, Inc.  All rights reserved.

'use strict';

var http = require('http');
var sprintf = require('util').format;
var url = require('url');

var assert = require('assert-plus');
var mime = require('mime');
var errors = require('restify-errors');

var httpDate = require('./http_date');
var utils = require('./utils');

///--- Globals

var InternalServerError = errors.InternalServerError;

/**
 * @private
 * Headers that cannot be multi-values.
 * @see #779, multiple set-cookie values are allowed only as multiple headers.
 * @see #986, multiple content-type values / headers disallowed.
 */
var HEADER_ARRAY_BLACKLIST = {
    'content-type': true
};

///--- API

/**
 * Patch Response object and extends with extra functionalities
 *
 * @private
 * @function patch
 * @param    {http.ServerResponse|http2.Http2ServerResponse} Response -
 *                                                           Server Response
 * @returns  {undefined} No return value
 */
function patch(Response) {
    assert.func(Response, 'Response');

    /**
     * Wraps all of the node
     * [http.ServerResponse](https://nodejs.org/docs/latest/api/http.html)
     * APIs, events and properties, plus the following.
     * @class Response
     * @extends http.ServerResponse
     */

    /**
     * Sets the `cache-control` header.
     *
     * @public
     * @memberof Response
     * @instance
     * @function cache
     * @param    {String} [type="public"] - value of the header
     *                                    (`"public"` or `"private"`)
     * @param    {Object} [options] - an options object
     * @param    {Number} options.maxAge - max-age in seconds
     * @returns  {String}         the value set to the header
     */
    Response.prototype.cache = function cache(type, options) {
        if (typeof type !== 'string') {
            options = type;
            type = 'public';
        }

        if (options && options.maxAge !== undefined) {
            assert.number(options.maxAge, 'options.maxAge');
            type += ', max-age=' + options.maxAge;
        }

        return this.setHeader('Cache-Control', type);
    };

    /**
     * Turns off all cache related headers.
     *
     * @public
     * @memberof Response
     * @instance
     * @function noCache
     * @returns  {Response} self, the response object
     */
    Response.prototype.noCache = function noCache() {
        // HTTP 1.1
        this.setHeader('Cache-Control', 'no-cache, no-store, must-revalidate');

        // HTTP 1.0
        this.setHeader('Pragma', 'no-cache');

        // Proxies
        this.setHeader('Expires', '0');

        return this;
    };

    /**
     * Appends the provided character set to the response's `Content-Type`.
     *
     * @public
     * @memberof Response
     * @instance
     * @function charSet
     * @param    {String} type - char-set value
     * @returns  {Response} self, the response object
     * @example
     * res.charSet('utf-8');
     */
    Response.prototype.charSet = function charSet(type) {
        assert.string(type, 'charset');

        this._charSet = type;

        return this;
    };

    /**
     * Retrieves a header off the response.
     *
     * @private
     * @memberof Response
     * @instance
     * @function get
     * @param    {Object} name - the header name
     * @returns  {String} header value
     */
    Response.prototype.get = function get(name) {
        assert.string(name, 'name');

        return this.getHeader(name);
    };

    // If getHeaders is not provided by the Node platform, monkey patch our own.
    // This is needed since versions of Node <7 did not come with a getHeaders.
    // For more see GH-1408
    if (typeof Response.prototype.getHeaders !== 'function') {
        /**
         * Retrieves all headers off the response.
         *
         * @private
         * @memberof Response
         * @instance
         * @function getHeaders
         * @returns  {Object} headers
         */
        Response.prototype.getHeaders = function getHeaders() {
            return this._headers || {};
        };
    }

    /**
     * Sets headers on the response.
     *
     * @public
     * @memberof Response
     * @instance
     * @function header
     * @param    {String} key - the name of the header
     * @param    {String} value - the value of the header
     * @returns  {Object} the retrieved value or the value that was set
     * @example
     * <caption>
     * If only key is specified, return the value of the header.
     * If both key and value are specified, set the response header.
     * </caption>
     * res.header('Content-Length');
     * // => undefined
     *
     * res.header('Content-Length', 123);
     * // => 123
     *
     * res.header('Content-Length');
     * // => 123
     *
     * res.header('foo', new Date());
     * // => Fri, 03 Feb 2012 20:09:58 GMT
     * @example
     * <caption>
     * `header()` can also be used to automatically chain header values
     * when applicable:
     * </caption>
     * res.header('x-foo', 'a');
     * res.header('x-foo', 'b');
     * // => { 'x-foo': ['a', 'b'] }
     * @example
     * <caption>
     * Note that certain headers like `content-type`
     * d