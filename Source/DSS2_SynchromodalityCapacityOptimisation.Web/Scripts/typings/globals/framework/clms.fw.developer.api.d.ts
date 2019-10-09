interface Window {
    $form: Joove.IJooveScope;
    $master: Joove.IJooveScope;
    $actions: any;
    $masterActions: any;
    $api: any;
    $domain: any;
    $updateBindings: Function;
    $refreshLogic: Function;
    $controlChanged: Function;
    $showMessage: Function;
    $closeForm: Function;
    $redirectToUrl: Function;
    $redirectToAction: Function;
    $formExtend: Function;
    $onFormLoaded: Function;
    $events: {
        on: any;
        raise: any;
    };
    $dataSets: any;
    $masterDataSets: any;
    $info: any;
    $localization: any;
}
declare namespace Joove {
    class DeveloperApi {
        static init(formScope: IJooveScope, masterScope: IJooveScope): void;
        private static exportShortcuts(formScope, masterScope);
        private static extendScope(scope);
        private static addFilterInfo(info, bag);
        private static addOrderByInfo(info, bag);
        private static addGroupByInfo(info, bag);
        private static fetchDataSource(name, forMaster, options);
        static onDatasourceRequestCompleted(controlName: string, data: any, request: any): void;
    }
    interface IDatasetArgs {
        field: string;
        dataType: string;
        orderBy: string;
        groupBy: any;
        filters: Array<{
            value: any;
            secondValue?: any;
            operator?: string;
            rowOperator?: string;
        }>;
    }
}
