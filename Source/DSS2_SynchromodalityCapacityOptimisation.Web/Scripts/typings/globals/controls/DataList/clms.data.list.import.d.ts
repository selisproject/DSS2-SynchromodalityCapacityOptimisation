declare namespace Joove.Widgets {
    class ListImportResult {
        NumberImported: number;
        NumberFailled: number;
        Errors: Array<ImportError>;
    }
    class ImportError {
        RowNumber: number;
        ErrorMessage: string;
        ErrorDescription: string;
    }
    class ImportHelper {
        private listRef;
        private $labelContent;
        private $dndBox;
        constructor(listRef: DataListControl);
        getPopUpContent(): JQuery;
        downloadCsvTemplate(): void;
        uploadCsvForImport(files: Array<any>, $content: JQuery): void;
        showImportResults(results: ListImportResult, $content: JQuery): void;
        resetResults($contents: JQuery): void;
    }
}
