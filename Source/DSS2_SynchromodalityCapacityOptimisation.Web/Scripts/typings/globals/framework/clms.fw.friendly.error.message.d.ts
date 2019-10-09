declare namespace Joove {
    class FriendlyMessageDTO {
        Title: string;
        OriginalStackTrace?: string;
        OriginalExceptionMessage: string;
        ExceptionType?: string;
        Entries?: Array<FriendlyMessageEntryDTO>;
    }
    class FriendlyMessage {
        constructor(dto: FriendlyMessageDTO);
        dto: FriendlyMessageDTO;
    }
    class FriendlyMessageEntryDTO {
        AppdevIdentifier: string;
        AppdevSemantic: string;
        icon: string;
        friendlyMessage: string;
        static enchance(dto: FriendlyMessageEntryDTO): void;
    }
    class SemanticCollection {
        FriendlyMessage: string;
        Icon: string;
        constructor(msg: string, icon?: string);
    }
    enum AppDevSemantic {
        None = 0,
        CalculatedExpression = 1,
        CondionalFormating = 2,
        ControllerAction = 3,
        Form = 4,
        Logic = 5,
        ControllerActionEntry = 6,
        ControllerActionImplementation = 7,
        Datasource = 8,
        DataSourceDataBinding = 9,
        DataSourceGetFullRecordset = 10,
        DataSourceEntryPoint = 11,
        DataSourceFilter = 12,
        DataSourceGroupBy = 13,
        DataSourceDataAccess = 14,
        DataSourceGrid = 15,
        DataSourceGridEntry = 16,
        DataSourceAggregators = 17,
        DataValidation = 18,
        DataValidationCondition = 19,
        DataValidationMesage = 20,
        ConditionalFormatting = 21,
        ConditionalFormattingEvaluation = 22,
        ControlOnChangeAction = 23,
        ControllerEntryPoint = 24,
        CalculatedExpressionValueMethod = 25,
    }
    class FriendlyMessageGenerator {
        static SemanticsDictionary: {
            [index: string]: SemanticCollection;
        };
        static initDict(): void;
        static isHandledError(errorType: string): boolean;
        private static getMessageStringForAjaxError(errorType, errorAs);
        static getAjaxErrorMessage(errorType: string): string;
        private static getMessageObject(data);
        static showPopUp(msg: FriendlyMessage, errorPageURL?: string): void;
        private static errorIsHtml(serializedError);
        private static displayHtmlError(serializedError, fullscreeen);
        static handleMessage(serializedError: any): void;
    }
}
