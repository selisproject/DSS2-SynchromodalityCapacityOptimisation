declare namespace Joove {
    class DateTimeFormat {
        LongDatePattern(): string;
        LongTimePattern(): string;
        ShortDatePattern(): string;
        ShortTimePattern(): string;
        GeneralShortTimePattern(): string;
        GeneralLongTimePattern(): string;
    }
    class GlobalizationManager {
        private static _instance;
        private dateTimeFormat;
        static GetCurrentLocaleManager(): GlobalizationManager;
        readonly SortName: string;
        readonly SortNameLanguage: string;
        readonly DateTimeFormat: DateTimeFormat;
        private static init();
    }
}
