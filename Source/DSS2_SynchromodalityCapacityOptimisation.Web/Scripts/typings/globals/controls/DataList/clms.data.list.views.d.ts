declare namespace Joove.Widgets {
    class ListView {
        ViewName: string;
        SerializedStatus: any;
        IsDefault: boolean;
    }
    class UserViewsHelper {
        private listRef;
        private options;
        constructor(listRef: DataListControl, options: {
            fetchCb?: Function;
            saveCb?: Function;
            loadCb?: Function;
        });
        private lastStateName;
        private views;
        private storedSelectedKeys;
        defaultView: ListView;
        currentView: ListView;
        dataTablesLoadStateFunction: Function;
        currentViewSerializedStatus: any;
        readonly loadViewFromHashInUrl: boolean;
        fetchAllAvailableViews(): void;
        saveCurrentView(name: string, makeDefault: boolean): void;
        private createKeyForLocalStorageState();
        saveStateToLocalStorage(): void;
        private getStateFromLocalStorage();
        saveView(view: ListView): void;
        deleteView(view: ListView): void;
        loadInitialView(redraw: boolean): void;
        getStoredSelectedKeys(reset: boolean): Array<any>;
        loadDefaultView(redraw: boolean): void;
        private getViewNameFromHashInUrl();
        loadViewByName(viewName: string, redraw: boolean): boolean;
        loadView(view: ListView, redraw: boolean): void;
        getPopUpContent(): JQuery;
        private viewsAreEqual(view1, view2);
        private closePopUp($popUpContent);
        viewStatusIsValid(viewState: any): boolean;
    }
}
