declare namespace Joove.Widgets {
    interface IDataPickListOptions {
        fromMasterPage: boolean;
        excludeSelected: boolean;
        model: any;
        owner: any;
        itemDataType: any;
    }
    class DataPickListControl {
        private readonly $element;
        private readonly $clearAllButton;
        private readonly options;
        private dataList;
        private readonly popupName;
        private selectedItems;
        readonly isBoundToRoot: boolean;
        readonly selectedItemKeys: any[];
        static instancesDic: {
            [name: string]: Widgets.DataPickListControl;
        };
        constructor(element: JQuery, options: any);
        initializePickList(): void;
        configurePopUp(): void;
        configureEvents(): void;
        okCallback(forClearSelectionButton?: boolean): void;
        closeCallback(): void;
        handleSelectedItems(forClearSelectionButton?: boolean): void;
        updateModel(): void;
        handleError(error: any): void;
    }
}
