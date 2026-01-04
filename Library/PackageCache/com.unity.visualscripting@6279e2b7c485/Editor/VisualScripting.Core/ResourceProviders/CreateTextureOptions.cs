define(["require", "exports"], function (require, exports) {
    "use strict";
    var _a;
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.rtlifyRules = void 0;
    var LEFT = 'left';
    var RIGHT = 'right';
    var NO_FLIP = '@noflip';
    var NAME_REPLACEMENTS = (_a = {},
        _a[LEFT] = RIGHT,
        _a[RIGHT] = LEFT,
        _a);
    var VALUE_REPLACEMENTS = {
        'w-resize': 'e-resize',
        'sw-resize': 'se-resize',
        'nw-resize': 'ne-resize',
    };
    /**
     * RTLifies the rulePair in the array at the current index. This mutates the array for performance
     * reasons.
     */
    function rtlifyRules(options, rulePairs, index) {
        if (options.rtl) {
            var name_1 = rulePairs[index];
            if (!name_1) {
                return;
            }
            var value = rulePairs[index + 1];
            if (typeof value === 'string' && value.indexOf(NO_FLIP) >= 0) {
                rulePairs[index + 1] = value.replace(/\s*(?:\/\*\s*)?\@noflip\b(?:\s*\*\/)?\s*?/g, '');
    