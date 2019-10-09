declare namespace Joove.Widgets {
    class ExportHelper {
        constructor(listRef: DataListControl);
        private listReference;
        getPopUpContent(): JQuery;
        okCallback($container: JQuery): void;
        private getExportPopUpMarkUp();
        private getExportDisplayColumns();
        private populateExportPopUpTableDisplayContainer();
        private populateExportPopUpContainer($container, isNotPopUp);
        private addScrollListener($element);
        private isDataTypeNumeric(columnInfo);
        private populateVisibleColumns($container);
        private addAggregatorsForExport($container, visibleColumnsCollection);
        private prepareRequestParameters(exportOptions);
        private export(opts);
    }
}
