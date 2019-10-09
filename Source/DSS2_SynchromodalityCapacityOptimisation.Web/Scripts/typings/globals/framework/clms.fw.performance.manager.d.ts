declare namespace Joove {
    class PerformanceManager {
        private _enabled;
        private _watches;
        constructor(enabled: boolean);
        start(controller: string, action?: string, information?: string): void;
        stop(controller: string, action?: string, information?: string): void;
        waitAndSend(milliseconds?: number): void;
        send(): void;
    }
}
