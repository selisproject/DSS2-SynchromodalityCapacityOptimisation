declare namespace Joove {
    enum DataSourceTypes {
        None = 0,
        MANUAL = 1,
        BUSINESSOBJECT = 2,
        WEBSERVICE = 4,
        VIEWMODEL = 8,
        WORKITEM = 16,
    }
    enum FilterOperators {
        NONE = 0,
        EQUAL_TO = 1,
        NOT_EQUAL_TO = 2,
        LESS_THAN = 3,
        GREATER_THAN = 4,
        LESS_THAN_OR_EQUAL_TO = 5,
        GREATER_THAN_OR_EQUAL_TO = 6,
        LIKE = 7,
        RANGE = 8,
        HAS_VALUE = 9,
        HAS_NO_VALUE = 10,
    }
    enum RowOperators {
        NONE = 0,
        AND = 1,
        OR = 2,
    }
    enum OrderByDirections {
        ASC = 0,
        DESC = 1,
        NONE = 2,
    }
    enum AggregatorTypes {
        SUM = 0,
        AVERAGE = 1,
        COUNT = 2,
    }
    enum GroupState {
        EXPANDED = 0,
        COLLAPSED = 1,
    }
    type ViewModelCollection = System.Linq.IOrderedEnumerable<any> | System.Linq.LinqEnumerable<any>;
    interface IViewModelDatasetResult<T> {
        Data: Array<T>;
        TotalRows: number;
        Groups: any;
        RuleEvaluations: any;
    }
    abstract class IViewModelDataset<T> {
        protected model: any;
        protected partialViewControlName: string;
        binding: string;
        context: string;
        limit: number;
        abstract Filter(inputs: any): (element: T, index: number, items: Array<T>) => boolean;
        abstract Sort(items: ViewModelCollection): ViewModelCollection;
        abstract PackInputs($control: JQuery): any;
        constructor(model: any, partialViewControlName?: string);
        GetSource(parents: number[]): Joove.ViewModelCollection;
        GetContext($control: JQuery): any;
        Retrieve(inputs: any, requestInfo: DatasourceRequest, aggregatorsInfo: Array<any>, context: any): IViewModelDatasetResult<T>;
        ChartMapper(x: string, y: Array<string>, title: Array<string>, r?: Array<string>): (item: any) => {
            Item: any;
            Radius: any[];
            Label: any;
            Values: any[];
            ValueLabels: string[];
        };
        ChartMapperAggregation(x: string, y: Array<string>, labels?: any, dynamic?: boolean): (item: any) => {
            Item: any;
            Label: any;
            Radius: any[];
            Values: any[];
            ValueLabels: any;
        };
        private GetOrderBy(requestInfo);
        private ExcludeKeys(keys);
        private GetFilterBy(inputs, requestInfo);
        private GroupBy(items, requestInfo, aggregatorsInfo?);
        private RetrieveGroup(items, root, groupBys, prefix, index, aggregatorsInfo?);
        private GetGroup(id, key, group);
        private CalculateAggregation(items, aggregatorsInfo);
    }
    class ColumnInfo {
        name: string;
        mambaDataType: string;
        formatting: ValueFormat;
        searchable: boolean;
        groupable: boolean;
        isEncrypted: boolean;
        caption: string;
        dataType: any;
        isVisible: any;
        orderable: any;
        width: any;
        minWidth: any;
        customWidth: any;
        supportsAggregators: any;
        constructor(name: string, dt: string, formatting?: ValueFormat, searchable?: boolean, isEncrypted?: boolean);
        getMambaDataType(): MambaDataType;
    }
    class FilterInfo {
        column: ColumnInfo;
        value: any;
        rowOperator: RowOperators;
        operator: FilterOperators;
        secondValue: any;
        constructor(columnInfo: ColumnInfo, value: any, rowOp: RowOperators, op: FilterOperators, secondValue: any);
    }
    class OrderByInfo {
        column: ColumnInfo;
        direction: OrderByDirections;
        constructor(columnInfo: ColumnInfo, direction: OrderByDirections);
    }
    class GroupByInfo {
        column: ColumnInfo;
        state: any;
        inactive: any;
        getGroupsClosed: any;
        constructor(columnInfo: ColumnInfo, state: any, inactive: any, getGroupsClosed: any);
    }
    class DatasourceRequest {
        startRow: any;
        pageSize: number;
        filters: any;
        orderBy: Array<OrderByInfo>;
        excludeKeys: any;
        groupBy: Array<GroupByInfo>;
        indexes: any[];
        aggregators: any;
        DtoProperties: Array<string>;
        constructor($control: JQuery, startRow: any, pageSize: number, filters?: any, orderBy?: Array<OrderByInfo>, excludeKeys?: any, groupBy?: Array<GroupByInfo>);
        setExludeKeys(excludeKeys: any): void;
    }
    interface IDataSourceControlScope extends IJooveScope {
        $sortBy: (e: Event, member: string) => void;
        $clearFilters: (e: Event) => void;
        $applyFilters: (e: Event) => void;
        $addFilter: (e: Event, columnName: string, filterOp: string, rowOp: string, overwriteExisting: boolean, autoApply: boolean) => void;
        $globalFilter: (e: Event, autoApply: boolean) => void;
    }
    interface IDatasoureCallbacks {
        success?: Function;
        error?: Function;
        complete?: Function;
        onStart?: Function;
        onFinish?: Function;
    }
    class DatasourceManager {
        private static _throttle;
        private static _queue;
        private static _partialControlNames;
        static makeAsyncRequests: boolean;
        static getFetchViewModelDatasetClientSideHandler($control: JQuery, forMasterPage: boolean, call: boolean): any;
        static couldUseFetchViewModelDataseClientSideHandler($control: JQuery, forMasterPage: boolean): boolean;
        static fetchItemFromViewModelDataset<T>($control: JQuery, key: any, forMasterPage: boolean): T;
        static fetchItemsFromViewModelDataset<T>($control: JQuery, keys: Array<any>, forMasterPage: boolean): Array<T>;
        static fetchViewModelDataset($control: JQuery, forMasterPage: boolean, request: DatasourceRequest, aggregatorsInfo: Array<any>): Array<any>;
        static parseStringToFilterOperator(str: string): FilterOperators;
        static parseStringToRowOperator(str: string): RowOperators;
        static parseStringToOrderByDirection(str: string): OrderByDirections;
        static getDataSetColumnInfo(dsName: string): Array<ColumnInfo>;
        static getDataSetColumnInfoFromControl($el: JQuery): Array<ColumnInfo>;
        static getDatasetType($el: JQuery): Joove.DataSourceTypes;
        static getDataSetNameFromControl($el: JQuery): string;
        static getDtoTypeFromControl($el: JQuery): string;
        static getControlsUsingDataSet(ds: string): JQuery;
        static getOnStartFetchDatasetActionForControl($el: JQuery, masterPage?: boolean): () => void;
        static getOnFinishFetchDatasetActionForControl($el: JQuery, masterPage?: boolean): (items: Array<any>) => void;
        static getSelectedItems($el: JQuery, e: Event): Array<any>;
        static getSelectedItem($el: JQuery, e: Event): any;
        static GetOnChangeHandler($element: JQuery): Function;
        static HasOnChangeHandler($element: JQuery): boolean;
        static invokeOnChangeHandler($element: JQuery): void;
        static isMambaDataTypeNumber(dataType: string): boolean;
        static getDatasetControlInputs($control: JQuery): any;
        static addToQueue(url: string, postData: any, callbacks: IDatasoureCallbacks): void;
        static removeFromQueue(url: string, postData: any, callbacks: Array<IDatasoureCallbacks>): void;
        static getFromQueue(url: string, postData: any, callbacks: IDatasoureCallbacks): any;
        static getQueueKey(url: string, postData: any, callbacks: IDatasoureCallbacks | Array<IDatasoureCallbacks>): string;
        static requestForSameControlIsInQueue(url: string, postData: any, callbacks: IDatasoureCallbacks): any;
        static makeDatasourceRequest(url: string, postData: any, controlName: string, callbacks: IDatasoureCallbacks): void;
        static callBackEnd(url: string, postData: any, controlName: string, callbacks: Array<IDatasoureCallbacks>): void;
        static updateTotalRowValues(controlName: string, data: any): void;
        static fetchDatasourceForJsApi(options: {
            dsName: string;
            pageSize: number;
            startRow: number;
            fields: Array<string>;
            filters: Array<FilterInfo>;
            ordering: Array<OrderByInfo>;
            grouping: Array<GroupByInfo>;
            done: Function;
            forMaster: boolean;
            error?: Function;
            complete?: Function;
        }): void;
        static NO_VALUE: string;
        static fetch($control: JQuery, controlName: string, requestInfo: DatasourceRequest, callbacks: IDatasoureCallbacks, aggregatorsInfo: Array<any>, forMasterPage?: boolean): void;
        static invokeClientSideDatasource(func: Function, args: Array<any>, callbacks: IDatasoureCallbacks): void;
        static fetchManualDatasource(serverSideElementId: string, forMaster?: boolean): any;
        static fetchDatasource($control: JQuery, controlName: string, requestInfo: DatasourceRequest, callbacks: IDatasoureCallbacks, forMasterPage?: any): void;
        static getAggregatorsRequest(requestInfo: DatasourceRequest): any;
        static fetchDatasourceAggregators($control: any, controlName: string, requestInfo: DatasourceRequest, aggregatorsInfo: any, callbacks: IDatasoureCallbacks, forMasterPage?: any): void;
        static updateSelectedKeysInModel(controlName: string, keys: any, allRecordsSelected: boolean, indexes: any, forMasterPage?: any): void;
        static requestSelectedItemsfromServer(controlName: string, $control: JQuery, itemsDataType: string, requestFullRecordset: boolean, selectedKeys: any, keysToExclude: any, datasourceRequest: any, cb: Function, fromMasterPage?: any): void;
        static getKeys(collection: any): Array<any>;
        static getObjectKey(obj: any): string;
        static watchDependencies(formScope: IJooveScope, $element: JQuery, cb: Function, dependenciesAttribute?: string): any;
        static getInitialValueModelPath(controlName: string, $control: JQuery): string;
        static getInitialValueFromModel(controlName: string, $control: JQuery): any;
        static isInitialSelectionAvailable(controlName: string, $control: JQuery): boolean;
        static removeInitialValue(controlName: string, $control: JQuery): void;
        static getInitialValue($control: JQuery, controlName: string, callbacks: IDatasoureCallbacks): any;
        static addFilterToDataSet: (dsName: string, e: Event, columnName: string, filterOp: string, rowOp: string, overwriteExisting: boolean, autoApply: boolean) => void;
        static addGlobalFilterToDataSet: (dsName: string, e: Event, autoApply: boolean) => void;
        static sortControlsBoundToDataSet(ds: string, member: string, e: Event): void;
        static applyFiltersToControlsBoundToDataSet(ds: string, e: Event): void;
        static clearFiltersToControlsBoundToDataSet(ds: string, e: Event): void;
    }
}
