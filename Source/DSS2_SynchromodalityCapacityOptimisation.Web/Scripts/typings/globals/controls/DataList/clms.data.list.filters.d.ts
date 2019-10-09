declare namespace Joove.Widgets {
    interface IJbCompositeFiltersPopUpScope extends IJooveScope {
        $columns: Array<Joove.Widgets.DataListColumnInfo>;
        $filters: Array<Joove.Widgets.DataListFilterInfo>;
        $rowOperators: Array<{
            caption: string;
            value: Joove.RowOperators;
        }>;
        $operators: Array<{
            caption: string;
            value: Joove.FilterOperators;
        }>;
        $helper: CompositeFiltersHelper;
        $hasErrors: boolean;
        $resources: ICompositeFiltersResources;
        $removeFilter: (filter: Joove.Widgets.DataListFilterInfo) => void;
        $addFilter: () => void;
        refreshFilters: (filters: Array<Joove.Widgets.DataListFilterInfo>) => void;
        getFilters: () => Array<Joove.Widgets.DataListFilterInfo>;
        $commit: () => void;
        $cancel: () => void;
    }
    interface ICompositeFiltersResources {
        compositeFilters: string;
        column: string;
        filterType: string;
        criteria: string;
        rowOperator: string;
        valueTrue: string;
        valueFalse: string;
        pleaseFillInAllFields: string;
        add: string;
        clearAll: string;
        ok: string;
        cancel: string;
        and: string;
        or: string;
        like: string;
        equalTo: string;
        notEqualTo: string;
        hasNoValue: string;
        hasValue: string;
        greaterThan: string;
        greaterThanOrEqualTo: string;
        lessThan: string;
        lessThanOrEqualTo: string;
        between: string;
    }
    class CompositeFiltersHelper {
        list: DataListControl;
        scope: IJbCompositeFiltersPopUpScope;
        modalSelector: string;
        resources: ICompositeFiltersResources;
        constructor(list: DataListControl);
        private init();
        show(): void;
        cancel(): void;
        commit(): void;
        private fillResources();
        private toggleModal(action);
        private validateFilters();
        private createFiltersArray;
        private createRowOperatorsArray;
        private getScopeBySelector;
    }
}
