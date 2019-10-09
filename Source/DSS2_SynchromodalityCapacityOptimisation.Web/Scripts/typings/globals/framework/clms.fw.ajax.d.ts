/// <reference types="jquery" />
declare namespace Joove {
    class Ajax {
        private static _requestQueue;
        private static _responseQueue;
        private static _isRequestInProgress;
        private static _pendingRequests;
        private static _pendingRequestsWithOverlay;
        static ajax(settings: {
            modalOverlay?: boolean;
            data?: any;
            url?: string;
            async?: boolean;
            dataType?: any;
            method?: string;
            ignoreQueue?: boolean;
            doInBackground?: boolean;
            processData?: any;
            beforeSend?: Function;
            complete?: Function;
            success?: (data, textStatus: string, jQueryXhr: JQueryXHR) => void;
            error?: (jQueryXhr: JQueryXHR, textStatus: string, errorThrown: string) => void;
        }): void;
        private static _getUnwantedProperties();
        static deleteUnwantedPropertiesSafe(data: any, unwantedProperties?: Array<string>): any;
        private static _deleteUnwantedProperties(data, unwantedProperties?);
        static reduceViewModelData(data: any): any;
        static checkForPending(): void;
        static showProgressBar(): void;
        static hideProgressBar(): void;
        static pendingRequestsWithOverlay(): number;
        static sanitizeSerializedData(data: string): string;
    }
}
