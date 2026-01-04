 var(--CommonControls-CheckBoxText-Background, fuchsia);
}

checkboxLabel:hover {
    color: var(--CommonControls-CheckBoxTextHover-Background, fuchsia);
}

.checkboxLabel:active {
    color: var(--CommonControls-CheckBoxTextPressed-Background, fuchsia);
}

.checkboxLabel:focus {
    color: var(--CommonControls-CheckBoxTextFocused-Background, fuchsia);
}

.checkboxLabel:disabled {
    color: var(--CommonControls-CheckBoxTextDisabled-Background, fuchsia);
}

input[type=checkbox] {
    outline: none;
}

    input[type=checkbox]:checked {
        color: var(--CommonControls-CheckBoxGlyph-Background, fuchsia);
        background-color: var(--CommonControls-CheckBoxBackground-Background, aquamarine);
        border: 1px solid var(--CommonControls-CheckBoxBorder-Background, red)
    }

    input[type=checkbox]:active:checked {
        color: var(--CommonControls-CheckBoxGlyphPressed-Background, fuchsia);
        border-color: var(--CommonControls-CheckBoxBorderPressed-Background, red);
        background-color: var(--CommonControls-CheckBoxBackgroundPressed-Background, red);
    }

    input[type=checkbox]:focus:checked {
        color: var(--CommonControls-CheckBoxGlyphFocused-Background, fuchsia);
        border-color: var(--CommonControls-CheckBoxBorderFocused-Background, red);
        background-color: var(--CommonControls-CheckBoxBackgroundFocused-Background, red);
    }

    input[type=checkbox]:disabled:checked {
        color: var(--CommonControls-CheckBoxGlyphDisabled-Background, fuchsia);
        border-color: var(--CommonControls-CheckBoxBorderDisabled-Background, red);
        background-color: var(--CommonControls-CheckBoxBackgroundDisabled-Background, transparent);
    }

/* Filter control */
input.filter {
    padding: 0px 0px 0px 3px;
    width: 150px;
    border: 1px solid var(--SearchControl-UnfocusedBorder-Background, lawngreen);
    background-color: var(--SearchControl-Unfocused-Background, lawngreen);
    color: var(--SearchControl-Unfocused-Foreground, fuchsia);
}

    input.filter:focus {
        color: var(--SearchControl-FocusedBackground-Foreground, coral);
        background-color: var(--SearchControl-FocusedBackground-Background, lawngreen);
        border-color: var(--SearchControl-FocusedBorder-Background, fuchsia);
    }

    input.filter:hover {
        color: var(--SearchControl-MouseOverBackground-Foreground, deeppink);
        background-color: var(--SearchControl-MouseOverBackground-Background, lawngreen);
        border-color: var(--SearchControl-MouseOverBorder-Background, fuchsia);
    }

    input.filter:disabled {
        color: var(--SearchControl-Disabled-Foreground, mediumorchid);
        background-color: var(--SearchControl-Disabled-Background, lawngreen);
        border-color: var(--SearchControl-DisabledBorder-Background, fuchsia);
    }

    input.filter:active {
        color: var(--SearchControl-SearchActive-Foreground, red);
        background-color: var(--SearchControl-SearchActive-Background, lawngreen);
    }

    input.filter::selection {
        color: var(--SearchControl-Selection-Foreground, coral);
        background-color: var(--SearchControl-Selection-Background, forestgreen);
    }

/** No data overlay */
#message-overlay {
    grid-row: 2;
    grid-column: 1;
    position: relative;
    overflow: hidden;
    z-index: 10000;
    transition: opacity .25s, height 0s;
    background-color: var(--plugin-background-color, rgba(200, 200, 200, 0.50));
}

#backtrace-message-overlay {
    position: relative;
    overflow: hidden;
    z-index: 1000;
    transition: opacity .25s, height 0s;
    background-color: var(--plugin-background-color, rgba(200, 200, 200, 0.50));
    height: 100%;
    grid-row: 2;
    grid-column: 1;
}

    #message-overlay.hide, #backtrace-message-overlay.hide {
        height: 0px;
        opacity: 0;
        transition: opacity .25s, height 0 .25s;
    }

    #message-overlay > div, #backtrace-message-overlay > div {
        width: 100%;
        display: block;
        position: absolute;
        top: 30%;
        text-align: center;
    }

    #message-overlay span, #backtrace-message-overlay span {
        display: block;
        background-color: var(--plugin-background-color, rgba(200, 200, 200, 0.50));
    }

/* Empty row sytle */
.treeGridRow.emptyRow > td {
    font-style: italic;
    text-align: left;
    color: var(--plugin-inactive-color, chartreuse);
}

td > .typeIcon {
    display: inline-block;
    width: 0px;
    height: 0px;
}

td > .typeIcon.valueType {
    width: 1.4em;
    height: 1.4em;
    vertical-align: middle;
    background: var(--valueTypeImage, url("./images/valueType.png")) no-repeat 0px 0px;
    background-size: 100%;
}

td > .typeIcon.refType {
    width: 1.4em;
    height: 1.4em;
    vertical-ali