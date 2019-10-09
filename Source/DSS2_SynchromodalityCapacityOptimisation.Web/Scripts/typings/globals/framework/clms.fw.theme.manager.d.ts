declare namespace Joove {
    class ThemeManager {
        theme: any;
        static States: {
            None: string;
            Required: string;
            Readonly: string;
            Collapsed: string;
            Expanded: string;
            Disabled: string;
            Active: string;
            GridWithAlternateRowStyle: string;
            SimpleButton: string;
            ImageButton: string;
            LinkButton: string;
            SubMenu: string;
            Direct: string;
            NoIcon: string;
            RequiredEmpty: string;
            DataValidationFailed: string;
            InvalidDataForBinding: string;
            TabsOrientationTop: string;
            TabsOrientationBottom: string;
            TabsOrientationRight: string;
            TabsOrientationLeft: string;
        };
        static StateTransitions: {
            from: string;
            to: string;
            inverse: boolean;
        }[];
        static DefaultStatesToClassMappings: {};
        static DefaultControlSpecificVariables: {};
        static DefaultClasses: {
            None: string;
            Required: string;
            Readonly: string;
            Collapsed: string;
            Expanded: string;
            Disabled: string;
            Active: string;
            GridWithAlternateRowStyle: string;
            SimpleButton: string;
            ImageButton: string;
            LinkButton: string;
            SubMenu: string;
            Direct: string;
            NoIcon: string;
            RequiredEmpty: string;
            DataValidationFailed: string;
            InvalidDataForBinding: string;
            TabsOrientationTop: string;
            TabsOrientationBottom: string;
            TabsOrientationRight: string;
            TabsOrientationLeft: string;
        };
        static DefaultTheme: {
            controlSpecificVariables: {};
            defaultClassesByState: {
                None: string;
                Required: string;
                Readonly: string;
                Collapsed: string;
                Expanded: string;
                Disabled: string;
                Active: string;
                GridWithAlternateRowStyle: string;
                SimpleButton: string;
                ImageButton: string;
                LinkButton: string;
                SubMenu: string;
                Direct: string;
                NoIcon: string;
                RequiredEmpty: string;
                DataValidationFailed: string;
                InvalidDataForBinding: string;
                TabsOrientationTop: string;
                TabsOrientationBottom: string;
                TabsOrientationRight: string;
                TabsOrientationLeft: string;
            };
            statesToClassMappings: {};
        };
        constructor(theme: any);
        getControlVariableByElement: (varName: any, $element: JQuery) => {
            name: string;
            value: string;
        };
        getSControlVariable: (varName: string, controlType: string, variation: string, colorRole: string, sizeRole: string) => {
            name: string;
            value: string;
        };
        private findVariableByNameInArray(varName, all);
        getCssClassesByRole: ($element: JQuery, role: string) => string;
        getAllControlVariablesByElement: ($element: JQuery) => {
            name: string;
            value: string;
        }[];
        getAllControlVariables: (controlType: string, variation: string, colorRole: string, sizeRole: string) => {
            name: string;
            value: string;
        }[];
        getControlTypeTree($element: JQuery): string;
        getControlTreePartOfControl($element: JQuery): string;
        getControlStateAttribute($element: JQuery): string;
        pathsAreMatching(treePath: any, rulePath: any): boolean;
        getPathWithoutStates(path: any): string;
        getClassMappingsByTypeAndState($element: any, type: any, state: any): any[];
        setControlState($control: any, state: any): void;
        removeControlState($control: any, state: any): void;
        getOppositeState(state: any): string;
        getActiveClassesOfElementByState($element: any, state: any): any[];
        transferClassesOfStateToOtherElement($source: any, $destination: any, state: any): void;
        transferRemovalOfClassesOfStateToOtherElement($source: any, $destination: any, state: any): void;
        toggleFieldsetSate(btn: any): void;
        setFieldsetState($fieldset: any, stateToSet: any): void;
        toggleTreeNodeState(el: any): void;
        applyTreeNodeState($element: JQuery, stateToSet: any): void;
    }
    class ThemeRPC {
        static SelectedMarkClass: string;
        static IconLibraryId: string;
        enable(): void;
        private sendReadyMessage();
        private validateOrigin(event);
        private onCommandReceived(data);
        private drawIcons(icons);
        private updateStylesheet(stylesheet, imports);
        private selectIcon(icon);
        private selelectElement(element);
        private scrollToElement($target);
        private clearThemeCssClassFromElement($el);
        private applyDefaultRolesToElements(data);
        private applyThemeRulesToElements(data);
        private applyThemeRule(data);
        private applyThemeDefinedClassesToElement($current, classes);
        private applyThemeDefinedAttributesToElement($el, attributes);
        private createElementSelector(data);
        private updateThemeVariables(variables, type);
        private reloadCharts();
    }
}
