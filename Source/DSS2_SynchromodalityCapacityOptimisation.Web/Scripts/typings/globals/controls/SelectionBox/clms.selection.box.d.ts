/// <reference types="angular" />
declare namespace Joove.Widgets {
    class SimpleSelectProvider extends BaseAngularProvider {
    }
    interface ISimpleSelectScope extends IJooveScope {
        selectedItems: typeof undefined[];
        selectedItemKeys: typeof undefined[];
        options: typeof undefined[];
        bindingType: string;
        dataLoaded: boolean;
        requestInitialValueOnly: boolean;
        refreshDataFromServerOnFocus: boolean;
        datesetType: Joove.DataSourceTypes;
        fromMasterForm: any;
        contextIsReady: () => boolean;
        contextDepth: any;
        fetchData: (requestInfo: any, attemptNumber: any, cb?: any) => void;
        type: string;
        controlType: SelectionBoxType;
        control: SelectionControl | null;
        itemDataType: any;
        notNull: any;
        val: any;
        txt: any;
        id: string | number;
        orientation: any;
        searchEverywhere: any;
        owner: any;
        dontAddEmptyValue: boolean;
        nullOptionAvailable: boolean;
    }
    function ngSimpleSelect($timeout: ng.ITimeoutService, $interval: ng.IIntervalService, ngRadio: any): ng.IDirective;
    interface ISelectionControl {
        PopulateOption(val: string, txt: string): {
            $option: JQuery;
            $valueHolder: JQuery;
        };
        PopulateOptions(items: Array<any>, clear: boolean): void;
        ClearOptions(redraw: boolean): Promise<boolean>;
        OnChange($valueHolderElement: JQuery): void;
        UpdateSelection(value: any, force: boolean): void;
        UpdateValue(value: any): void;
        UpdateInitialValue(): void;
        Refresh(): void;
        RegisterEventListeners(): void;
        OnValueChanged($valueHolderElement: any): void;
        SetModelValue(value: string | JQuery): void;
        ValueMatchesToAvailableOptions(value: any): boolean;
        IsManual(): boolean;
        IsViewModelBindend(): boolean;
    }
    abstract class SelectionControl implements ISelectionControl {
        protected readonly $scope: ISimpleSelectScope;
        protected readonly $element: JQuery;
        protected defaultText: string;
        protected defaultOption: any;
        constructor($scope: ISimpleSelectScope, $element: JQuery);
        abstract Refresh(): void;
        abstract PopulateOption(val: string, txt: string): {
            $option: JQuery;
            $valueHolder: JQuery;
        };
        abstract UpdateValue(value: any): void;
        abstract UpdateInitialValue(): void;
        abstract RegisterEventListeners(): void;
        abstract ClearOptions(redraw: boolean): Promise<boolean>;
        optionElementsToOptionObjects: {
            [id: string]: any;
        };
        SetDefaultValue(option: any): void;
        GetDefaultValue(): any;
        PopulateOptions(options: Array<any>, clear?: boolean): void;
        OnChange($valueHolderElement: JQuery): void;
        UpdateSelection(value: any, force?: boolean): void;
        OnValueChanged($valueHolderElement: any): void;
        SetModelValue(value: string | JQuery, selectedItem?: any): void;
        IsNotNull(): boolean;
        ValueMatchesToAvailableOptions(value: any): boolean;
        FindOptionInstanceByValue(value: any): any;
        FindOptionObjectByValue(value: any): any;
        GetRelativeProperty(prop: string): string;
        GetOptionProperty(option: any, prop: string): any;
        GetDefaultOption(label: string, value: string): any;
        HasDefaultOptions(items: any[]): boolean;
        IsManual(): boolean;
        IsViewModelBindend(): boolean;
        private SetValue(value);
        private UpdateValueMatchesToAvailableOptions(value);
        static IsNotNull($scope: ISimpleSelectScope): boolean;
        static RemoveEmptyOptions($element: JQuery): void;
        static UpdateTitle($element: JQuery, $target?: JQuery): void;
        static ApplyDefaultSelection($scope: ISimpleSelectScope, $element: JQuery): void;
        static GetControlUniqueName($scope: ISimpleSelectScope, $element: JQuery, model: any): string;
        static UpdateKeysInModel($scope: ISimpleSelectScope, $element: JQuery): void;
        static UpdateObject($scope: ISimpleSelectScope, $element: JQuery, value: any, key: any): void;
        static UpdateScopeAndModelKeys($scope: ISimpleSelectScope, $element: JQuery, selectedObject: any, selectedKey: any): void;
        static GetScope($scope: ISimpleSelectScope): IJooveScope;
        static GetKey(value: any): string;
    }
    class DropdownControl extends SelectionControl {
        PopulateOptions(options: Array<any>, clear?: boolean): void;
        PopulateOption(val: string, txt: string): {
            $option: JQuery;
            $valueHolder: JQuery;
        };
        ClearOptions(redraw: any): Promise<boolean>;
        OnChange(value: string | JQuery): void;
        UpdateInitialValue(): void;
        UpdateValue(value: any): void;
        Refresh(): void;
        RegisterEventListeners(): void;
    }
    class RadioButtonControl extends SelectionControl {
        Refresh(): void;
        UpdateValue(value: any): void;
        UpdateInitialValue(): void;
        ClearOptions(redraw: boolean): Promise<boolean>;
        RegisterEventListeners(): void;
        PopulateOption(val: string, txt: string): {
            $option: JQuery;
            $valueHolder: JQuery;
        };
        PopulateOptions(options: Array<any>, clear?: boolean): void;
        OnChange(value: string | JQuery): void;
    }
    class TypeaheadControl extends SelectionControl {
        private $placeholder;
        Refresh(): void;
        UpdateInitialValue(): void;
        ClearOptions(redraw: boolean): Promise<boolean>;
        RegisterEventListeners(): void;
        UpdateValue(value: any): void;
        PopulateOption(val: string, txt: string): {
            $option: JQuery;
            $valueHolder: JQuery;
        };
        PopulateOptions(items: Array<any>, clear?: boolean): void;
        OnChange(value: string | JQuery): void;
        ValueMatchesToAvailableOptions(value: any): boolean;
        static GetValue(ev: Event): string;
        private GetDataset(items);
        private Equals(a, b);
        private GetDatasetKey(item);
        private IsObject();
        private PrepareItems(items);
    }
    enum SelectionBoxType {
        Dropdown = 0,
        RadioButton = 1,
        Typeahead = 2,
    }
    function GetSelectionBoxType(type: string): SelectionBoxType;
    function GetControl($scope: ISimpleSelectScope, $element: any): SelectionControl | null;
}
interface JQuery {
    typeahead(options?: any, data?: any): JQuery;
    bind(event: string, onFire: Function): any;
    select2(options?: any): JQuery;
}
declare let Bloodhound: any;
