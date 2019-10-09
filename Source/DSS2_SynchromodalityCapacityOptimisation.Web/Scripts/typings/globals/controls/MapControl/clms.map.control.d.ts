/// <reference types="googlemaps" />
declare namespace Joove.Widgets {
    enum MapEvents {
        BoundsChanged,
        CenterChanged,
        Click,
        DoubleClick,
        RightClick,
        Drag,
        DragStart,
        DragEnd,
        HeadingChanged,
        Idle,
        MapTypeIdChanged,
        MouseMove,
        MouseOut,
        MouseOver,
        ProjectionChanged,
        Resize,
        TilesLoaded,
        TiltChanged,
        ZoomChanged,
    }
    enum MapDataLayerEvents {
        AddFeature,
        Click,
        DoubleClick,
        MouseDown,
        MouseOut,
        MouseOver,
        MouseUp,
        RemoveFeature,
        RemoveProperty,
        RightClick,
        SetGeometry,
        SetProperty,
    }
    class MapControlStyle {
        name: string;
        style: google.maps.MapTypeStyle[];
        isType: boolean;
        isSelected: boolean;
        isDefault: boolean;
        readonly key: string;
        constructor(name: string, style: google.maps.MapTypeStyle[], isType: boolean, isDefault: boolean);
    }
    class MapControl {
        private map;
        private directionsService;
        private directionsRenderer;
        private $element;
        private options;
        private symbols;
        private autoBoundInProgress;
        private isInitialized;
        private unregisteredMapEvents;
        private unregisteredMapDataLayerEvents;
        private _storedData;
        private _storedDirections;
        private _fromMasterPage;
        static instancesDic: {
            [name: string]: MapControl;
        };
        mapFeatures: google.maps.Data.Feature[];
        mapDataLayerEventListeners: Dictionary<google.maps.MapsEventListener>;
        mapDataLayerEventFunctions: Dictionary<Function>;
        mapEventListeners: Dictionary<google.maps.MapsEventListener>;
        mapEventFunctions: Dictionary<Function>;
        customStyles: Array<MapControlStyle>;
        readonly customTypeKeys: string[];
        readonly defaultStyle: google.maps.MapTypeStyle[];
        constructor(element: JQuery, options: any);
        init(): void;
        setZoom(zoomLevel: number): void;
        getFeatureBounds(): google.maps.LatLngBounds;
        showRelatedPartialView(lat: number, lng: number): void;
        prepareRequest(): DatasourceRequest;
        getData(fitToContent?: boolean, tryNum?: number): void;
        applyStyle(): void;
        displayDirections(from: string | google.maps.LatLng | google.maps.Place, to: string | google.maps.LatLng | google.maps.Place, travelMode: google.maps.TravelMode): void;
        clearData(features: Array<google.maps.Data.Feature>): void;
        clearDirections(): void;
        refreshData(): void;
        refreshDirections(): void;
        addMapEvent(eventType: MapEvents, name: string, callback: Function): void;
        addMapDataLayerEvent(eventType: MapDataLayerEvents, name: string, callback: Function): void;
        highlightLinesOnHover(): void;
        hidePartialViewOnMapChange(): void;
        fitToContent(): void;
    }
    interface IDictionary<T> {
        add(key: string, value: T): any;
        containsKey(key: string): boolean;
        count(): number;
        item(key: string): T;
        keys(): string[];
        remove(key: string): T;
        values(): T[];
    }
    class Dictionary<T> implements IDictionary<T> {
        private _items;
        private _count;
        containsKey(key: string): boolean;
        count(): number;
        add(key: string, value: T): void;
        remove(key: string): T;
        item(key: string): T;
        keys(): string[];
        values(): T[];
    }
}
