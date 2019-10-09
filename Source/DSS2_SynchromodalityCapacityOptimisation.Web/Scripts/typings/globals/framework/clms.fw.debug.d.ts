declare namespace CLMS.Framework.Utilities {
    enum DebugMessageType {
        Debug = 0,
        Info = 1,
        Warning = 2,
        Error = 3,
        IDEF0Trace = 4,
    }
    enum LoggerLevel {
        ALL = 0,
        DEBUG = 1,
        INFO = 2,
        WARN = 3,
        ERROR = 4,
        FATAL = 5,
        OFF = 6,
    }
    class Logger {
        private _Name;
        private _Level;
        constructor(_Name: string, _Level?: LoggerLevel);
        readonly IsDebugEnabled: boolean;
        readonly IsInfoEnabled: boolean;
        readonly IsWarnEnabled: boolean;
        readonly IsErrorEnabled: boolean;
        readonly IsFatalEnabled: boolean;
        private readonly Name;
        Debug(message: Array<any>, exception?: any): void;
        Info(message: Array<any>, exception?: any): void;
        Warn(message: Array<any>, exception?: any): void;
        Error(message: Array<any>, exception?: any): void;
        Fatal(message: Array<any>, exception?: any): void;
    }
    class DebugHelper {
        private static _instance;
        static Instance(): Logger;
        static Log(messageType: DebugMessageType, message: any, showInDebugConsole?: boolean): void;
    }
}
