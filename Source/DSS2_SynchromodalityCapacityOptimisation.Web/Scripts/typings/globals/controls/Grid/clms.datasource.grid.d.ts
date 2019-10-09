declare namespace Joove.Widgets {
    interface IDatasourceGridStatus {
        columns: Array<ColumnInfo>;
        filterBy: Array<DataSourceGridFilter>;
        orderBy: Array<OrderByInfo>;
        currentPage: number;
        pageSize: number;
    }
    enum FilterType {
        Global = 0,
        Simple = 1,
    }
    class DataSourceGridFilter extends FilterInfo {
        type: FilterType;
    }
    class JooveGridHelper {
        status: IDatasourceGridStatus;
        private $element;
        private parentIsVisible;
        private hideTimeout;
        private fromMasterForm;
        private lastGlobalFilter;
        constructor($el: JQuery, pageSize: number, fromMasterForm: boolean);
        hideParentFieldSet(): void;
        showParentFieldSet(): void;
        private prepareRequest();
        fetchData(cb?: Function): void;
        globalFilterChanged(newValue: string): boolean;
        globalFilter(value: string): void;
        clearAllFilters(): void;
        clearGlobalFilter(): void;
        addFilter(columnName: string, value: string, filterOp: FilterOperators, rowOp: RowOperators, overwriteExisting: boolean, type: FilterType): void;
        addOrderBy(columnName: string, direction: OrderByDirections, removeOthers: boolean): void;
        private getColumnInfoByName(name);
    }
}
