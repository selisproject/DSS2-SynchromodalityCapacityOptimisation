declare namespace Joove {
    class Cycles {
        static referencesMap: {};
        static nextUniqueId: () => number;
        static reconstructObject(object: any): any;
        static mapObjectReferences(object: any): any;
        static checkForDuplicateIds(object: any): any;
        static restoreObjectReferences(object: any): any;
        static decycleObject(object: any, refs?: any): any;
    }
}
