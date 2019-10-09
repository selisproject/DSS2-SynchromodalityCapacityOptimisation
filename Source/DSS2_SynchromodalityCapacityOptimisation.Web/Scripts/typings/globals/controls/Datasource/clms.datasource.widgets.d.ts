declare namespace Joove.Widgets {
    type DatasourceTerm = FilterInfo | GroupByInfo | OrderByInfo;
    interface IDatasourceWidget {
        draw($target: JQuery): any;
        redraw(columns: DatasourceTerm[], options?: any): any;
        clear(): any;
        getDataSourceTerms(options?: any): Array<DatasourceTerm>;
        getColumns(): ColumnInfo[];
    }
    interface IGroupDatasourceWidgetResource {
        Column?: any;
        GroupingOrder?: any;
        GetGroupsClosed?: any;
    }
    interface IOrderDatasourceWidgetResource {
        SortOrder?: any;
        Order?: any;
        Visible?: any;
        Column?: any;
        Sorting?: any;
    }
    interface IExportDatasourceWidgetResource {
        ExportType: any;
        ExportRange: any;
        ExportRangeCurrent: any;
        ExportRange100: any;
        ExportRangeAll: any;
        FileName: any;
        ExportOnlyGroups: any;
        PortraitOrientation: any;
        IncludeGridLines: any;
        TotalNonGroupCount: any;
        DisplayColumns: any;
        GroupColor: any;
        HeaderColor: any;
        EvenColor: any;
        OddColor: any;
        AggregateColor: any;
    }
    interface IFilterDatasourceWidgetResource {
        Or?: string;
        And?: string;
        Range?: string;
        Like?: string;
        EqualTo?: string;
        NotEqualTo?: string;
        GreaterThan?: string;
        GreaterThanOrEqualTo?: string;
        LessThan?: string;
        LessThanOrEqualTo?: string;
        HasValue?: string;
        HasNoValue?: string;
        DownloadCsv?: string;
        UploadCsv?: string;
        PreferedEncoding?: string;
        ColumnExport?: string;
        VisibleExport?: string;
        SumHeader?: string;
        AverageHeader?: string;
        CountHeader?: string;
        ViewName?: string;
        IsDefault?: string;
        SaveCurrentViewNameAlert?: string;
        OverwriteCurrentView?: string;
        DeleteCurrentViewCommand?: string;
        MakeDefaultConfirmation?: string;
        NoResults?: string;
        PreferencesPopUpTitle?: string;
        Apply?: string;
        ClearAll?: string;
        FiltersPopUpTitle?: string;
        Column?: string;
        GetGroupsClosed?: string;
        Operator?: string;
        Criteria?: string;
        RowOperator?: string;
        NoFiltersDefined?: string;
        AddFilter?: string;
        True?: string;
        False?: string;
        ShowQuickFilters?: string;
        HideQuickFilters?: string;
        ApplyQuickFilter?: string;
        ClearQuickFilter?: string;
        FiltersApplied?: string;
        SelectAllRecordsPromptText?: string;
    }
    abstract class DatasourceWidget {
        protected _columns: Array<ColumnInfo>;
        protected _container: JQuery;
        protected _forceDraw: boolean;
        protected _controlName: string;
        constructor(options: {
            columns: Array<ColumnInfo>;
            container?: JQuery;
            forceDraw?: boolean;
            controlName?: string;
        });
        protected findColumnInfoByName(name: any): ColumnInfo;
        protected flashElement($element: any): void;
        protected retrieveColumnInfo(cb?: Function): void;
        abstract draw($target: JQuery): any;
        abstract getDataSourceTerms(options?: any): Array<DatasourceTerm>;
        abstract getColumns(): ColumnInfo[];
        abstract redraw(columns: DatasourceTerm[], options?: any): any;
        clear(): void;
    }
    class FilterDatasourceWidget extends DatasourceWidget {
        protected _resources: IFilterDatasourceWidgetResource;
        protected _filters: Array<FilterInfo>;
        private _rowOperators;
        private _operators;
        constructor(options: {
            columns: ColumnInfo[];
            container?: JQuery;
            resources?: IFilterDatasourceWidgetResource;
            filters?: FilterInfo[];
            forceDraw?: boolean;
            controlName?: string;
        });
        getColumns(): ColumnInfo[];
        draw($target: JQuery): void;
        redraw(terms: DatasourceTerm[], options?: any): void;
        getDataSourceTerms(options?: any): Array<DatasourceTerm>;
        private drawFilters($contents);
        private populate($contents);
        private createFilterRow($container?);
        private drawPreferences();
        private handleFilterRow($container, dataType?, operator?, value?);
    }
    class QuickFilterDatasourceWidget extends FilterDatasourceWidget {
        draw($target: JQuery): void;
        getDataSourceTerms(options?: any): DatasourceTerm[];
        getColumns(): ColumnInfo[];
        redraw(terms: DatasourceTerm[]): void;
        private drawQuickFilterLayout();
        private populateQuickFilters($content);
    }
    class GroupDatasourceWidget extends DatasourceWidget {
        private _resources;
        private _groupBy;
        private _getGroupsClosed;
        constructor(options: {
            columns: Array<ColumnInfo>;
            container?: JQuery;
            resources?: IGroupDatasourceWidgetResource;
            groupBy?: Array<GroupByInfo>;
            groupsClosed?: boolean;
            controlName?: string;
        });
        getColumns(): ColumnInfo[];
        draw($target: JQuery): void;
        redraw(terms: DatasourceTerm[], options?: any): void;
        getDataSourceTerms(options?: any): DatasourceTerm[];
        getGroupingPreferencesMarkUp(): string;
        populateGroupPreferencesContainer($container: any): void;
    }
    class OrderDatasourceWidget extends DatasourceWidget {
        private _resources;
        private _orderBy;
        constructor(options: {
            columns: Array<ColumnInfo>;
            container?: JQuery;
            resources: IOrderDatasourceWidgetResource;
            orderBy?: Array<OrderByInfo>;
            controlName?: string;
        });
        draw($target: JQuery): void;
        redraw(terms: DatasourceTerm[], options?: any): void;
        getColumns(): ColumnInfo[];
        getDataSourceTerms(options?: any): DatasourceTerm[];
        private getViewPreferencesMarkUp();
        private populatePreferencesContainer($container);
    }
}
