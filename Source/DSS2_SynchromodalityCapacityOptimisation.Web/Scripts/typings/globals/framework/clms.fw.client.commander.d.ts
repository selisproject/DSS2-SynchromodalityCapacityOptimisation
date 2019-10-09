declare namespace Joove {
    class ClientCommander {
        availableCommands: {
            DATALIST_REFRESH: string;
            DATALIST_CLEAR_SELECTED_ITEMS: string;
            DATALIST_UPDATE_SIZE: string;
            GRID_GOTO_LAST_PAGE: string;
            GRID_GOTO_PREV_PAGE: string;
            GRID_GOTO_NEXT_PAGE: string;
            GRID_GOTO_FIRST_PAGE: string;
            GRID_GOTO_PAGE: string;
            SHOW_MESSAGE: string;
            SHOW_MODAL: string;
            HIDE_MODAL: string;
            CHART_REFRESH: string;
            PUSH_TO_NAVIGATION_HISTORY: string;
            CLOSE_FORM: string;
            REDIRECT: string;
            GRID_REFRESH: string;
            MAP_REFRESH: string;
            MAP_DIRECTIONS: string;
            MAP_FITCONTENT: string;
            EXPORT_FORM_TO_PDF: string;
            EXPORT_CONTROL_TO_PDF: string;
            EXECUTE_JS: string;
            DROPDOWN_REFRESH: string;
            COMMIT_ALL_FILES: string;
            CALENDAR_REFRESH: string;
            SET_DIRTY: string;
            DOWNLOAD: string;
        };
        executeCommands(commandList: Array<any>): void;
        commitAllFiles(): void;
        executeJs(args: Array<any>): void;
        setDirty(args: Array<any>): void;
        calendarRefresh(args: Array<any>): void;
        mapRefresh(args: Array<any>): void;
        mapDirections(args: Array<any>): void;
        mapFitToContent(args: Array<any>): void;
        redirect(args: Array<any>): void;
        closeForm(): void;
        pushToHistory(): void;
        showModal(modalName: any): void;
        hideModal(modalName: any): void;
        showMessage(args: Array<any>): void;
        chartRefresh(args: Array<any>): void;
        dataListApplyPredefinedFilters(args: Array<any>): void;
        dataListClearFilters(args: Array<any>): void;
        dataListRefresh(args: Array<any>): void;
        dataListClearItems(args: Array<string>): void;
        dataListUpdateSize(args: Array<any>): void;
        gridGotoLastPage(args: Array<any>): void;
        gridGotoPrevPage(args: Array<any>): void;
        gridGotoNextPage(args: Array<any>): void;
        gridGotoFirstPage(args: Array<any>): void;
        gridGotoPage(args: Array<any>): void;
        gridRefresh(args: Array<any>): void;
        exportFormToPdf(args: Array<any>): void;
        exportControlToPdf(args: Array<any>): void;
        dropdownRefresh(args: Array<any>): void;
        download(args: Array<any>): void;
        getGridDirectiveScope(gridName: string, cb: Function, attemptNumber?: number): void;
        getControlByName(name: string): JQuery;
    }
    interface IHistoryManager {
        pushToHistory(url: string): any;
        clear(): any;
        save(): any;
        navigate(url: string): any;
        back(): any;
    }
    class DebugConsoleStatus {
        visible: boolean;
        minimized: boolean;
        width: number;
        bodyHeight: number;
        footerHeight: number;
        top: any;
        left: any;
    }
    class DebugConsoleManager {
        private _storageKey;
        debugConsoleStatus: DebugConsoleStatus;
        constructor();
        savePosition(top: any, left: any): void;
        saveSize(width?: number, bodyHeight?: number, footerHeight?: number): void;
        saveVisibility(visible: boolean, minimized?: boolean): void;
        clear(): void;
    }
    class HistoryManager implements IHistoryManager {
        urls: Array<string>;
        private _storageKey;
        private _maxHistory;
        constructor();
        pushToHistory(url: string): void;
        save(): void;
        clear(): void;
        navigate(url: string): void;
        trimLastQuestionmarkFromURL(url: string): string;
        back(): void;
    }
    enum ScriptState {
        LOADED = 0,
        LOADING = 1,
    }
    class ScriptLoaderManager {
        private scriptsStates;
        constructor(scriptsStates: any);
        requireScript(id: string, src: string, callback?: () => void): Promise<boolean>;
        isScriptLoaded(id: string): boolean;
        private waitForScriptLoad(lookFor, callback);
    }
}
