declare namespace Joove.Validation {
    class BindingEntry {
        message?: string;
        triggered?: boolean;
        indexesInfo?: {
            key: string;
            indexes: Array<number>;
        };
        rule?: JbRule;
        requiredControlId?: string;
        occurences?: number;
        group?: string;
    }
    class FormValidationOptions {
        groups: string[];
        withDataValidationsCheck: boolean;
        withRequiredFieldsCheck: boolean;
    }
    class Manager {
        static validateFormAndExecute(executionCb: Function, options: FormValidationOptions): void;
        private static afterDataValidationsCheck(executionCb, requiredFieldsOk);
    }
    class Bindings {
        private static conditionalsTriggerTimeout;
        static refresh(dv: JbRule, message: string, triggered: boolean, indexes: Array<number>): void;
        static removeBindingOfControl($el: JQuery): void;
        static refreshEmptyRequired($control: JQuery, triggered: boolean): void;
        static clearSummary(): void;
        static removeAllDataValidationsFromSummary(): void;
        static removeAllRequiredFieldsFromSummary(): void;
        static removeValidationsThatDontBelongToGroups(groups: string[]): void;
        private static handleNewEntry(entry);
        private static triggerDataValidationRelatedConditionals();
        private static entryHasContext(entry);
        private static updateBoundControl(entry);
        private static updateBindings(entry);
        private static updateValidationBindingWithoutContext(newEntry, fromMasterPage, propName);
        private static updateValidationBindingInsideContext(entry, fromMasterPage, propName);
        private static updateValidationsSummary(entry);
        static resetAllRequiredFieldOccurencesInSummary(): void;
        static removeFromSummaryNotTriggeredRequiredFields(controlNames: Array<string>): void;
        static resetValidationOccurencesInSummary(dv: JbRule): void;
        static removeFromSummaryWhenNotTriggered(dv: JbRule): void;
        private static updatedValidationSummaryForEntryInContext(entry, existing, alreadyInSummary);
        private static updatedValidationSummaryForEntryWithoutContext(entry, existing, alreadyInSummary);
        static gridIsBoundToValidationsSummary(grid: HTMLElement): boolean;
    }
    class Constants {
        static ALL_GROUPS: string;
        static dataValidationRoleMark: string;
        static emptyRequiredMark: string;
        static nowRequiredMark: string;
        static nowNotRequiredMark: string;
        static prevColorAttr: string;
        static errorRole: string;
        static warningRole: string;
        static infoRole: string;
    }
    class UiHelper {
        static panelScope: Joove.Widgets.IValidationUiScope;
        static lastEvaluatedValidationGroups: string[];
        static disablePanel: boolean;
        static showPanel(): void;
        static getAllRequiredFields(): HTMLElement[];
        static emptyRequiredFieldsExist(): boolean;
        static updateEmptyRequiredFieldsState(groups: Array<string>, markEmpty: boolean): void;
        static getRequiredFieldsThatMustBeIgnored(): HTMLElement[];
        private static handleConditionallyHiddenAndNotRequiredFields();
        static refreshPanel(): void;
        static navigateFromDvBoundControl(el: HTMLElement): void;
        static navigateToRelatedControl(dvEntry: Joove.Validation.BindingEntry): void;
        static getAffectedControls(dvEntry: Joove.Validation.BindingEntry): JQuery;
        static navigateToRelatedControlInGrid(dvEntry: Joove.Validation.BindingEntry, $controls: JQuery, recursionSettings?: any): void;
        static markDataValidationRelatedControls(forOnChange: boolean): void;
        private static applyDataValidationColorRoleToAffectedControls(dv);
        private static changeColorRole($el, role, fromDataValidation);
        private static resetColorRole($el, fromDataValidation);
        static markEmptyRequired($el: JQuery): void;
        static unmarkEmptyRequired($el: JQuery): void;
        private static fieldIsEmpty($element);
        private static getEmptyRequiredFields(groups);
        private static setFocusOnField($element);
        private static addStateToField($element, state);
        private static removeStateFromField($element, state);
    }
}
