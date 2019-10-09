declare namespace Joove {
    class SpamControlHelper {
        private cfHelper;
        private $element;
        private shouldRun;
        private fromActiveElement;
        private findElement(event);
        constructor(event: any);
        Enable(): void;
        Disable(): void;
    }
    class ConditionalFormattingsHelper {
        applyFormatting($element: JQuery, type: string, extraData: any, state: any): void;
        makeControlRequired($element: JQuery, controlType: string): void;
        makeControlNotRequired($element: JQuery, controlType: string): void;
        makeControlActive($element: JQuery, controlType: string): void;
        hideControl($element: JQuery, controlType: string, extraData: string, repeatCounter?: number): void;
        showControl($element: JQuery, controlType: string, extraData: string, repeatCounter?: number): void;
        changeStyleOfControl($element: JQuery, classes: Array<string>, state: boolean, controlType: string): void;
        makeControlReadOnly($element: JQuery, controlType: string): void;
        makeControlEditable($element: JQuery, controlType: string): void;
        expandControl($element: JQuery, controlType: string): void;
        collapseControl($element: JQuery, controlType: string): void;
        applyCssClassToControl($element: JQuery, classesToAdd: string, controlType?: string): void;
        removeCssClassFromControl($element: JQuery, classesToRemove: string, controlType?: string): void;
        setColorRole($element: JQuery, newRole: string, controlType?: string): void;
        disableControl($element: JQuery, controlType: string): void;
        enableControl($element: JQuery, controlType: string): void;
        getChildrenOfContainer($element: JQuery, controlType: string): JQuery;
        getCheckBoxContainer($element: JQuery): JQuery;
        getTabPageTitle($element: JQuery): JQuery;
        enableDropDown($element: JQuery): void;
        disableDropDown($element: JQuery): void;
        applyOnSelect2Widget($nativeSelect: JQuery, cb: Function, attempt?: number): void;
    }
}
