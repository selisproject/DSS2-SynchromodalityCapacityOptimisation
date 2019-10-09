declare namespace Joove.Widgets {
    class DebugConsole {
        $modal: any;
        saveStatus: boolean;
        iFrameController: string;
        debugConsoleID: string;
        private consoleDrawn;
        constructor(debugConsoleID: string, iFrameController: string, saveStatus?: boolean);
        drawDebugConsole(): void;
        initDebugConsole(): void;
        restoreDebugConsole(): void;
        minmaxModal(calledByButton?: boolean, doMinimize?: any): void;
    }
}
