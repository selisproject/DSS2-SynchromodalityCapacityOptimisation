/// <reference types="jquery" />
/// <reference types="angular" />
interface Date {
    addDays: (days: number) => Date;
    parseDate: (input: any, format: any) => Date;
    dateFormat: (format: any) => string;
}
interface Number {
    toString(format?: string): string;
}
interface Array<T> {
    add(item: T): any;
    clear(): any;
    remove(item: T): any;
    contains(item: T): boolean;
    addRange(entries: any): void;
    linq: any;
    insert(pos: number, item: T): any;
    toArray(): Array<T>;
    addManyNew(times: number, valueGetter: () => T): Array<T>;
}
declare const NULL: any;
declare namespace CLMS.Framework {
    var DomainModel: any;
    namespace Timespan {
        function Parse(value: string): System.Time.TimeSpan;
    }
    namespace DateTime {
        function ToString(value: any, format?: string, locale?: {
            Code: string;
        }): string;
        function ParseExact(value: string, locale?: string, formats?: string | Array<string>): any;
        function Compare(left: Date, right: Date): number;
    }
    namespace Boolean {
        function Parse(value: string): boolean;
    }
    namespace Integer {
        function Parse(value: any): number;
    }
    namespace Long {
        function Parse(value: any): number;
    }
    namespace Float {
        function Parse(value: any): number;
    }
    namespace Decimal {
        function Parse(value: any): number;
    }
    namespace Double {
        function Parse(value: any): number;
    }
    namespace String {
        const Empty = "";
        function Compare(left: string, right: string, ignoreCase?: boolean): number;
        function Join(sep: string, values: Array<string>): string;
        function IsSingular(value: string): boolean;
        function IsPlural(value: string): boolean;
        function Singularize(value: string): string;
        function Pluralize(value: string): string;
        function Format(format: string, ...args: Array<any>): string;
        function Concat(values: Array<String> | String, right?: String): String;
        function SplitCamelCase(input: string, pattern: RegExp, replacement: string): String;
        function IsNullOrEmpty(value: string): boolean;
        function FillWith(value: string, rep: number): string;
    }
    namespace Utilities {
        function FocusOnFirstInputElementOfModal(): void;
        function ExecuteRequest(req: any, args: Array<any>, cb: Function, err: Function): void;
        function ThrowException(name: string): any;
        function OpenWindow(url: string, target?: string, showWarningIfBlocked?: boolean): void;
        function GetURIParameterValue(parameter: string): string;
        function SizeOf(object: any): number;
        class ValidationException extends System.Exceptions.NotImplementedException {
        }
        class MambaRuntimeType {
        }
        class Path {
            static GetServerPhysicalPath: (path: string) => string;
            static GetDataPath: (path: string) => string;
            static GetUploadsPath: (path: string) => string;
            static ResolveClientURL: (path: string) => string;
            static GetAttatchmentLink: (path: string) => string;
            static GetAttatchmentPath: (path: string) => string;
        }
        class Email {
            static SendMail(subject: EMailMessage | string, body?: boolean | string, to?: string, cc?: string, bcc?: string, fromAddress?: string, attachments?: any, sendAsync?: boolean): void;
        }
        class Serializer<T> {
            ToJson(instance: T): string;
            FromJson(data: string): T;
            ToXml(instance: T, tab?: string): string;
            FromXml(data: string): T;
            ParseEnum(data: string): T;
        }
        class EMailMessage {
            constructor();
            From: string;
            Subject: string;
            Body: string;
            IsBodyHtml: boolean;
            To: string[];
            CC: string[];
            Bcc: string[];
        }
        class DataAccessContext<T> {
            Filter: any;
            SortByColumnName: any;
            PageIndex: number;
            PageSize: number;
        }
        class PagedResults<T> {
            Results: System.Collections.List<T>;
            TotalResults: number;
        }
        class Common {
            static ConvertToDateTime(str: string, throwException?: boolean): Date;
            static ConvertToInt(str: string, throwException?: boolean): number;
            static ConvertToDouble(str: string, throwException?: boolean): number;
            static ConvertToGuid(str: string, throwException?: boolean): System.Guid;
            static ConvertToDecimal(str: string, throwException?: boolean): number;
            static ConvertToLong(str: string, throwException?: boolean): number;
            static Base64Decode(base64EncodedData: string): string;
            static Base64Encode(base64EncodedData: string): string;
            static GetMD5Hash(data: string): string;
            static IsTypePrimitiveOrSimple(data: any): boolean;
            static IsTypeCollection(data: any): boolean;
            static IsPropertyPrimitiveOrSimple(data: any): boolean;
            static IsPropertyCollection(data: any): boolean;
        }
    }
    namespace Data {
        interface ISession {
        }
        class DataManager {
            static IsPropertyDirty(obj: any, property: string): boolean;
        }
        class MiniSessionManager {
            InstanceId: System.Guid;
            SingleUseSession: boolean;
            WillFlush: boolean;
            Session: ISession;
            LastAction: any;
            static Instance: MiniSessionManager;
            OpenSession(): any;
            OpenSessionWithTransaction(): any;
            BeginTransaction(): any;
            CommitChanges(exception?: any): void;
            Dispose(): void;
            ExecuteInTransaction<T>(func: System.Action<T> | System.Func<T>): void | T;
        }
    }
    namespace Number {
        function Equal(left: () => number, right: () => number): boolean;
        function NotEqual(left: () => number, right: () => number): boolean;
        function LessThan(left: () => number, right: () => number): boolean;
        function GreaterThan(left: () => number, right: () => number): boolean;
        function LessThanOrEqual(left: () => number, right: () => number): boolean;
        function GreaterThanOrEqual(left: () => number, right: () => number): boolean;
    }
}
declare namespace Joove {
    enum Placement {
        TOP = 0,
        TOP_RIGHT = 1,
        TOP_LEFT = 2,
        RIGHT = 3,
        LEFT = 4,
        BOTTOM_RIGHT = 5,
        BOTTOM_LEFT = 6,
        BOTTOM = 7,
    }
    enum MambaDataType {
        COLLECTION = 0,
        DICTIONARY = 1,
        FUNC = 2,
        COLLECTIONBASE = 3,
        STRING = 4,
        BOOL = 5,
        INT = 6,
        DOUBLE = 7,
        DECIMAL = 8,
        FLOAT = 9,
        LONG = 10,
        DATETIME = 11,
        CHAR = 12,
        GUID = 13,
        BYTE = 14,
        OBJECT = 15,
        RUNTIMETYPE = 16,
        RUNTIMEPROPERTY = 17,
        EXCEPTION = 18,
        TIMESPAN = 19,
        BUSINESSEXCEPTION = 20,
        NUMBER = 21,
    }
    class Logger {
        static info(...args: any[]): void;
        static debug(...args: any[]): void;
        static error(...args: any[]): void;
    }
    class Comparator {
        static DeepEqual(left: any, right: any, skipProperty?: Function): boolean;
        static IsEqual(left: any, right: any, type: string): boolean;
    }
    class Common {
        static safeDeepPropertySet(obj: any, key: Array<string> | string, val: any): void;
        static safeDeepPropertyAccess(obj: any, key: string, def?: any): any;
        static project(model: any, schema: any, indexes?: Array<number>, iteration?: number, ifEmptyFetchAll?: boolean): any;
        static isEmptyObject(obj: any): boolean;
        static dateDiff(date1: Date, date2: Date): System.Time.TimeSpan;
        static stringContains(str: string, otherStr: string, caseInsensitive?: boolean): boolean;
        static stringIsNullOrEmpty(str: string): boolean;
        static stringEndsWith(str: string, suffix: string): boolean;
        static decimalAdjust(type: any, value: number, exp?: number): number;
        static round(value: number, decimals: number): number;
        static ceil(value: number, decimals: number): number;
        static floor(value: number, decimals: number): number;
        static sign(x: any): number;
        static createDate(year: number, month: number, day: number, hours?: number, minutes?: number, seconds?: number): Date;
        static createEvent(eventName: string): any;
        static isVisibleOnViewPort(element: JQuery): Placement;
        static toggleDebugMode(enable: boolean): void;
        static isInDebugMode(): boolean;
        static getMatch(verbalExpression: RegExp, input: string, defaultValue?: string): string;
        static getMatches(verbalExpression: RegExp, input: string, defaultValues?: Array<string>): Array<string>;
        static isValidEmail(str: string): boolean;
        static isValidUrl(str: any): boolean;
        static modelToJson(input: string): JSON;
        static cloneObject(originalObject: any): any;
        static valueIsObject(value: any): boolean;
        static valueIsPrimitive(value: any): boolean;
        static setKeyAsClientKey(obj: any): void;
        static objectsAreEqual(objA: any, objB: any, typeCheck?: boolean): boolean;
        static objectsAreEqualGenericDeepComparison: (a: any, b: any) => any;
        static keyHasDefaultValue: (key: any) => boolean;
        static changeDateTimeFormat: (formatString: string) => string;
        static classInstancesAreSame: (objectA: any, objectB: any) => boolean;
        static getClassInstanceKey(instance: any): string;
        static classInstancesAreNotSame: (objectA: any, objectB: any) => boolean;
        static collectionsAreEqual(collectionA: Array<any>, collectionB: Array<any>): boolean;
        static updateInstanceReferencesAccrossModel(obj: any): void;
        static updateManyInstanceReferencesAccrossModel(obj: Array<any>): void;
        static replaceAll(value: string, search: string, replacement: string): string;
        static getDirectiveScope($element: JQuery): any;
        static setDirectiveScope($element: JQuery, directiveScope: any): any;
        static directiveScopeIsReady($element: JQuery): boolean;
        static markDirectiveScopeAsReady($element: JQuery): JQuery;
        static markDirectiveScopeAsNotReady($element: JQuery): JQuery;
        static parentGridsAreReady($element: JQuery): boolean;
        static getContextFromElement($element: JQuery): Array<any>;
        static getRepeatersOfElement($element: JQuery): any;
        static getFullBindingPathOfControl($element: JQuery, relativePathStr: string): string;
        static fixBindingPath(parents: Object, pathStr: string): string;
        static getAction(actionName: string, masterPage?: boolean): Function;
        static executeAction(actionName: string, ...args: any[]): void;
        static executeEventCallback(name: string, ...args: any[]): void;
        static getScope(): IJooveScope;
        static getModel(): any;
        static getMasterScope(): IJooveScope;
        static getMasterModel(): any;
        static serializeIndexes(indexes: Array<string>): string;
        static getContextItemElement($el: any): JQuery;
        static getIndexesOfControl($control: JQuery): any;
        static getContextOfControl($control: JQuery): any;
        static getIndexKeyOfControl($control: JQuery): string;
        static toHTML(value: string): string;
        static formatNumber(value: number, format: string): string;
        static formatDate(value: Date, format: string): string;
        static getUtcDateFromRawString(rawValue: string, fullFormat: string, setToMidday?: boolean): Date;
        static getDateStringFromUtc(value: Date, fullFormat: string): string;
        static trackObject(obj: any): number;
        static eventPreventsDefaultFormAction(e: JQueryEventObject): boolean;
        static setControlKeyPressed(e: JQueryEventObject, duration: number): void;
        static controlKeyWasPressed(): boolean;
        static setLastClickedElement(e: JQueryEventObject): void;
        static getLastClickedElement(): Element;
        static detectBrowser(): string;
        static getScrollbarSize(): number;
        static toJson(data: string): JSON;
        static forceNumberFormat(number: string): string;
        static parseFloat(number: string): number;
        static convertToNumber(value: string): number;
        static convertToBoolean(value: string): boolean;
        static convertToDateTime(value: string): Date;
        static guessStringMambaDataType(value: string): MambaDataType;
        static getMambaDataType(type: string): MambaDataType;
        static parseToDecimal(value: any, seperators: Array<string>): {
            integerPart: string;
            fractionPart: string;
        };
        static localizeNumber(value: any, seperators?: Array<string>): string;
        static delocalizeNumber(value: any, seperators?: Array<string>): string;
        static getCurrenctNumberSeperator(): Array<string>;
        static parseToNumber(value: any, seperators?: Array<string>, enforceGroupSize?: boolean): number;
        static autoParse(value: string): any;
        static setNumberLocalizationSettings(): void;
        static isArray(instance: any): boolean;
        static safeNumber(num: any): number;
        static nullSafe<T>(expr: () => T, deffaultValue: T): T;
        static autocompleteFix(): void;
        static createRandomId(length?: number): string;
        static digestScope(scope?: ng.IScope): void;
        static requireScript(id: any, src: any, callback?: any): Promise<boolean>;
        static usePDFMaker(options: {
            filename: string;
            dd: any;
            tableLayouts?: any;
        }): void;
        static loadPdfMakeDependencies(options: {
            filename: string;
        }): Promise<boolean>;
        static loadJsPdfDependencies(options: {
            filename: string;
            $element?: JQuery;
            usePrintMedia?: boolean;
        }): void;
        static exportToPdfUsePrintMedia(target: JQuery, options: {
            filename: string;
            $element?: JQuery;
            usePrintMedia?: boolean;
        }): void;
        static exportToPdf(options: {
            filename: string;
            $element?: JQuery;
            usePrintMedia?: boolean;
        }): void;
        static cast(instance: any, type: any): any;
    }
    interface IElementViewPortObserverOptions {
        $element: JQuery;
        interval: number;
        stopWhenEnters?: boolean;
        stopWhenExits?: boolean;
        onEnter?: Function;
        onExit?: Function;
        distanceThreshold?: number;
        visibilityCheck?: boolean;
    }
    class ElementViewPortObserver {
        private $el;
        private el;
        private interval;
        private onEnterView;
        private onExitView;
        private intervalObject;
        private stopOnEnter;
        private stopOnExit;
        private visibilityCheck;
        private distanceThreshold;
        constructor(opts: IElementViewPortObserverOptions);
        start(): void;
        stop(): void;
        private onLoop();
        private isInViewPort();
    }
    class LazyImageLoader {
        private observer;
        private $img;
        private checkVisibility;
        constructor($img: JQuery, checkVisibility: boolean);
        private setImage();
    }
}
