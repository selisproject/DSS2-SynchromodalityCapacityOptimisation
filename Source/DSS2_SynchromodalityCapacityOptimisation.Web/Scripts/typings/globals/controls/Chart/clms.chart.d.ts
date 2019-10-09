declare namespace Joove.Widgets {
    enum PieLabelType {
        none = 0,
        label = 1,
        percentage = 2,
        value = 3,
    }
    interface IChartResource extends IFilterDatasourceWidgetResource {
        Cancel: string;
        Ok: string;
        QuickFilters: string;
        PreferencesPopUpTitle: string;
        NoRecords: string;
    }
    class ChartHelper {
        constructor($element: any, $scope: any);
        private _filterWidget;
        private _quickFilterWidget;
        private _preferences;
        private _$element;
        private _resources;
        private _$scope;
        private _chart;
        private _type;
        private _datasetColumnInfo;
        private _options;
        private _data;
        private _usedColorPositions;
        private _nextColorPosition;
        private _totalDataSets;
        private _pallette;
        private _fromMasterPage;
        private static MAX_LEBEL_LENGTH;
        static instancesDic: {
            [name: string]: {
                [index: string]: ChartHelper;
            };
        };
        private minX;
        private minY;
        private maxX;
        private maxY;
        readonly FillParentSize: any;
        Init(): void;
        private enhanceOptions();
        private bubbleFitContent();
        private setColorsBasedOnTheme();
        private applyAxesColorsBasedOnTheme();
        private instantiateScales();
        private applyValueToAxes(color, path);
        private nullSafeValueAssignToPath(value, path, parent);
        InitChartTooltipMode(): void;
        InitChartPieceLabel(): void;
        InitCustomTickFormats(): void;
        ParseScaleOptions(scales: Array<any>): Array<any>;
        static GetChartName(name: string): string;
        private UpdateInstanceDisc();
        private ToRgb(hex);
        private hexToRgb(hex, opacity);
        private getChartType();
        private getOptions();
        private prepareRequest();
        private getChartData(cb);
        private getNextColor();
        private getRandomColor();
        private prepareChartData(response);
        private prepareLineChartDataSet(data, dataSetIndex);
        private prepareBarChartDataSet(data, dataSetIndex);
        private prepareRadarChartDataSet(data, dataSetIndex);
        private preparePolarChartDataSet(data, dataSetIndex);
        private preparePieChartDataSet(data, dataSetIndex);
        private prepareScatterChartDataSet(data);
        private prepareBubbleChartDataSet(data);
        private prepareDefaultDataSet(data, dataSetIndex, colorsAsArray?);
        private applyColorsToDataSet(data, set, asArray, dataSetIndex);
        private setColor(usedColors, label);
        private getColorWithLessUses(usedColors);
        private saveUsedColor(usedColors, uniqueColor, label);
        private initializeDataSet(data, dataSetIndex);
        setSelectedItem(evt: Event): void;
        private registerFilterBasePopUp($contents, widget, title, name);
        private preparePreferencesPopUp();
        private prepareQuickFilterPopUp();
        private InitChartToolbar();
        private showPreferencesPopUp(jQueryEventObject);
        private showQuickFilterPopUp(jQueryEventObject);
        private applyPrerencesPopup(jQueryEventObject, dataSourceTerms);
        private clearAllPrerencesPopup(jQueryEventObject, object);
        resizeTimeout: any;
        loadingTm: any;
        resizeCallback: any;
        redraw(data: any, tries?: number): void;
        updateChart(internal?: boolean): void;
        getDatasetColumnInfo(): Array<ColumnInfo>;
        getDownsampleOptions(): any;
        downsample(data: any, threshold: any): any;
        downsampleChart(originalData: any): any;
    }
}
