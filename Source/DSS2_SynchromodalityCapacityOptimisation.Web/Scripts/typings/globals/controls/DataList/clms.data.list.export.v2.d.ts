declare namespace Joove.Widgets {
    class ExportHelperV2 {
        constructor(listRef: DataListControl);
        private listReference;
        getPopUpContent(): JQuery;
        okCallback($container: JQuery): void;
        private getExportPopUpMarkUp();
        private configureExportPopUpContainer($container, isNotPopUp);
        private export(opts);
        private rgb2hex(rgb);
        private hex(x);
    }
}
