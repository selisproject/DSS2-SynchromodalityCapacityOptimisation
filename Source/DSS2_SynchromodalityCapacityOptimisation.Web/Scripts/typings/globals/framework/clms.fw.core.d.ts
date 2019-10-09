/// <reference types="jquery" />
declare var $$$: (controlName: string, context?: JQuery) => JQuery;
declare const timeout: (interval: number, flag?: boolean) => (target: any, key: string, descriptor: PropertyDescriptor) => void;
declare namespace Joove {
    class ProgressBar {
        private labelPrefix;
        $label: JQuery;
        $bar: JQuery;
        constructor(labelPrefix: any, labelQuery: any, barQuery: any, context: any);
        update(percent: number): void;
        clear(): void;
    }
    class DTOHelper {
        private AlreadySeen;
        fillDb: boolean;
        private _db;
        constructor();
        Reset(): void;
        Add(original: any, value: any): void;
        Has(original: any): boolean;
        Get(original: any): any;
        static GetViewModelKeyForCaching: (original: any) => any;
        addToDb(instance: any): void;
        getDb(): {};
    }
    class Application {
        static Name(): string;
    }
    class Session {
        static CurrentLanguage(): {
            Id: string;
            Code: string;
            Name: string;
            DateTimeFormat: {
                LongDatePattern: string;
                LongTimePattern: string;
                MonthDayPattern: string;
                RFC1123Pattern: string;
                ShortDatePattern: string;
                ShortTimePattern: string;
                YearMonthPattern: string;
            };
        };
        static CurrentLocale(): {
            Id: string;
            Code: string;
            Name: string;
            DateTimeFormat: {
                LongDatePattern: string;
                LongTimePattern: string;
                MonthDayPattern: string;
                RFC1123Pattern: string;
                ShortDatePattern: string;
                ShortTimePattern: string;
                YearMonthPattern: string;
            };
        };
        private static SessionTimeOut;
        private static SessionAboutToExpireTimeOut;
        static ResetSessionExpirationTimeOut(): void;
        private static ShowSessionIsAboutToExpireModal();
        private static ShowSessionExpiredModal();
        private static RefreshSession();
        static SessionConflict(): void;
        static PingServer(cb: Function): void;
    }
    class ValidationException extends Error {
        name: string;
        stack: string;
        constructor(message: string);
    }
    class Core {
        private static _actionTimers;
        private static _scopeApplicationTimeout;
        private static _onChangeCallBacks;
        static currentControllerActionParamName: string;
        static isModalParamName: string;
        private static _megaDictionary;
        static GetOptions(control: JQuery, prop: string): any;
        static ApplicationLocale(): string;
        static ApplicationLanguage(): string;
        static checkAppVersion(): void;
        static checkDbStatus(masterController: string): void;
        static isIE(): boolean;
        static EncodeIfNeeded(verb: string, queryDataPart: any): string;
        static executeRedirectControllerAction(controller: string, action: string, verb: string, queryData: any, postData: any, modalOptions: any, openInNewWindow?: boolean): void;
        static executeControllerActionNew(options: {
            controller: string;
            action: string;
            verb?: string;
            postData?: any;
            rulesInfo?: any;
            queryData?: any;
            cb?: Function;
            onErrorCb?: Function;
            modalOptions?: any;
            rootModelInfo?: any;
            ignoreQueue?: boolean;
            event?: any;
        }): void;
        static executeControllerAction(controller: string, action: string, verb: string, queryData: any, postData: any, threshold: any, cb: any, modalOptions?: any, rulesInfo?: any, onError?: Function): void;
        static prepareDataForFileAction($element: JQuery, model: any): any;
        static uploadFile(options: {
            model: string;
            files: Array<any>;
            indexesKey: any;
            $element: JQuery;
            $progressBar?: ProgressBar;
            targetUrl?: string;
            withProgressBar?: boolean;
            onSuccess: (data?: any, textStatus?: string, jqXhr?: JQueryXHR) => void;
            onError?: (jqXhr?: JQueryXHR, textStatus?: string, errorThrown?: string) => void;
            onComplete?: (jqXhr?: JQueryXHR, textStatus?: string) => void;
        }): void;
        static handleServerResponse(controller: string, data: any, cb?: Function, rulesInfo?: any, modalOptions?: any, rootModelInfo?: any): void;
        static handleError(data: any): void;
        static updateViewModel(formName: string, updatedViewModel: any, rootModelInfo: any): void;
        private static parseClientResponse(model, responseItems);
        private static nullSafeValueAssignToPath(value, path, parent);
        static syncProperties(left: any, right: any): void;
        static syncPropertiesDeep(left: any, right: any, db: any, fresh: any[]): void;
        static getScope(formName?: string): IJooveScope;
        static getModel(formName: any): IJooveScope;
        static registerPartialColumnInfo(partialName: string, controlName: string, info: any, context?: JQuery): void;
        static unRegisterPartialColumnInfo(partialName: string, controlName: string, context?: JQuery): void;
        static getPartialByName(name: string, context?: JQuery): JQuery;
        static getPartialModelValue(name: string, pathInPartial: string, $context?: JQuery): any;
        static getPartialOwnerControlElement($control: JQuery): JQuery;
        static getPartialOwnerControlElementId($control: JQuery): string;
        static getPartialOwnerControl($control: JQuery): string;
        static getPartialViewControlOriginalName($control: JQuery): string;
        static getPartialControlModelInfo($control: JQuery): any;
        static getRootModelForControl($control: JQuery, forMasterPage: boolean): any;
        static evaluateModelPath(root: any, path: string): any;
        static assignModelPath(root: Array<string>, path: string, value: any): void;
        static getControllerForElement($element: JQuery, forMasterPage?: boolean): string;
        static GetServerSideElementNameFromId(name: string, context?: JQuery): string;
        static GetServerSideElementName($element: JQuery): string;
        static GetElementNameFromId(name: string, context?: JQuery): string;
        static GetClientSideName($element: JQuery): string;
        static getElementName($element: JQuery): string;
        static applyScope($scope?: IJooveScope, immediate?: boolean): void;
        static onChange(element: HTMLElement, newValue: any, dontMakeDirty?: boolean): void;
        static elementData($element: JQuery, prop?: string, value?: string): any;
        static setBoClassPropertyFromInstance(propertyName: string, instance: any, valueToSet: any): void;
        static setBoClassProperty(className: string, propertyName: string, instance: any, valueToSet: any): void;
    }
}
