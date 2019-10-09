declare namespace Joove {
    interface IWebPageScope extends ng.IScope {
        model: any;
        trackObject: (obj: any) => number;
        actions: any;
        eventCallbacks: any;
        getRules: Function;
        dehydrate: Function;
        connectedToSignals: Function;
        events: any;
    }
    interface IJooveScope extends ng.IScope {
        actions: any;
        model: any;
        eventCallbacks: any;
        isDate: any;
        isNumber: any;
        format: any;
        dehydrate: Function;
        connectedToSignals: () => void;
        _partialModelStructure: any;
    }
    class BaseAngularProvider implements angular.IServiceProvider {
        private _defaultOptions;
        setOptions(options: any): void;
        $get(): any;
    }
    class ClmsAngular {
        static allModules: string[];
        static getUsedAngularModules(extraModules: Array<string>): Array<string>;
    }
    class LiveInputMask {
        private $element;
        private scope;
        private dt;
        private isRetartedBrowser;
        private modelChangedByUserInput;
        init($input: JQuery, scope: IJooveScope, format: ValueFormat, dt: string): void;
        private watchNumberBindingForChanges();
        private onInputChange();
        private getNumberUnformatted();
        private updateBoundValueInModel(actualNumber);
        valueIsValidNumber(): boolean;
        private beforeMask(initialValue, opts);
        private internetExplorerHack();
    }
    class ValueFormat {
        static MarkClass: string;
        live: boolean;
        decimals: number;
        private dateMode;
        private dateFormat;
        prefix: string;
        postfix: string;
        private signed;
        private showOnlyDecimalPart;
        private groups;
        private asPercentage;
        private numeralJsFormat;
        private momentJsFormat;
        private backEndFormatting;
        private excelFormatting;
        constructor(options?: {
            dateFormat?: string;
            prefix?: string;
            postfix?: string;
            decimals?: number;
            signed?: boolean;
            showOnlyDecimalPart?: boolean;
            groups?: boolean;
            live?: boolean;
            asPercentage?: boolean;
        });
        private setMomentJsFormat();
        private setNumeralJsFormat();
        getJqueryInputMaskOptions(): any;
        private formatNumber(actualNumber);
        private unformatNumber(formattedNumber);
        private formatDate(actualDate);
        private unformatDate(formattedDate);
        format(actualValue: any, forceDateMode?: boolean): string;
        unformat(formattedValue: any): any;
    }
    class NumericMask {
        private $input;
        private scope;
        private modelChangedByUserInput;
        private formatString;
        private valueFormat;
        private forceInteger;
        private numbersOnlyListenerClass;
        init($input: JQuery, scope: IJooveScope, format: ValueFormat): void;
        private watchNumberBindingForChanges();
        private onInputChange();
        private updateBoundValueInModel(actualNumber);
        private setDisplayValueToInput(actualNumber);
        private addListenerForAllowingNumbersOnly();
        private insertTextAtCursor(text);
        valueIsValidNumber(): boolean;
    }
}
