declare namespace Joove {
    enum ActionType {
        Click = 0,
        Change = 1,
        Stop = 2,
    }
    enum StateType {
        UnChanged = 0,
        Changed = 1,
    }
    interface Action {
        type?: ActionType;
        controlName?: string;
        index?: number;
        newValue?: string;
    }
    interface RecordEvent {
        element: Element;
        controlType: string;
        type: ActionType;
    }
    class AssertError extends Error {
    }
    class RecorderUtilities {
        static sanitizeState(state: any): any;
        static getControlSelectorName(el: any): string;
        static getControl(action: Action): JQuery;
        static fullPath(el: any): string;
        static getModelSnapshot(eventType: any): any;
        static getHtmlSnapshot(): any;
    }
    class Recording {
        private steps;
        private stepId;
        private currentState;
        private delay;
        private fns;
        name: string;
        constructor(steps?: Array<any>);
        play(): Promise<{}>;
        sleep(): Promise<{}>;
        step(): Promise<{}>;
        forward(): Promise<{}>;
        loadCurrentState(): void;
        finished(): boolean;
        assertCurrentState(): Promise<{}>;
        isAction(step: any): boolean;
        getCurrentStep(): any;
        getCurrentState(): any;
        getNextStep(): any;
        register(f: Function): void;
        notify(): void;
        numSteps(): number;
    }
    class Recorder {
        private currentState;
        private beforeOnChangeState;
        private states;
        private isRecording;
        constructor();
        listen(recordEvent: RecordEvent): void;
        getRecording(): Recording;
        start(): void;
        pause(): void;
        stop(): void;
        addState(event?: any): void;
        parseRecordEvent(event: RecordEvent): Action;
        parseEvent(event: any): Action;
        setIndex(action: Action, element: JQuery): Action;
        saveModelSnapshot(isListen?: boolean): void;
        getSnapshot(currentState: any, isListen?: boolean): any;
        getCurrentSnapshot(): any;
        isLastItemSnapshot(): any;
        getLastItem(): any;
        download(): void;
        private initListenner();
        private initClickListener(controlType);
        private getInfo();
    }
}
