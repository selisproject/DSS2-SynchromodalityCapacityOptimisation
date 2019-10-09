declare namespace Joove.Widgets {
    interface IDataListTextResources {
        Search?: any;
        NoResults?: any;
        Info?: any;
        PageSize?: any;
        Records?: any;
        All?: any;
        Loading?: any;
        Processing?: any;
        First?: any;
        Last?: any;
        Next?: any;
        Previous?: any;
        True?: any;
        False?: any;
        CalculateSum?: any;
        CalculateAverage?: any;
        CalculateCount?: any;
        ColumnVisibility?: any;
        Copy?: any;
        CopyTitle?: any;
        CopySuccessSingle?: any;
        CopySuccessMulti?: any;
        GrandTotal?: string;
        PageTotal?: string;
        GrandAverage?: string;
        PageAverage?: string;
        GrandCount?: string;
        PageCount?: string;
        SelectAllRecordsText?: any;
        DeselectAllRecordsText?: any;
        SelectAllPageRecordsText?: any;
        DeselectAllPageRecordsText?: any;
        ExportType?: any;
        ExportRange?: any;
        ExportRangeCurrent?: any;
        ExportRange100?: any;
        ExportRangeAll?: any;
        ExportOnlyGroups?: any;
        HeaderColor?: any;
        OddColor?: any;
        EvenColor?: any;
        GroupColor?: any;
        AggregateColor?: any;
        DisplayColumns?: any;
        TotalNonGroupCount?: any;
        PortraitOrientation?: any;
        IncludeGridLines?: any;
        FileName?: any;
        CountHeader?: any;
        VisibleExport?: any;
        ColumnExport?: any;
        SumHeader?: any;
        AverageHeader?: any;
        Export?: any;
        OneRowSelected?: any;
        MulitpleRowsSelected?: any;
        DialogOkButton?: any;
        DialogCancelButton?: any;
        Grouping?: any;
        Column?: any;
        GroupingOrder?: any;
        GetGroupsClosed?: any;
        MergedGroupLevels?: any;
        ViewName?: any;
        View?: any;
        Views?: any;
        DeleteView?: any;
        SaveView?: any;
        InvalidViewName?: any;
        IsViewDefault?: any;
        DeleteConfirmation?: any;
        QuickFilters?: any;
        Import?: any;
        ImportDownload?: any;
        ImportUpload?: any;
        ImportEncoding?: any;
        ImportResult?: any;
        ImportSuccess?: any;
        ImportError?: any;
        ImportErrorList?: any;
        ClearSearch?: any;
        MaxSelectedRowsLimitationTitle?: any;
        MaxSelectedRowsLimitationMessage?: any;
        Actions?: any;
        SelectionActions?: any;
        Refresh?: any;
        FiltersPopUpTitle?: any;
        ActiveView?: any;
        Reset?: any;
        ExportTitle?: any;
    }
    class DataListControlResources {
        readonly textResources: IDataListTextResources;
        readonly dataTablesResources: {
            "decimal": string;
            "emptyTable": string;
            "info": string;
            "infoEmpty": string;
            "infoFiltered": string;
            "infoPostFix": string;
            "thousands": string;
            "lengthMenu": string;
            "loadingRecords": string;
            "processing": string;
            "search": string;
            "zeroRecords": string;
            "paginate": {
                "first": string;
                "last": string;
                "next": string;
                "previous": string;
            };
            "aria": {
                "sortAscending": string;
                "sortDescending": string;
            };
            "buttons": {
                "colvis": string;
                "copy": string;
                "copyTitle": string;
                "copySuccess": {
                    1: string;
                    _: string;
                };
            };
            "select": {
                "rows": {
                    _: string;
                    0: string;
                    1: string;
                };
            };
        };
        constructor(res: any);
        static icons: {
            remove: {
                bs: string;
                fa: string;
            };
            filter: {
                bs: string;
                fa: string;
            };
            search: {
                bs: string;
                fa: string;
            };
            aggregator: {
                bs: string;
                fa: string;
            };
            menuItem: {
                bs: string;
                fa: string;
            };
        };
    }
}
