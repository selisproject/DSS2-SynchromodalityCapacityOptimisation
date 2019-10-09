declare namespace Joove {
    class ReferencesReconstructor {
        private _debug;
        private _uniqueTypeClassInstances;
        private _freshInstances;
        constructor(freshInstances?: any[]);
        private isInstanceOfTypeClass(object);
        private mergeObject(source, target);
        private mergeArray(source, target);
        private getCorrespondingUniqueInstance(obj);
        private mergeWithUniqueInstance(obj);
        addFreshInstance(object: any, refs?: any): void;
        addFreshArrayOfInstances(objects: Array<any>): void;
        private getCorrespondingFreshInstance(obj);
        private updateInstance(target, source);
        private _seen;
        private discriminatorProp;
        reconstructReferences(object: any): any;
        private reconstructReferencesPrive(object, parent?, propName?);
    }
}
