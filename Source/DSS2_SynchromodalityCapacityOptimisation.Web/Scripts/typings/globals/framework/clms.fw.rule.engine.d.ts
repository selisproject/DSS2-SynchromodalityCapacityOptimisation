declare namespace Joove {
    enum DataValidationMessageType {
        INFO = 1,
        WARN = 2,
        ERROR = 3,
        SUCCESS = 4,
        CUSTOM = 5,
    }
    var RuleTypes: {
        ConditionalFormatting: string;
        DataValidation: string;
        CalculatedExpression: string;
    };
    enum EvaluationTimes {
        OnLoad = 1,
        OnChange = 2,
        OnSubmit = 3,
    }
    class DataSetRuleEvaluationResult {
        ApplyToColumn: boolean;
        ApplyToRow: boolean;
        ColumnNames: Array<string>;
        Expression: any;
        Indexes: Array<number>;
        Key: any;
        RuleName: string;
        Status: boolean;
        readonly EvaluationScope: IEvaluationScope;
    }
    interface IJbRule {
    }
    interface IEvaluationScope {
        Status: Promise<boolean>;
        Expression: Promise<string>;
    }
    interface IJbRuleOptions {
        name?: string;
        type?: string;
        partialView?: string;
        getContext?: Function;
        evaluationTimes?: Array<Joove.EvaluationTimes>;
        group?: string;
        contextControlName?: string;
        dataValidationMessageType?: DataValidationMessageType;
        evaluatedAtServer?: boolean;
        condition?: (_parents: any) => any;
        expression?: (_parents: any) => any;
        isDataSetRule?: boolean;
        originalName?: string;
        evaluateInContext?: Function;
        fromMasterPage?: boolean;
        isRelatedToDataValidation?: boolean;
    }
    interface IRuleInfo {
        Name: string;
        Type: string;
        Indexes: Array<string>;
        PartialViewControls: Array<string>;
    }
    interface IServerRulesInfo {
        info: Array<IRuleInfo>;
        controls: any;
    }
    class JbRule {
        name: string;
        type: string;
        partialView: string;
        getContext: Function;
        evaluationTimes: Array<EvaluationTimes>;
        evaluatedAtServer: boolean;
        serverSideEvaluations: any;
        runsAtServer: boolean;
        isDataSetRule: boolean;
        group: string;
        contextControlName: string;
        condition: (_parents: any) => Promise<any>;
        expression: (_parents: any) => Promise<any>;
        evaluatedCondition: boolean;
        dataValidationMessageType: DataValidationMessageType;
        originalName?: string;
        fromMasterPage?: boolean;
        evaluateInContext?: Function;
        isRelatedToDataValidation?: boolean;
        constructor(options: IJbRuleOptions);
        init(options: IJbRuleOptions): void;
        assureIsPromise<T>(expression: (parents: any) => any): (parents: any) => Promise<T>;
        getRuleAttribute(): string;
        $affectedControls(): JQuery;
        findServerSideEvaluations(): void;
        static createRulesForPartialControls(controls: Array<string>, createRule: (name: string) => Array<JbRule>): Array<JbRule>;
    }
    class RuleEngine {
        onLoadHasRun: boolean;
        conditionalFormattings: Array<JbRule>;
        dataValidations: Array<JbRule>;
        calculatedExpressions: Array<JbRule>;
        serverRules: Array<JbRule>;
        dataSetRules: Array<JbRule>;
        cfHelper: ConditionalFormattingsHelper;
        latestServerRulesResults: any;
        customRegisteredFunctions: Array<any>;
        private _lastOnSubmitDatavalidation;
        addServerRules(rules: Array<JbRule>): void;
        addDataSetRules(rules: Array<JbRule>): void;
        addConditionalFormattings(rules: Array<JbRule>): void;
        addDataValidations(rules: Array<JbRule>): void;
        addCalculatedExpressions(rules: Array<JbRule>): void;
        prepareRuleInfoForServerSideExecution(rules: Array<JbRule>): IServerRulesInfo;
        prepareRuleInfoForPartialViews(controls: JQuery, info: any, controlsOfEachRuleCombination: any, rule: any, key: any): void;
        prepareRuleInfoForControlInsideContext(control: JQuery, info: any, controlsOfEachRuleCombination: any, cache: any, currentKey: string): void;
        getRule(name: string, type: string, rules?: any): JbRule;
        getServerRulesInfo(evalTime: EvaluationTimes): IServerRulesInfo;
        ruleMustBeEvaluatedAtEvaluationTime(rule: JbRule, evalTime: EvaluationTimes): boolean;
        evaluatesServerRules(rulesToEvaluate: any, evalTime: EvaluationTimes, groups: string[], cb?: any): void;
        updateRulesOfControl($element: JQuery): void;
        updateSpecificRulesOfControl($element: JQuery, ruleResults: any, type: string): void;
        applyServerRulesResult(results: any, rulesInfo: any): void;
        applyServerRules(rules: any, type: any, rulesInfo: any): Promise<boolean>;
        applyDataSetRulesResult(results: Array<DataSetRuleEvaluationResult>): void;
        private static lastChangeRequest;
        private isRunning;
        update(evaluationTime: EvaluationTimes, groups?: string[], done?: Function): Promise<void>;
        actualUpdate(evaluationTime: EvaluationTimes, groups?: string[], done?: Function): Promise<void>;
        addCustomFunction(name: string, func: Function): void;
        removeCustomFunction(name: string): void;
        runClientDataValidations(groups: string[]): Promise<boolean>;
        updateDataValidationRelatedConditionals(): void;
        updateSingleRule(name: string, type: string, evaluationTime: EvaluationTimes, groups: string[]): void;
        evaluateConditionalFormattings(evaluationTime: EvaluationTimes): Promise<boolean>;
        evaluateCalculatedExpressions(evaluationTime: EvaluationTimes): Promise<boolean>;
        evaluateDataValidations(evaluationTime: EvaluationTimes, groups: string[]): Promise<boolean>;
        evaluateRules(evaluationTime: EvaluationTimes, groups: string[]): Promise<void>;
        evaluateRule(rule: JbRule, groups: string[], evaluationTime: EvaluationTimes): Promise<boolean>;
        getRuleParents(rule: JbRule, indexes: Array<number>): Array<any>;
        applyRule(rule: JbRule, evaluation: IEvaluationScope, $controls: JQuery, indexes: Array<number>): Promise<boolean>;
        applyCondionalFormatting(rule: JbRule, evaluation: IEvaluationScope, $controls: JQuery): void;
        applyConditionalFormattingOnControl($control: JQuery, status: boolean, toDoList: Array<string>): void;
        parseConditionalFormattingToDoString(toDoString: string): {
            type: string;
            extraData: string;
        };
        applyDataValidation(rule: JbRule, evaluation: IEvaluationScope, indexes: Array<number>): void;
        applyCalculatedExpression(rule: JbRule, evaluation: IEvaluationScope, $controls: JQuery): void;
        applyCalculatedExpressionOnControl($control: JQuery, expression: string, evaluatedOnClient: boolean): void;
        applyCalculatedExpressionToBinding($control: JQuery, binding: any, expression: string): void;
    }
}
