declare namespace Joove.Widgets {
    interface IJooveCalendarScope extends IJooveScope {
        selectedItems: Array<any>;
        _helper: CalendarHelper;
    }
    class CalendarHelper {
        private $element;
        private cacheClearInterval;
        private refreshTimeout;
        private dateField;
        private endDateField;
        private captionField;
        private columnsInfo;
        private scope;
        private cache;
        private options;
        constructor($el: JQuery, scope: IJooveCalendarScope);
        private parseOptions();
        private parseViewToFullCalendarString(view);
        private resolveLocale();
        private init();
        private startClearCacheInterval();
        private createRangeKey(range);
        clearCache(): void;
        private getCachedData(range);
        private addToCache(data, range);
        private addEventIcon($eventElement);
        private onEventClick(calEvent, jsEvent, view);
        refresh(): void;
        private getCalendarVisibleRange();
        private setCalendarData(data, range);
        private initListeners();
        private prepareRequest(range);
        createEventsArray(data: Array<any>): Array<any>;
        private walkDataPath(data, path);
        fetchData(cb?: Function): void;
        private getColumnInfoByName(name);
    }
}
