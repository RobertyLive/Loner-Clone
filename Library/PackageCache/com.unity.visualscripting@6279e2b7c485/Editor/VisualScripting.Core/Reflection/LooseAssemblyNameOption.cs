"use strict";

Object.defineProperty(exports, "__esModule", {
  value: true
});
exports["default"] = void 0;
var _overlay_module = _interopRequireDefault(require("./overlay_module"));
function _interopRequireDefault(e) { return e && e.__esModule ? e : { "default": e }; }
// eslint-disable-next-line import/no-unresolved, import/extensions

var isOverlayContext = typeof window !== 'undefined' && window != null && window.__OVERLAY__ || document.getElementById('__OVERLAY__SENTINEL__') != null || /overlay/.test(window.location.pathname);
var isElectronRenderer = typeof window !== 'undefined' && window != null && window.DiscordNative && window.DiscordNative.isRenderer;
