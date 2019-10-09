declare namespace Joove.Widgets {
    interface IValidationUiScope extends IJooveScope {
        _showDvPanel: boolean;
        _dvSummaryVisible: boolean;
        show: () => void;
        hide: () => void;
        headingSigular: string;
        headingPlural: string;
    }
    class ValidationPanelAngular {
        init(rootElementSelector: string): void;
    }
}
