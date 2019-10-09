declare namespace Joove.Widgets {
    class RecorderPanel {
        recording: Recording;
        cnxt: JQuery;
        panel: string;
        constructor();
        init: () => void;
        load: (e: any) => void;
        nextStep: (stepId: any) => void;
        play: () => void;
        save: () => void;
        start: () => void;
        stop: () => void;
        setMsg: (msg: string, status?: string) => void;
        setStatus: (status?: string) => void;
    }
}
