/// <reference types="jquery" />
declare namespace Joove {
    class BackEndInformationAggregator {
        private _masterPageEntryPoint;
        private _maximumModelSizeInMB;
        private cmdStack;
        running: boolean;
        constructor(masterPageEntryPoint: string);
        private checkSize(data);
        get(forMaster: boolean, options?: JQueryAjaxSettings): void;
        registerOnCompleteHook(action: (status: JQueryXHR | null) => void): void;
        private runOnCompleteHook(jqXhr);
    }
}
