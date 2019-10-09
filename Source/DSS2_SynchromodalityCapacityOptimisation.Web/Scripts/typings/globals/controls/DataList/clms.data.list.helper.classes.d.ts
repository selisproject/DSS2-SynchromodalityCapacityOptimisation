declare namespace Joove.Widgets {
    interface IDataListOptions {
        isStandAlone?: boolean;
        isPickList?: boolean;
        waitForPredefinedFilters?: boolean;
        showRowNumbers?: boolean;
        hasPaging?: boolean;
        displayRecordsInfoRow?: boolean;
        hasMultiSelect?: boolean;
        hasReorderableColumns?: boolean;
        hasResizableColumns?: boolean;
        canHideShowColumns?: boolean;
        canCopyToClipboard?: boolean;
        showRefreshButton?: boolean;
        isExportable?: boolean;
        isGroupable?: boolean;
        isSearchable?: boolean;
        importData?: boolean;
        saveViews?: boolean;
        structuredFiltering?: boolean;
        rememberSelectedItems?: boolean;
        rememberLastState?: boolean;
        predefinedGroups?: Array<any>;
        predefinedAggregators?: Array<any>;
        onUpdateAction?: any;
        pageSizes?: Array<number>;
        userCanSelectPageSize?: boolean;
        maxSelectedRows?: number;
        minColumnWidth?: number;
        useExportV2?: boolean;
    }
    interface IDataListStatus {
        startRow: number;
        pageSize: number;
        columnInfo: Array<DataListColumnInfo>;
        filters: Array<DataListFilterInfo>;
        orderBy: Array<OrderByInfo>;
        aggregators: Array<DataListAggregatorInfo>;
        groupBy: Array<DataListGroupByInfo>;
        getGroupsClosed: boolean;
        mergeGroupLevels: boolean;
        excludedKeys: Array<any>;
        selectedKeys: Array<any>;
        selectedItems: Array<any>;
        allKeysSelected: boolean;
        exportSettings: {
            type: string;
            range: string;
            fileName: string;
            exportTitle: string;
            includeGridLines: boolean;
            portraitOrientation: boolean;
            columnInfo: Array<DataListColumnInfo>;
            groupInfo: Array<DataListGroupByInfo>;
            headerColor: string;
            evenColor: string;
            oddColor: string;
            groupColor: string;
            aggregateColor: string;
        };
    }
    class DataListColumnInfo extends ColumnInfo {
        constructor(options: any);
        mambaDataType: any;
        mambaDataTypeIsEnum: any;
        caption: any;
        dataType: any;
        visible: any;
        groupable: any;
        searchable: any;
        orderable: any;
        editable: any;
        style: any;
        classes: any;
        itemType: any;
        importable: any;
        supportsAggregators: any;
        width: any;
        minWidth: any;
        customWidth: any;
        length: number;
        css: string;
        showFullImage: boolean;
    }
    class DataListFilterInfo extends FilterInfo {
        constructor(columnInfo: ColumnInfo, value: any, rowOp: RowOperators, op: FilterOperators, secondValue: any, type: DataListFilterType, controlId?: string);
        type: DataListFilterType;
        controlId: string;
    }
    class DataListAggregatorInfo {
        constructor(column: any, type: any);
        column: string;
        type: AggregatorTypes;
        enabled: boolean;
        encrypted: boolean;
    }
    class DataListGroupByInfo extends GroupByInfo {
        constructor(column: any, initialState?: any, getGroupsClosed?: boolean, inactive?: boolean);
    }
    enum DataListColumnItemType {
        HYPERLINK = 0,
        DOWNLOADLINK = 1,
        CHECKBOX = 2,
        IMAGEBOX = 3,
        TEXTBOX = 4,
        HTML = 5,
    }
    enum DataListFilterType {
        Quick = 0,
        Global = 1,
        Custom = 2,
    }
}
