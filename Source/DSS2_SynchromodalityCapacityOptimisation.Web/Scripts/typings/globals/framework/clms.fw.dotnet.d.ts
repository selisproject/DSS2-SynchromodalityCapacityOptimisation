declare namespace System {
    import ILinqEnumerable = System.Linq.ILinqEnumerable;
    const EMPTY = "";
    class TypeInfo {
        protected readonly target: any;
        readonly type: string;
        readonly isBoolean: boolean;
        readonly isNumber: boolean;
        readonly isFinite: boolean;
        readonly isValidNumber: boolean;
        readonly isString: boolean;
        readonly isTrueNaN: boolean;
        readonly isObject: boolean;
        readonly isArray: boolean;
        readonly isFunction: boolean;
        readonly isUndefined: boolean;
        readonly isNull: boolean;
        readonly isNullOrUndefined: boolean;
        readonly isPrimitive: boolean;
        readonly isSymbol: boolean;
        constructor(target: any, onBeforeFreeze?: (instance: any) => void);
        member(name: string | number | symbol): TypeInfo;
        static getFor(target: any): TypeInfo;
        is<T>(type: {
            new (...params: any[]): T;
        }): boolean;
        as<T>(type: {
            new (...params: any[]): T;
        }): T | null;
    }
    function Type(target: any): TypeInfo;
    module Type {
        const BOOLEAN: TypeValue.Boolean;
        const NUMBER: TypeValue.Number;
        const STRING: TypeValue.String;
        const OBJECT: TypeValue.Object;
        const SYMBOL: TypeValue.Symbol;
        const UNDEFINED: TypeValue.Undefined;
        const FUNCTION: TypeValue.Function;
        function is<T>(target: Object, type: {
            new (...params: any[]): T;
        }): target is T;
        function as<T>(target: Object, type: {
            new (...params: any[]): T;
        }): T | null;
        function isNullOrUndefined(value: any): value is null | undefined;
        function isBoolean(value: any): value is boolean;
        function isNumber(value: any, ignoreNaN?: boolean): value is number;
        function isTrueNaN(value: any): value is number;
        function isString(value: any): value is string;
        function isPrimitive(value: any, allowUndefined?: boolean): value is Primitive;
        function isPrimitiveOrSymbol(value: any, allowUndefined?: boolean): value is Primitive | symbol;
        function isPropertyKey(value: any): value is string | number | symbol;
        function isFunction(value: any): value is Function;
        function isObject(value: any, allowNull?: boolean): boolean;
        function numberOrNaN(value: any): number;
        function of(target: any): TypeInfo;
        function hasMember(instance: any, property: string, ignoreUndefined?: boolean): boolean;
        function hasMemberOfType<T>(instance: any, property: string, type: TypeValue.Any): instance is T;
        function hasMethod<T>(instance: any, property: string): instance is T;
        function isArrayLike<T>(instance: any): instance is Collections.ArrayLikeWritable<T>;
    }
    function getHashCode(source: string): number;
    function repeat(source: string, count: number): string;
    function fromChars(ch: number, count: number): string;
    function fromChars(chars: number[]): string;
    function escapeRegExp(source: string): string;
    function trim(source: string, chars?: string | string[], ignoreCase?: boolean): string;
    function format(source: string, ...args: any[]): string;
    function supplant(source: string, params: {
        [key: string]: any;
    } | any[]): string;
    function startsWith(source: string, pattern: string): boolean;
    function endsWith(source: string, pattern: string): boolean;
    function split(source: string, delimiter?: any, removeEmpty?: boolean): Array<string>;
    class Exception implements Error, Disposable.IDisposable {
        readonly message: string;
        readonly name: string;
        readonly stack: string;
        readonly data: IMap<any>;
        constructor(message: string, innerException?: Error, beforeSealing?: (ex: any) => void);
        protected getName(): string;
        toString(): string;
        protected toStringWithoutBrackets(): string;
        dispose(): void;
    }
    class Guid {
        private static _validator;
        private value;
        static EMPTY: string;
        private static gen(count);
        constructor(guid: string | Guid);
        Equals: (other: Guid) => boolean;
        IsEmpty: () => boolean;
        ToString: () => any;
        toString: () => any;
        ToJSON: () => any;
        static IsGuid(value: any): boolean;
        static NewGuid(): Guid;
        static Parse(guid: string): Guid;
        static Raw(): string;
    }
    type Comparable = Primitive | IComparable<any>;
    const enum CompareResult {
        Equal = 0,
        Greater = 1,
        Less = -1,
    }
    interface IComparer<T> {
        compare(a: T, b: T): number;
    }
    interface IComparable<T> {
        compareTo(other: T): number;
    }
    interface IEquatable<T> {
        equals(other: T): boolean;
    }
    interface Error {
        name: string;
        message: string;
    }
    interface IMap<TValue> {
        [key: string]: TValue;
    }
    interface Selector<TSource, TResult> {
        (source: TSource): TResult;
    }
    interface SelectorWithIndex<TSource, TResult> {
        (source: TSource, index: number): TResult;
    }
    interface Action<T> extends Selector<T, void> {
    }
    interface ActionWithIndex<T> extends SelectorWithIndex<T, void> {
    }
    interface Predicate<T> extends Selector<T, boolean> {
    }
    interface PredicateWithIndex<T> extends SelectorWithIndex<T, boolean> {
    }
    interface Comparison<T> {
        (a: T, b: T, strict?: boolean): number;
    }
    interface EqualityComparison<T> {
        (a: T, b: T, strict?: boolean): boolean;
    }
    interface Func<TResult> {
        (): TResult;
    }
    interface Closure {
        (): void;
    }
    interface IKeyValuePair<TKey, TValue> {
        key: TKey;
        value: TValue;
    }
    type KeyValuePair<TKey, TValue> = IKeyValuePair<TKey, TValue> | [TKey, TValue];
    interface IStringKeyValuePair<TValue> extends IKeyValuePair<string, TValue> {
    }
    type StringKeyValuePair<TValue> = IStringKeyValuePair<TValue> | [string, TValue];
    module Compare {
        function areEqual(a: any, b: any, strict?: boolean): boolean;
        function compare<T>(a: IComparable<T>, b: IComparable<T>): number;
        function compare<T extends Primitive>(a: T, b: T, strict?: boolean): CompareResult;
        function areEquivalent(a: any, b: any, nullEquivalency?: boolean, extraDepth?: number): boolean;
    }
    module KeyValueExtractModule {
        function isKeyValuePair<TKey, TValue>(kvp: any): kvp is IKeyValuePair<TKey, TValue>;
        function assertKey<TKey>(key: TKey, name?: string): TKey | never;
        function assertTuple(tuple: ArrayLike<any>, name?: string): void | never;
        function assertNotUndefined<T>(value: T, name: string): T | never;
        function extractKeyValue<TKey, TValue, TResult>(item: KeyValuePair<TKey, TValue>, to: (key: TKey, value: TValue) => TResult): TResult;
    }
    function Integer(n: number): number;
    module Integer {
        const MAX_32_BIT: number;
        const MAX_VALUE: number;
        function as32Bit(n: number): number;
        function is(n: number): boolean;
        function is32Bit(n: number): boolean;
        function assert(n: number, argumentName?: string): true | never;
        function assertZeroOrGreater(n: number, argumentName?: string): true | never;
        function assertPositive(n: number, argumentName?: string): true | never;
    }
    class Functions {
        Identity<T>(x: T): T;
        True(): boolean;
        False(): boolean;
        Blank(): void;
    }
    module Functions {
        const Identity: <T>(x: T) => T;
        const True: () => boolean;
        const False: () => boolean;
        const Blank: () => void;
    }
    namespace Exceptions {
        class SystemException extends Exception {
            protected getName(): string;
        }
        class ArgumentException extends SystemException {
            paramName: string;
            constructor(paramName: string, message?: string, innerException?: Error, beforeSealing?: (ex: any) => void);
            protected getName(): string;
        }
        class ArgumentNullException extends ArgumentException {
            constructor(paramName: string, message?: string, innerException?: Error);
            protected getName(): string;
        }
        class ArgumentOutOfRangeException extends ArgumentException {
            actualValue: Primitive | null | undefined;
            constructor(paramName: string, actualValue: Primitive | null | undefined, message?: string, innerException?: Error);
            protected getName(): string;
        }
        class InvalidOperationException extends SystemException {
            protected getName(): string;
        }
        class NullReferenceException extends SystemException {
            protected getName(): string;
        }
        class NotImplementedException extends SystemException {
            protected getName(): string;
        }
    }
    namespace Disposable {
        interface IDisposable {
            dispose(): void;
        }
        interface IDisposableAware extends IDisposable {
            wasDisposed: boolean;
        }
        class ObjectDisposedException extends Exceptions.InvalidOperationException {
            readonly objectName: string;
            constructor(objectName: string, message?: string, innerException?: Error);
            protected getName(): string;
            toString(): string;
            static throwIfDisposed(disposable: IDisposableAware, objectName: string, message?: string): true | never;
        }
        abstract class DisposableBase implements IDisposableAware {
            private readonly __finalizer;
            constructor(__finalizer?: Closure | null);
            private __wasDisposed;
            readonly wasDisposed: boolean;
            protected _disposableObjectName: string;
            protected throwIfDisposed(message?: string, objectName?: string): true | never;
            dispose(): void;
            protected _onDispose(): void;
        }
        type DisposableItem = IDisposable | null | undefined;
        type DisposableItemArray = Array<DisposableItem> | null | undefined;
        function dispose(...disposables: DisposableItem[]): void;
        module dispose {
            function single(disposable: DisposableItem, trapExceptions?: boolean): void;
            function deferred(...disposables: DisposableItem[]): void;
            function withoutException(...disposables: DisposableItem[]): any[] | undefined;
            function these(disposables: DisposableItemArray, trapExceptions?: boolean): any[] | undefined;
            module these {
                function deferred(disposables: DisposableItemArray, delay?: number): void;
                function noCopy(disposables: DisposableItemArray, trapExceptions?: boolean): any[] | undefined;
            }
        }
        function using<TDisposable extends IDisposable, TReturn>(disposable: TDisposable, closure: (disposable: TDisposable) => TReturn): TReturn;
        function disposeSingle(disposable: IDisposable, trapExceptions: boolean): any;
        class ObjectPool<T> extends DisposableBase {
            private _maxSize;
            private _generator;
            private _recycler;
            private _pool;
            private _trimmer;
            private _flusher;
            private _autoFlusher;
            private _localAbsMaxSize;
            autoClearTimeout: number;
            constructor(_maxSize: number, _generator?: (...args: any[]) => T, _recycler?: (o: T) => void);
            readonly maxSize: number;
            readonly count: number;
            protected _trim(): void;
            trim(defer?: number): void;
            protected _clear(): void;
            clear(defer?: number): void;
            toArrayAndClear(): T[];
            dump(): T[];
            protected _onDispose(): void;
            extendAutoClear(): void;
            add(o: T): void;
            private _onTaken();
            tryTake(): T | undefined;
            take(factory?: () => T): T;
        }
    }
    namespace Promises {
        class PromiseState<T> extends Disposable.DisposableBase {
            protected _state: Promise.State;
            protected _result: T;
            protected _error: any;
            constructor(_state: Promise.State, _result?: T, _error?: any);
            protected _onDispose(): void;
            protected getState(): Promise.State;
            readonly state: Promise.State;
            readonly isPending: boolean;
            readonly isSettled: boolean;
            readonly isFulfilled: boolean;
            readonly isRejected: boolean;
            protected getResult(): T | undefined;
            readonly result: T | undefined;
            protected getError(): any;
            readonly error: any;
        }
        abstract class PromiseBase<T> extends PromiseState<T> implements PromiseLike<T> {
            constructor();
            abstract thenSynchronous<TResult>(onFulfilled: Promise.Fulfill<T, TResult>, onRejected?: Promise.Reject<TResult>): PromiseBase<TResult>;
            abstract thenThis(onFulfilled: Promise.Fulfill<T, any>, onRejected?: Promise.Reject<any>): this;
            abstract thenThis(onFulfilled: (v?: T) => any, onRejected?: (v?: any) => any): this;
            then<TResult>(onFulfilled: Promise.Fulfill<T, TResult>, onRejected?: Promise.Reject<TResult>): PromiseBase<TResult>;
            thenAllowFatal<TResult>(onFulfilled: Promise.Fulfill<T, TResult>, onRejected?: Promise.Reject<TResult>): PromiseBase<TResult>;
            done(onFulfilled: Promise.Fulfill<T, any>, onRejected?: Promise.Reject<any>): void;
            delayFromNow(milliseconds?: number): PromiseBase<T>;
            delayAfterResolve(milliseconds?: number): PromiseBase<T>;
            'catch'<TResult>(onRejected: Promise.Reject<TResult>): PromiseBase<TResult>;
            catchAllowFatal<TResult>(onRejected: Promise.Reject<TResult>): PromiseBase<TResult>;
            'finally'<TResult>(fin: () => Promise.Resolution<TResult>): PromiseBase<TResult>;
            finallyAllowFatal<TResult>(fin: () => Promise.Resolution<TResult>): PromiseBase<TResult>;
            finallyThis(fin: Closure, synchronous?: boolean): this;
        }
        abstract class Resolvable<T> extends PromiseBase<T> {
            thenSynchronous<TResult>(onFulfilled: Promise.Fulfill<T, TResult>, onRejected?: Promise.Reject<TResult>): PromiseBase<TResult>;
            thenThis(onFulfilled: (v?: T) => any, onRejected?: (v?: any) => any): this;
        }
        abstract class Resolved<T> extends Resolvable<T> {
            constructor(state: Promise.State, result: T, error?: any);
        }
        class Fulfilled<T> extends Resolved<T> {
            constructor(value: T);
        }
        class Rejected<T> extends Resolved<T> {
            constructor(error: any);
        }
        class Promise<T> extends Resolvable<T> {
            private _waiting;
            constructor(resolver?: Promise.Executor<T>, forceSynchronous?: boolean);
            thenSynchronous<TResult>(onFulfilled: Promise.Fulfill<T, TResult>, onRejected?: Promise.Reject<TResult>): PromiseBase<TResult>;
            thenThis(onFulfilled: (v?: T) => any, onRejected?: (v?: any) => any): this;
            protected _onDispose(): void;
            protected _resolvedCalled: boolean;
            resolveUsing(resolver: Promise.Executor<T>, forceSynchronous?: boolean): void;
            private _emitDisposalRejection(p);
            private _resolveInternal(result?);
            private _rejectInternal(error);
            resolve(result?: T | PromiseLike<T>, throwIfSettled?: boolean): void;
            reject(error: any, throwIfSettled?: boolean): void;
        }
        class ArrayPromise<T> extends Promise<T[]> {
            map<U>(transform: (value: T) => U): ArrayPromise<U>;
            reduce<U>(reduction: (previousValue: U, currentValue: T, i?: number, array?: T[]) => U, initialValue?: U): PromiseBase<U>;
            static fulfilled<T>(value: T[]): ArrayPromise<T>;
        }
        class PromiseCollection<T> extends Disposable.DisposableBase {
            private _source;
            constructor(source: PromiseLike<T>[] | null | undefined);
            protected _onDispose(): void;
            readonly promises: PromiseLike<T>[];
            all(): ArrayPromise<T>;
            race(): PromiseBase<T>;
            waitAll(): ArrayPromise<PromiseLike<T>>;
            map<U>(transform: (value: T) => U): ArrayPromise<U>;
            pipe<U>(transform: (value: T) => U | PromiseLike<U>): PromiseCollection<U>;
            reduce<U>(reduction: (previousValue: U, currentValue: T, i?: number, array?: PromiseLike<T>[]) => U, initialValue?: U | PromiseLike<U>): PromiseBase<U>;
        }
        module Promise {
            enum State {
                Pending = 0,
                Fulfilled = 1,
                Rejected = -1,
            }
            type Resolution<TResult> = TResult | PromiseLike<TResult>;
            interface Fulfill<T, TResult> {
                (value: T): Resolution<TResult>;
            }
            interface Reject<TResult> {
                (reason: any): TResult | PromiseLike<TResult>;
            }
            interface Then<T, TResult> {
                (onfulfilled?: Fulfill<T, TResult>, onrejected?: Reject<TResult>): PromiseLike<TResult>;
                (onfulfilled?: Fulfill<T, TResult>, onrejected?: Reject<void>): PromiseLike<TResult>;
            }
            interface Executor<T> {
                (resolve: (value?: T | PromiseLike<T>) => void, reject: (reason?: any) => void): void;
            }
            interface Factory {
                <T>(executor: Executor<T>): PromiseLike<T>;
            }
            function factory<T>(e: Executor<T>): Promise<T>;
            function group<T>(promises: PromiseLike<T>[]): PromiseCollection<T>;
            function group<T>(promise: PromiseLike<T>, ...rest: PromiseLike<T>[]): PromiseCollection<T>;
            function all<T>(promises: PromiseLike<T>[]): ArrayPromise<T>;
            function all<T>(promise: PromiseLike<T>, ...rest: PromiseLike<T>[]): ArrayPromise<T>;
            function waitAll<T>(promises: PromiseLike<T>[]): ArrayPromise<PromiseLike<T>>;
            function waitAll<T>(promise: PromiseLike<T>, ...rest: PromiseLike<T>[]): ArrayPromise<PromiseLike<T>>;
            function race<T>(promises: PromiseLike<T>[]): PromiseBase<T>;
            function race<T>(promise: PromiseLike<T>, ...rest: PromiseLike<T>[]): PromiseBase<T>;
            function resolve(): PromiseBase<void>;
            function resolve<T>(value: T | PromiseLike<T>): PromiseBase<T>;
            function using<T>(resolver: Promise.Executor<T>, forceSynchronous?: boolean): PromiseBase<T>;
            function resolveAll<T>(resolutions: Array<T | PromiseLike<T>>): PromiseCollection<T>;
            function resolveAll<T>(promise: T | PromiseLike<T>, ...rest: Array<T | PromiseLike<T>>): PromiseCollection<T>;
            function map<T, U>(source: T[], transform: (value: T) => U): PromiseCollection<U>;
            function reject<T>(reason: T): PromiseBase<T>;
            function wrap<T>(target: T | PromiseLike<T>): PromiseBase<T>;
            function createFrom<T>(then: Then<T, any>): PromiseBase<T>;
        }
        class LazyPromise<T> extends Promise<T> {
            private _resolver;
            constructor(_resolver: Promise.Executor<T>);
            protected _onDispose(): void;
            private _onThen();
            thenSynchronous<TResult>(onFulfilled: Promise.Fulfill<T, TResult>, onRejected?: Promise.Reject<TResult>): PromiseBase<TResult>;
            thenThis(onFulfilled: (v?: T) => any, onRejected?: (v?: any) => any): this;
            delayFromNow(milliseconds?: number): PromiseBase<T>;
            delayAfterResolve(milliseconds?: number): PromiseBase<T>;
        }
    }
    namespace Threading {
        namespace Tasks {
            enum TaskStatus {
                Created = 0,
                WaitingToRun = 1,
                Running = 2,
                RanToCompletion = 3,
                Cancelled = 4,
                Faulted = 5,
            }
            interface ITaskState<T> {
                status: TaskStatus;
                result?: T;
                error?: any;
            }
            interface ParallelOptions {
                evalPath?: string;
                maxConcurrency?: number;
                allowSynchronous?: boolean;
                env?: any;
                envNamespace?: string;
            }
            type RequireType = string | Function | {
                name?: string;
                fn: Function;
            };
            class Parallel {
                options: ParallelOptions;
                _requiredScripts: string[];
                _requiredFunctions: {
                    name?: string;
                    fn: Function;
                }[];
                constructor(options?: ParallelOptions);
                static maxConcurrency(max: number): Parallel;
                protected _getWorkerSource(task: Function | string, env?: any): string;
                require(...required: RequireType[]): this;
                requireThese(required: RequireType[]): this;
                protected _spawnWorker(task: Function | string, env?: any): WorkerLike | undefined;
                startNew<T, U>(data: T, task: (data: T) => U, env?: any): Promises.Promise<U>;
                startLocal<T, U>(data: T, task: (data: T) => U): Promises.Promise<U>;
                pipe<T, U>(data: T[], task: (data: T) => U, env?: any): Promises.PromiseCollection<U>;
                private ensureClampedMaxConcurrency();
                map<T, U>(data: T[], task: (data: T) => U, env?: any): Promises.ArrayPromise<U>;
                static readonly isSupported: boolean;
                static options(options?: ParallelOptions): Parallel;
                static require(...required: RequireType[]): Parallel;
                static requireThese(required: RequireType[]): Parallel;
                static startNew<T, U>(data: T, task: (data: T) => U, env?: any): Promises.PromiseBase<U>;
                static map<T, U>(data: T[], task: (data: T) => U, env?: any): Promises.ArrayPromise<U>;
            }
            abstract class TaskHandlerBase extends Disposable.DisposableBase implements ICancellable {
                private _status;
                constructor();
                private _timeoutId;
                readonly isScheduled: boolean;
                start(defer?: number): void;
                runSynchronously(): void;
                protected getStatus(): TaskStatus;
                readonly status: TaskStatus;
                private static _handler(d);
                protected abstract _onExecute(): void;
                protected _onDispose(): void;
                cancel(): boolean;
            }
            class TaskHandler extends TaskHandlerBase {
                private readonly _action;
                constructor(_action: Closure);
                protected _onExecute(): void;
                protected _onDispose(): void;
            }
            class Task<T> extends TaskHandlerBase {
                private readonly _result;
                constructor(valueFactory: Func<T>);
                protected _onExecute(): void;
                protected getResult(): T;
                protected getState(): ITaskState<T>;
                start(defer?: number): void;
                runSynchronously(): void;
                readonly state: ITaskState<T>;
                readonly result: T;
                readonly error: any;
                protected _onDispose(): void;
            }
        }
        class Thread {
            static sleep(millisecondsTimeout: number): void;
        }
    }
    namespace Collections {
        namespace Enumeration {
            type IEnumerableOrArray<T> = ArrayLike<T> | IEnumerable<T>;
            class IteratorResult<T> implements IIteratorResult<T> {
                readonly value: T;
                readonly index?: number;
                readonly done: boolean;
                constructor(value: T, done: boolean);
                constructor(value: T, index?: number, done?: boolean);
            }
            module IteratorResult {
                const Done: IteratorResult<any>;
                function GetDone(): IteratorResult<any>;
            }
            class EmptyEnumerable implements IEnumerable<any> {
                constructor();
                getEnumerator(): IEnumerator<any>;
                readonly isEndless: boolean;
            }
            const EmptyEnumerator: IEnumerator<any>;
            function throwIfEndless(isEndless: false): true;
            function throwIfEndless(isEndless: boolean | undefined): true | never;
            function from<T>(source: ForEachEnumerable<T> | InfiniteValueFactory<T>): IEnumerator<T>;
            function isEnumerable<T>(instance: any): instance is IEnumerable<T>;
            function isEnumerableOrArrayLike<T>(instance: any): instance is IEnumerableOrArray<T>;
            function isEnumerator<T>(instance: any): instance is IEnumerator<T>;
            function isIterator<T>(instance: any): instance is IIterator<T>;
            function forEach<T>(e: ForEachEnumerable<T>, action: ActionWithIndex<T>, max?: number): number;
            function forEach<T>(e: ForEachEnumerable<T>, action: PredicateWithIndex<T>, max?: number): number;
            function toArray<T>(source: ForEachEnumerable<T>, max?: number): T[];
            function map<T, TResult>(source: ForEachEnumerable<T>, selector: SelectorWithIndex<T, TResult>, max?: number): TResult[];
            class EnumeratorBase<T> extends Disposable.DisposableBase implements IEnumerator<T> {
                private _initializer;
                private _tryGetNext;
                private _yielder;
                private _state;
                private _disposer;
                readonly current: T | undefined;
                readonly index: number;
                constructor(initializer: Closure | null, tryGetNext: (yielder: IYield<T>) => boolean, isEndless?: boolean);
                constructor(initializer: Closure | null, tryGetNext: (yielder: IYield<T>) => boolean, disposer?: Closure | null, isEndless?: boolean);
                protected _isEndless: boolean;
                readonly isEndless: boolean | undefined;
                reset(): void;
                private _assertBadState();
                tryGetCurrent(out: Action<T>): boolean;
                readonly canMoveNext: boolean;
                moveNext(): boolean;
                tryMoveNext(out: Action<T>): boolean;
                nextValue(): T | undefined;
                next(): IIteratorResult<T>;
                end(): void;
                'return'(): IIteratorResult<void>;
                'return'<TReturn>(value: TReturn): IIteratorResult<TReturn>;
                private _ensureDisposeState(state);
                protected _onDispose(): void;
            }
            type ForEachEnumerable<T> = IEnumerableOrArray<T> | IEnumerator<T> | IIterator<T>;
            interface IEnumerable<T> {
                getEnumerator(): IEnumerator<T>;
                isEndless?: boolean;
            }
            interface IEnumerateEach<T> {
                forEach(action: ActionWithIndex<T>, useCopy?: boolean): number;
                forEach(action: PredicateWithIndex<T>, useCopy?: boolean): number;
            }
            interface IEnumerator<T> extends IIterator<T>, Disposable.IDisposable {
                current: T | undefined;
                canMoveNext?: boolean;
                moveNext(value?: any): boolean;
                tryMoveNext(out: (value: T) => void): boolean;
                reset(): void;
                end(): void;
                nextValue(value?: any): T | undefined;
                isEndless?: boolean;
            }
            interface IIteratorResult<T> {
                done: boolean;
                value?: T;
                index?: number;
            }
            interface IIterator<T> {
                next(value?: any): IIteratorResult<T>;
                'return'?<TReturn>(value?: TReturn): IIteratorResult<TReturn>;
                'throw'?(e?: any): IIteratorResult<T>;
            }
            interface IndexEnumeratorSource<T> {
                source: {
                    [index: number]: T;
                };
                length: number;
                step?: number;
                pointer?: number;
            }
            abstract class SimpleEnumerableBase<T> implements IEnumerator<T> {
                protected _current: T | undefined;
                protected _index: number;
                constructor();
                readonly current: T | undefined;
                protected abstract _canMoveNext(): boolean;
                readonly canMoveNext: boolean;
                abstract moveNext(): boolean;
                tryMoveNext(out: Action<T>): boolean;
                protected incrementIndex(): number;
                nextValue(): T | undefined;
                next(): IIteratorResult<T>;
                end(): void;
                'return'(): IIteratorResult<void>;
                'return'<TReturn>(value: TReturn): IIteratorResult<TReturn>;
                reset(): void;
                dispose(): void;
                protected getIsEndless(): boolean;
                readonly isEndless: boolean | undefined;
            }
            class IndexEnumerator<T> extends EnumeratorBase<T> {
                constructor(sourceFactory: () => IndexEnumeratorSource<T>);
            }
            class ArrayEnumerator<T> extends IndexEnumerator<T> {
                constructor(arrayFactory: () => ArrayLike<T>, start?: number, step?: number);
                constructor(array: ArrayLike<T>, start?: number, step?: number);
            }
            interface InfiniteValueFactory<T> {
                (previous: T | undefined, index: number): T;
            }
            class InfiniteEnumerator<T> extends SimpleEnumerableBase<T> {
                private readonly _factory;
                constructor(_factory: InfiniteValueFactory<T>);
                protected _canMoveNext(): boolean;
                moveNext(): boolean;
                dispose(): void;
            }
            class IteratorEnumerator<T> extends SimpleEnumerableBase<T> {
                private readonly _iterator;
                private readonly _isEndless;
                constructor(_iterator: IIterator<T>, _isEndless?: boolean);
                protected _canMoveNext(): boolean;
                moveNext(value?: any): boolean;
                dispose(): void;
                protected getIsEndless(): boolean;
            }
            interface IYield<T> {
                current: T | undefined;
                yieldReturn(value: T | undefined): boolean;
                yieldBreak(): boolean;
            }
            class Randomizer<T> extends SimpleEnumerableBase<T> {
                private readonly _allowReset;
                private readonly _buffer;
                private _pointer;
                constructor(source: ForEachEnumerable<T>, _allowReset?: boolean);
                protected _canMoveNext(): boolean;
                moveNext(): boolean;
                reset(): void;
                dispose(): void;
                protected getIsEndless(): boolean;
            }
            class Error extends Exception {
            }
            class UnsupportedEnumerableException extends Exceptions.SystemException {
                constructor(message?: string);
                protected getName(): string;
            }
        }
        interface ICollection<T> extends IReadOnlyCollection<T> {
            add(entry: T): void;
            remove(entry: T, max?: number): number;
            clear(): number;
            importEntries(entries: Enumeration.IEnumerableOrArray<T> | Enumeration.IEnumerator<T>): number;
            toArray(): T[];
        }
        interface ArrayLikeWritable<T> {
            length: number;
            [n: number]: T;
        }
        interface ILinkedNodeList<TNode extends ILinkedNode<TNode>> {
            first: TNode | null;
            last: TNode | null;
            getNodeAt(index: number): TNode | null;
            removeNode(node: TNode): boolean;
        }
        interface ILinkedList<T> extends ILinkedNodeList<ILinkedListNode<T>>, ICollection<T>, Enumeration.IEnumerateEach<T> {
            first: ILinkedListNode<T> | null;
            last: ILinkedListNode<T> | null;
            getValueAt(index: number): T | undefined;
            find(entry: T): ILinkedListNode<T> | null;
            findLast(entry: T): ILinkedListNode<T> | null;
            addFirst(entry: T): void;
            addLast(entry: T): void;
            removeFirst(): void;
            removeLast(): void;
            addAfter(node: ILinkedListNode<T>, entry: T): void;
        }
        interface ILinkedNode<TNode extends ILinkedNode<TNode>> {
            previous?: any;
            next?: any;
        }
        interface INodeWithValue<TValue> {
            value: TValue;
        }
        interface ILinkedNodeWithValue<T> extends ILinkedNode<ILinkedListNode<T>>, INodeWithValue<T> {
        }
        interface ILinkedListNode<T> extends ILinkedNodeWithValue<T> {
            previous: ILinkedListNode<T> | null;
            next: ILinkedListNode<T> | null;
            list: ILinkedList<T>;
            addBefore(entry: T): void;
            addAfter(entry: T): void;
            remove(): void;
        }
        interface IReadOnlyList<T> extends IReadOnlyCollection<T> {
            get(index: number): T;
            indexOf(item: T): number;
        }
        interface IList<T> extends ICollection<T>, IReadOnlyList<T> {
            set(index: number, value: T): boolean;
            insert(index: number, value: T): void;
            removeAt(index: number): boolean;
            addRange(entries: IList<T>): void;
        }
        interface IReadOnlyCollection<T> extends Enumeration.IEnumerable<T> {
            count: number;
            isReadOnly: boolean;
            contains(entry: T): boolean;
            copyTo<TTarget extends ArrayLikeWritable<any>>(target: TTarget, index?: number): TTarget;
            toArray(): T[];
        }
        interface ISet<T> extends ICollection<T> {
            exceptWith(other: Enumeration.IEnumerableOrArray<T>): void;
            intersectWith(other: Enumeration.IEnumerableOrArray<T>): void;
            isProperSubsetOf(other: Enumeration.IEnumerableOrArray<T>): boolean;
            isProperSupersetOf(other: Enumeration.IEnumerableOrArray<T>): boolean;
            isSubsetOf(other: Enumeration.IEnumerableOrArray<T>): boolean;
            isSupersetOf(other: Enumeration.IEnumerableOrArray<T>): boolean;
            overlaps(other: Enumeration.IEnumerableOrArray<T>): boolean;
            setEquals(other: Enumeration.IEnumerableOrArray<T>): boolean;
            symmetricExceptWith(other: Enumeration.IEnumerableOrArray<T>): void;
            unionWith(other: Enumeration.IEnumerableOrArray<T>): void;
        }
        abstract class CollectionBase<T> extends Disposable.DisposableBase implements ICollection<T>, Enumeration.IEnumerateEach<T> {
            protected _equalityComparer: EqualityComparison<T | null | undefined>;
            constructor(source?: Enumeration.IEnumerableOrArray<T> | Enumeration.IEnumerator<T>, _equalityComparer?: EqualityComparison<T | null | undefined>);
            protected abstract getCount(): number;
            readonly count: number;
            readonly length: number;
            protected getIsReadOnly(): boolean;
            readonly isReadOnly: boolean;
            protected assertModifiable(): true | never;
            protected _version: number;
            protected assertVersion(version: number): true | never;
            private _modifiedCount;
            private _updateRecursion;
            protected _onModified(): void;
            protected _signalModification(increment?: boolean): boolean;
            protected _incrementModified(): void;
            readonly isUpdating: boolean;
            handleUpdate(closure?: () => boolean): boolean;
            protected abstract _addInternal(entry: T): boolean;
            add(entry: T): void;
            push(entry: T): void;
            protected abstract _removeInternal(entry: T, max?: number): number;
            remove(entry: T, max?: number): number;
            protected abstract _clearInternal(): number;
            clear(): number;
            protected _onDispose(): void;
            protected _importEntries(entries: Enumeration.IEnumerableOrArray<T> | Enumeration.IEnumerator<T> | null | undefined): number;
            importEntries(entries: Enumeration.IEnumerableOrArray<T> | Enumeration.IEnumerator<T>): number;
            abstract getEnumerator(): Enumeration.IEnumerator<T>;
            filter(predicate: PredicateWithIndex<T>): T[];
            any(predicate?: PredicateWithIndex<T>): boolean;
            some(predicate?: PredicateWithIndex<T>): boolean;
            contains(entry: T): boolean;
            forEach(action: ActionWithIndex<T>, useCopy?: boolean): number;
            forEach(action: PredicateWithIndex<T>, useCopy?: boolean): number;
            copyTo<TTarget extends ArrayLikeWritable<T>>(target: TTarget, index?: number): TTarget;
            toArray(): T[];
            private _linq?;
            readonly linq: ILinqEnumerable<T>;
            linqAsync(callback?: Action<ILinqEnumerable<T>>): ILinqEnumerable<T> | undefined;
        }
        abstract class ReadOnlyCollectionBase<T> extends CollectionBase<T> {
            protected abstract _getCount(): number;
            protected getCount(): number;
            protected getIsReadOnly(): boolean;
            protected _addInternal(entry: T): boolean;
            protected _removeInternal(entry: T, max?: number): number;
            protected _clearInternal(): number;
            protected abstract _getEnumerator(): Enumeration.IEnumerator<T>;
            getEnumerator(): Enumeration.IEnumerator<T>;
        }
        class ReadOnlyCollectionWrapper<T> extends ReadOnlyCollectionBase<T> {
            constructor(collection: ICollection<T> | ArrayLike<T>);
            private __getCount;
            private __getEnumerator;
            protected _getCount(): number;
            protected _getEnumerator(): Enumeration.IEnumerator<T>;
            protected _onDispose(): void;
        }
        class LazyList<T> extends ReadOnlyCollectionBase<T> implements IReadOnlyList<T> {
            private _enumerator;
            private _cached;
            constructor(source: Enumeration.IEnumerable<T>);
            protected _onDispose(): void;
            protected _getCount(): number;
            protected _getEnumerator(): Enumeration.IEnumerator<T>;
            get(index: number): T;
            indexOf(item: T): number;
            contains(item: T): boolean;
            private getNext(out?);
            private finish();
        }
        class LinkedList<T> extends CollectionBase<T> implements ILinkedList<T> {
            private readonly _listInternal;
            constructor(source?: Enumeration.IEnumerableOrArray<T>, equalityComparer?: EqualityComparison<T>);
            protected assertVersion(version: number): true | never;
            protected _onDispose(): void;
            protected getCount(): number;
            protected _addInternal(entry: T): boolean;
            protected _removeInternal(entry: T, max?: number): number;
            protected _clearInternal(): number;
            forEach(action: ActionWithIndex<T>, useCopy?: boolean): number;
            forEach(action: PredicateWithIndex<T>, useCopy?: boolean): number;
            getEnumerator(): Enumeration.IEnumerator<T>;
            private _findFirst(entry);
            private _findLast(entry);
            removeOnce(entry: T): boolean;
            readonly first: ILinkedListNode<T> | null;
            readonly firstValue: T | undefined;
            readonly last: ILinkedListNode<T> | null;
            readonly lastValue: T | undefined;
            getValueAt(index: number): T | undefined;
            getNodeAt(index: number): ILinkedListNode<T> | null;
            find(entry: T): ILinkedListNode<T> | null;
            findLast(entry: T): ILinkedListNode<T> | null;
            addFirst(entry: T): void;
            addLast(entry: T): void;
            private _removeNodeInternal(node);
            removeFirst(): boolean;
            removeLast(): boolean;
            removeAt(index: number): boolean;
            removeNode(node: ILinkedListNode<T>): boolean;
            addBefore(before: ILinkedListNode<T>, entry: T): void;
            addAfter(after: ILinkedListNode<T>, entry: T): void;
        }
        class LinkedNodeList<TNode extends ILinkedNode<TNode>> implements ILinkedNodeList<TNode>, Enumeration.IEnumerateEach<TNode>, Disposable.IDisposable {
            private _first;
            private _last;
            unsafeCount: number;
            constructor();
            private _version;
            assertVersion(version: number): true | never;
            readonly first: TNode | null;
            readonly last: TNode | null;
            readonly count: number;
            forEach(action: ActionWithIndex<TNode> | PredicateWithIndex<TNode>, ignoreVersioning?: boolean): number;
            map<T>(selector: Selector<TNode, T> | SelectorWithIndex<TNode, T>): T[];
            clear(): number;
            dispose(): void;
            contains(node: TNode): boolean;
            getNodeAt(index: number): TNode | null;
            find(condition: PredicateWithIndex<TNode>): TNode | null;
            indexOf(node: TNode): number;
            removeFirst(): boolean;
            removeLast(): boolean;
            removeNode(node: TNode): boolean;
            addNode(node: TNode): void;
            addNodeBefore(node: TNode, before?: TNode | null): void;
            addNodeAfter(node: TNode, after?: TNode | null): void;
            replace(node: TNode, replacement: TNode): void;
            static valueEnumeratorFrom<T>(list: LinkedNodeList<ILinkedNodeWithValue<T>>): Enumeration.IEnumerator<T>;
            static copyValues<T, TDestination extends ArrayLikeWritable<any>>(list: LinkedNodeList<ILinkedNodeWithValue<T>>, array: TDestination, index?: number): TDestination;
        }
        class List<T> extends CollectionBase<T> implements IList<T>, Enumeration.IEnumerateEach<T> {
            protected readonly _source: T[];
            constructor(source?: Enumeration.IEnumerableOrArray<T>, equalityComparer?: EqualityComparison<T>);
            protected _onDispose(): void;
            protected getCount(): number;
            protected _addInternal(entry: T): boolean;
            protected _removeInternal(entry: T, max?: number): number;
            protected _clearInternal(): number;
            protected _importEntries(entries: Enumeration.IEnumerableOrArray<T> | null | undefined): number;
            get(index: number): T;
            set(index: number, value: T): boolean;
            indexOf(item: T): number;
            insert(index: number, value: T): void;
            removeAt(index: number): boolean;
            contains(item: T): boolean;
            copyTo<TTarget extends ArrayLikeWritable<any>>(target: TTarget, index?: number): TTarget;
            getEnumerator(): Enumeration.IEnumerator<T>;
            forEach(action: ActionWithIndex<T>, useCopy?: boolean): number;
            forEach(action: PredicateWithIndex<T>, useCopy?: boolean): number;
            addRange(entries: IList<T>): void;
        }
        class Queue<T> extends CollectionBase<T> {
            private _array;
            private _head;
            private _tail;
            private _size;
            private _capacity;
            constructor(source?: Enumeration.IEnumerableOrArray<T> | number, equalityComparer?: EqualityComparison<T>);
            protected getCount(): number;
            protected _addInternal(item: T): boolean;
            protected _removeInternal(item: T, max?: number): number;
            protected _clearInternal(): number;
            protected _onDispose(): void;
            dump(max?: number): T[];
            forEach(action: ActionWithIndex<T>): number;
            forEach(action: PredicateWithIndex<T>): number;
            setCapacity(capacity: number): void;
            enqueue(item: T): void;
            protected _tryDequeueInternal(out: Action<T>): boolean;
            dequeue(): T | undefined;
            dequeue(throwIfEmpty: true): T;
            dequeue(throwIfEmpty: boolean): T | undefined;
            tryDequeue(out: Action<T>): boolean;
            private _getElement(index);
            peek(): T | undefined;
            peek(throwIfEmpty: true): T;
            peek(throwIfEmpty: boolean): T | undefined;
            trimExcess(threshold?: number): void;
            getEnumerator(): Enumeration.IEnumerator<T>;
        }
        module MapUtility {
            function apply<T extends IMap<any>, U extends IMap<any>>(target: T, source: U): T & U;
            function ensure<T extends IMap<any>, U extends IMap<any>>(target: T, defaults: U): T & U;
            function copy<T extends IMap<any>>(source: T): T;
            function merge<A extends IMap<any>, B extends IMap<any>>(a: A, b: B): A & B;
            function trim<TResult extends IMap<any>>(target: IMap<any>, keyMap: TResult): void;
        }
        class KeyNotFoundException extends Exceptions.SystemException {
            protected getName(): string;
        }
        namespace InternalSet {
            import IDisposable = Disposable.IDisposable;
            import IEnumerableOrArray = Enumeration.IEnumerableOrArray;
            import IEnumerator = Enumeration.IEnumerator;
            function getId(obj: any): string | number | symbol;
            abstract class SetBase<T> extends CollectionBase<T> implements ISet<T>, IDisposable {
                constructor(source?: IEnumerableOrArray<T>);
                protected abstract newUsing(source?: IEnumerableOrArray<T>): SetBase<T>;
                protected _set: LinkedNodeList<ILinkedNodeWithValue<T>>;
                protected _getSet(): LinkedNodeList<ILinkedNodeWithValue<T>>;
                protected getCount(): number;
                exceptWith(other: IEnumerableOrArray<T>): void;
                intersectWith(other: IEnumerableOrArray<T>): void;
                isProperSubsetOf(other: IEnumerableOrArray<T>): boolean;
                isProperSupersetOf(other: IEnumerableOrArray<T>): boolean;
                isSubsetOf(other: IEnumerableOrArray<T>): boolean;
                isSupersetOf(other: IEnumerableOrArray<T>): boolean;
                overlaps(other: IEnumerableOrArray<T>): boolean;
                setEquals(other: IEnumerableOrArray<T>): boolean;
                symmetricExceptWith(other: IEnumerableOrArray<T>): void;
                unionWith(other: IEnumerableOrArray<T>): void;
                protected _clearInternal(): number;
                protected _onDispose(): void;
                protected abstract _getNode(item: T): ILinkedNodeWithValue<T> | undefined;
                contains(item: T): boolean;
                getEnumerator(): IEnumerator<T>;
                forEach(action: ActionWithIndex<T>, useCopy?: boolean): number;
                forEach(action: PredicateWithIndex<T>, useCopy?: boolean): number;
                protected _removeNode(node: ILinkedNodeWithValue<T> | null | undefined): boolean;
                removeFirst(): boolean;
                removeLast(): boolean;
            }
        }
        import SetBase = InternalSet.SetBase;
        class HashSet<T> extends SetBase<T> {
            private readonly _keyGenerator;
            constructor(keyGenerator: Selector<T, string | number | symbol>);
            constructor(source: Enumeration.IEnumerableOrArray<T> | undefined, keyGenerator: Selector<T, string | number | symbol>);
            protected newUsing(source?: Enumeration.IEnumerableOrArray<T>): HashSet<T>;
            private _registry;
            protected _addInternal(item: T): boolean;
            protected _clearInternal(): number;
            protected _onDispose(): void;
            protected _getNode(item: T): ILinkedNodeWithValue<T> | undefined;
            protected _removeInternal(item: T, max?: number): number;
        }
        class Set<T extends Primitive | Dictionaries.ISymbolizable | symbol> extends HashSet<T> {
            constructor(source?: Enumeration.IEnumerableOrArray<T>);
        }
        module ArrayModule {
            namespace Sorting {
                module QuickSort {
                    function quickSort<T extends Primitive, TArray extends ArrayLikeWritable<T>>(target: TArray): TArray;
                }
                function createComparer<TSource, TSelect extends Primitive>(selector: Selector<TSource, TSelect | TSelect[]>, order?: Collections.Sorting.Order | Collections.Sorting.Order[], equivalentToNaN?: any): Comparison<TSource>;
                function insertionSort<T extends Primitive, TArray extends ArrayLikeWritable<T>>(target: TArray): TArray;
                module MergeSort {
                    function mergeSort<T extends Primitive, TArray extends ArrayLikeWritable<T>>(target: TArray): TArray;
                }
            }
            function initialize<T>(length: number): T[];
            function sum(source: ArrayLike<number>, ignoreNaN?: boolean): number;
            function average(source: ArrayLike<number>, ignoreNaN?: boolean): number;
            function product(source: ArrayLike<number>, ignoreNaN?: boolean): number;
            function quotient(source: ArrayLike<number>, ignoreNaN?: boolean): number;
            function min(source: ArrayLike<number>, ignoreNaN?: boolean): number;
            function max(source: ArrayLike<number>, ignoreNaN?: boolean): number;
            function shuffle<T extends ArrayLikeWritable<any>>(target: T): T;
            function indexOf<T>(array: ArrayLike<T>, item: T, equalityComparer?: EqualityComparison<T>): number;
            function contains<T>(array: ArrayLike<T>, item: T, equalityComparer?: EqualityComparison<T>): boolean;
            function replace<T>(array: ArrayLikeWritable<T>, old: T, newValue: T, max?: number): number;
            function updateRange<T>(array: ArrayLike<T>, value: T, start?: number, stop?: number): void;
            function clear(array: ArrayLikeWritable<any>, start?: number, stop?: number): void;
            function register<T>(array: ArrayLikeWritable<T>, item: T, equalityComparer?: EqualityComparison<T>): boolean;
            function findIndex<T>(array: ArrayLike<T>, predicate: PredicateWithIndex<T>): number;
            function forEach<T>(source: ArrayLike<T>, action: ActionWithIndex<T>): void;
            function forEach<T>(source: ArrayLike<T>, action: PredicateWithIndex<T>): void;
            function applyTo<T>(target: ArrayLikeWritable<T>, fn: SelectorWithIndex<T, T>): void;
            function removeIndex<T>(array: T[], index: number): boolean;
            function remove<T>(array: T[], value: T, max?: number, equalityComparer?: EqualityComparison<T>): number;
            function repeat<T>(element: T, count: number): T[];
            function range(first: number, count: number, step?: number): number[];
            function rangeUntil(first: number, until: number, step?: number): number[];
            function distinct(source: string[]): string[];
            function distinct(source: number[]): number[];
            function flatten(a: any[], recurseDepth?: number): any[];
            module ArraySort {
                const quick: typeof Sorting.QuickSort.quickSort;
                function using<TSource, TSelect extends Primitive>(target: TSource[], selector: Selector<TSource, TSelect | TSelect[]>, order?: Collections.Sorting.Order | Collections.Sorting.Order[], equivalentToNaN?: any): TSource[];
            }
            class ReadOnlyArrayWrapper<T> extends ReadOnlyCollectionWrapper<T> {
                constructor(array: ArrayLike<T>);
                protected _onDispose(): void;
                private __getValueAt;
                getValueAt(index: number): T;
            }
            function areAllEqual(arrays: ArrayLike<ArrayLike<any>>, equalityComparer?: EqualityComparison<any>): boolean;
            function areAllEqual(arrays: ArrayLike<ArrayLike<any>>, strict: boolean, equalityComparer?: EqualityComparison<any>): boolean;
            function areEqual<T>(a: ArrayLike<T>, b: ArrayLike<T>, equalityComparer?: EqualityComparison<T>): boolean;
            function areEqual<T>(a: ArrayLike<T>, b: ArrayLike<T>, strict: boolean, equalityComparer?: EqualityComparison<T>): boolean;
            function areEquivalent<T extends Primitive>(a: ArrayLike<T>, b: ArrayLike<T>): boolean;
            function areEquivalent<T>(a: ArrayLike<IComparable<T>>, b: ArrayLike<IComparable<T>>): boolean;
            function areEquivalent<T>(a: ArrayLike<T>, b: ArrayLike<T>, comparer: Comparison<T>): boolean;
            function copy<T>(source: ArrayLike<T>, sourceIndex?: number, length?: number): T[];
            function copyTo<T, TDestination extends ArrayLikeWritable<T>>(source: ArrayLike<T>, destination: TDestination, sourceIndex?: number, destinationIndex?: number, length?: number): TDestination;
            interface DispatchErrorHandler {
                (ex: any, index: number): void;
            }
            function dispatch<T>(listeners: ArrayLike<Selector<T, any>>, payload: T, trap?: boolean | DispatchErrorHandler): void;
            module dispatch {
                function unsafe<T>(listeners: ArrayLike<Selector<T, any>>, payload: T, trap?: boolean | DispatchErrorHandler): void;
                function mapped<T, TResult>(listeners: ArrayLike<Selector<T, TResult>>, payload: T, trap?: boolean | DispatchErrorHandler): TResult[];
            }
        }
        namespace Dictionaries {
            function getIdentifier(obj: any): string | number | symbol;
            function getIdentifier(obj: any, throwIfUnknown: false): string | number | symbol;
            function getIdentifier(obj: any, throwIfUnknown: boolean): string | number | symbol | never;
            function getIdentifier(obj: any, unknownHandler: Selector<any, string | number | symbol>): string | number | symbol;
            interface IHashable {
                getHashCode(): string | number;
            }
            interface ISymbolizable {
                getSymbol(): symbol;
            }
            interface IDictionary<TKey, TValue> extends ICollection<IKeyValuePair<TKey, TValue>> {
                keys: TKey[];
                values: TValue[];
                addByKeyValue(key: TKey, value: TValue): boolean;
                setValue(key: TKey, value: TValue | undefined): boolean;
                getValue(key: TKey): TValue | undefined;
                getAssuredValue(key: TKey): TValue;
                tryGetValue(key: TKey, out: Action<TValue>): boolean;
                containsKey(key: TKey): boolean;
                containsValue(value: TValue): boolean;
                removeByKey(key: TKey): boolean;
                removeByValue(value: TValue): number;
            }
            interface IStringKeyDictionary<TValue> extends IDictionary<string, TValue>, ICollection<IStringKeyValuePair<TValue>> {
                importMap(map: IMap<TValue>): boolean;
            }
            interface IOrderedDictionary<TKey, TValue> extends IDictionary<TKey, TValue> {
                indexOfKey(key: TKey): number;
                getValueByIndex(index: number): TValue;
            }
            abstract class DictionaryBase<TKey, TValue> extends CollectionBase<IKeyValuePair<TKey, TValue>> implements IDictionary<TKey, TValue> {
                constructor(source?: Enumeration.IEnumerableOrArray<IKeyValuePair<TKey, TValue>>);
                protected _onValueModified(key: TKey, value: TValue | undefined, old: TValue | undefined): void;
                protected _addInternal(item: KeyValuePair<TKey, TValue>): boolean;
                protected _clearInternal(): number;
                contains(item: KeyValuePair<TKey, TValue>): boolean;
                protected _removeInternal(item: IKeyValuePair<TKey, TValue> | [TKey, TValue]): number;
                protected abstract getKeys(): TKey[];
                readonly keys: TKey[];
                protected abstract getValues(): TValue[];
                readonly values: TValue[];
                addByKeyValue(key: TKey, value: TValue): boolean;
                protected abstract _getEntry(key: TKey): IKeyValuePair<TKey, TValue> | null;
                abstract getValue(key: TKey): TValue | undefined;
                getAssuredValue(key: TKey): TValue;
                tryGetValue(key: TKey, out: Action<TValue>): boolean;
                protected abstract _setValueInternal(key: TKey, value: TValue | undefined): boolean;
                setValue(key: TKey, value: TValue | undefined): boolean;
                containsKey(key: TKey): boolean;
                containsValue(value: TValue): boolean;
                removeByKey(key: TKey): boolean;
                removeByValue(value: TValue): number;
                importEntries(pairs: Enumeration.IEnumerableOrArray<KeyValuePair<TKey, TValue>> | Enumeration.IEnumerator<KeyValuePair<TKey, TValue>> | null | undefined): number;
                protected _importEntries(pairs: Enumeration.IEnumerableOrArray<KeyValuePair<TKey, TValue>> | Enumeration.IEnumerator<KeyValuePair<TKey, TValue>> | null | undefined): number;
                getEnumerator(): Enumeration.IEnumerator<IKeyValuePair<TKey, TValue>>;
            }
            interface IHashEntry<TKey, TValue> extends ILinkedNode<IHashEntry<TKey, TValue>>, IKeyValuePair<TKey, TValue> {
            }
            class StringKeyDictionary<TValue> extends DictionaryBase<string, TValue> implements IStringKeyDictionary<TValue> {
                protected _onDispose(): void;
                private _count;
                private readonly _map;
                protected _getEntry(key: string): IKeyValuePair<string, TValue> | null;
                containsKey(key: string): boolean;
                containsValue(value: TValue): boolean;
                getValue(key: string): TValue | undefined;
                protected _setValueInternal(key: string, value: TValue | undefined): boolean;
                importMap(values: IMap<TValue>): boolean;
                toMap(selector?: (key: string, value: TValue) => TValue): IMap<TValue>;
                protected getKeys(): string[];
                protected getValues(): TValue[];
                protected getCount(): number;
            }
            class OrderedStringKeyDictionary<TValue> extends StringKeyDictionary<TValue> implements IOrderedDictionary<string, TValue> {
                private _order;
                constructor();
                indexOfKey(key: string): number;
                getValueByIndex(index: number): TValue;
                setValue(key: string, value: TValue | undefined, keepIndex?: boolean): boolean;
                setByIndex(index: number, value: TValue | undefined): boolean;
                importValues(values: TValue[]): boolean;
                setValues(...values: TValue[]): boolean;
                removeByIndex(index: number): boolean;
                protected getKeys(): string[];
            }
            class Dictionary<TKey, TValue> extends DictionaryBase<TKey, TValue> {
                private readonly _keyGenerator;
                private readonly _entries;
                private readonly _buckets;
                constructor(_keyGenerator?: Selector<TKey, string | number | symbol>);
                protected _onDispose(): void;
                protected getCount(): number;
                private _getBucket(hash, createIfMissing?);
                private _getBucketEntry(key, hash?, bucket?);
                protected _getEntry(key: TKey): IHashEntry<TKey, TValue> | null;
                getValue(key: TKey): TValue | undefined;
                protected _setValueInternal(key: TKey, value: TValue | undefined): boolean;
                protected _clearInternal(): number;
                getEnumerator(): Enumeration.IEnumerator<IKeyValuePair<TKey, TValue>>;
                protected getKeys(): TKey[];
                protected getValues(): TValue[];
            }
        }
        namespace Sorting {
            class SortContext<T> implements IComparer<T> {
                protected _next: IComparer<T> | null;
                protected _comparer: Comparison<T>;
                protected _order: Order;
                readonly order: Order;
                constructor(_next: IComparer<T> | null, _comparer?: Comparison<T>, _order?: Order);
                generateSortedIndexes(source: T[]): number[];
                compare(a: T, b: T): number;
            }
            const enum Order {
                Ascending = 1,
                Descending = -1,
            }
            class KeySortedContext<T, TKey extends Comparable> extends SortContext<T> {
                protected _keySelector: Selector<T, TKey> | null;
                constructor(next: IComparer<T> | null, _keySelector: Selector<T, TKey> | null, order?: Order, comparer?: Comparison<T>);
                compare(a: T, b: T): number;
            }
        }
    }
    module Random {
        function integer(min: number, max?: number): number;
        function next(boundary: number, inclusive?: boolean): number;
        module next {
            function integer(boundary: number, inclusive?: boolean): number;
            function float(boundary?: number): number;
            function inRange(min: number, max: number, inclusive?: boolean): number;
        }
        function integers(count: number, boundary: number, inclusive?: boolean): number[];
        function shuffle<T extends Collections.ArrayLikeWritable<any>>(target: T): T;
        function copy<T>(source: ArrayLike<T>): T[];
        function select<T>(source: ArrayLike<T>, maxCount: number): T[];
        module select {
            function one<T>(source: ArrayLike<T>, throwIfEmpty: true): T;
            function one<T>(source: ArrayLike<T>, throwIfEmpty?: boolean): T | undefined;
        }
    }
    abstract class ResolverBase<T> extends Disposable.DisposableBase {
        protected _valueFactory: Func<T>;
        private readonly _trapExceptions;
        private readonly _allowReset;
        protected _isValueCreated: boolean | null;
        protected _value: T;
        constructor(_valueFactory: Func<T>, _trapExceptions: boolean, _allowReset?: boolean);
        protected _error: any;
        protected getError(): any;
        readonly error: any;
        getValue(): T;
        readonly canReset: boolean;
        protected _onDispose(): void;
        tryReset(): boolean;
    }
    interface ILazy<T> extends Disposable.IDisposable, IEquatable<ILazy<T>> {
        value: T;
        isValueCreated: boolean;
    }
    class Lazy<T> extends ResolverBase<T> implements ILazy<T> {
        constructor(valueFactory: Func<T>, trapExceptions?: boolean, allowReset?: boolean);
        readonly isValueCreated: boolean;
        readonly value: T;
        equals(other: Lazy<T>): boolean;
        valueEquals(other: Lazy<T>): boolean;
        static create<T>(valueFactory: Func<T>, trapExceptions?: boolean, allowReset?: boolean): Lazy<T>;
    }
    class ResettableLazy<T> extends Lazy<T> {
        constructor(valueFactory: Func<T>, trapExceptions?: boolean);
        static create<T>(valueFactory: Func<T>, trapExceptions?: boolean): ResettableLazy<T>;
    }
    namespace Threading {
        interface WorkerLike {
            onmessage: (message: {
                data: any;
            }) => void;
            onerror: (error: any) => void;
            postMessage(obj: any): void;
            terminate(): void;
        }
        interface WorkerConstructor {
            new (url: string): WorkerLike;
        }
        interface ICancellable extends Disposable.IDisposable {
            cancel(): boolean;
        }
        function deferImmediate(task: Closure, context?: any): ICancellable;
        function deferImmediate(task: Function, context?: any, args?: any[]): ICancellable;
        function runAfterDeferred(task: Closure): void;
        function defer(task: Closure, delay?: number): ICancellable;
        function defer<T>(task: Func<T>, delay?: number, payload?: T): ICancellable;
        function interval(task: Function, interval: number, count?: number): ICancellable;
        const Worker: WorkerConstructor;
    }
    namespace Uri {
        enum UriHostNameType {
            Basic = 0,
            DNS = 1,
            IPv4 = 2,
            IPv6 = 3,
            Unknown = 4,
        }
        module SchemeValue {
            type File = "file";
            type Gopher = "gopher";
            type FTP = "ftp";
            type HTTP = "http";
            type HTTPS = "https";
            type LDAP = "ldap";
            type MailTo = "mailto";
            type Pipe = "net.pipe";
            type TCP = "net.tcp";
            type NNTP = "nntp" | "news";
            type Telnet = "telnet";
            type UUID = "uuid";
            type Any = File | Gopher | FTP | HTTP | HTTPS | LDAP | MailTo | Pipe | TCP | NNTP | Telnet | UUID;
        }
        module Scheme {
            const File: SchemeValue.File;
            const FTP: SchemeValue.FTP;
            const GOPHER: SchemeValue.Gopher;
            const HTTP: SchemeValue.HTTP;
            const HTTPS: SchemeValue.HTTPS;
            const LDAP: SchemeValue.LDAP;
            const MAILTO: SchemeValue.MailTo;
            const PIPE: SchemeValue.Pipe;
            const TCP: SchemeValue.TCP;
            const NEWS: SchemeValue.NNTP;
            const NNTP: SchemeValue.NNTP;
            const TELNET: SchemeValue.Telnet;
            const UUID: SchemeValue.UUID;
            const All: ReadonlyArray<"file" | "gopher" | "ftp" | "http" | "https" | "ldap" | "mailto" | "net.pipe" | "net.tcp" | "nntp" | "news" | "telnet" | "uuid">;
            function isValid(scheme: string): scheme is SchemeValue.Any;
        }
        module Separator {
            const Query: string;
            const Entry: string;
            const KeyValue: string;
        }
        interface IUrn {
            scheme?: SchemeValue.Any | null;
            path?: string | null;
        }
        interface IUri extends IUrn {
            userInfo?: string | null;
            host?: string | null;
            port?: number | null;
            query?: string | null;
            fragment?: string | null;
        }
        class Uri implements IUri, IEquatable<IUri> {
            readonly scheme: SchemeValue.Any | null;
            readonly userInfo: string | null;
            readonly host: string | null;
            readonly port: number | null;
            readonly path: string | null;
            readonly query: string | null;
            readonly fragment: string | null;
            readonly queryParams: IMap<Primitive | Primitive[]>;
            constructor(scheme: SchemeValue.Any | null, userInfo: string | null, host: string | null, port: number | null, path: string | null, query?: QueryParam.Convertible, fragment?: string);
            equals(other: IUri): boolean;
            static from(uri: string | IUri | null | undefined, defaults?: IUri): Uri;
            static parse(url: string): IUri;
            static parse(url: string, throwIfInvalid: true): IUri;
            static parse(url: string, throwIfInvalid: boolean): IUri | null;
            static tryParse(url: string, out: (result: IUri) => void): boolean;
            static copyOf(map: IUri): IUri;
            copyTo(map: IUri): IUri;
            updateQuery(query: QueryParam.Convertible): Uri;
            protected getAbsoluteUri(): string;
            protected getAuthority(): string;
            protected getPathAndQuery(): string;
            absoluteUri: string;
            readonly authority: string | null;
            readonly pathAndQuery: string | null;
            readonly baseUri: string;
            readonly pathSegments: string[];
            toMap(): IUri;
            toString(): string;
            static toString(uri: IUri): string;
            static getAuthority(uri: IUri): string;
        }
        enum Fields {
            scheme = 0,
            userInfo = 1,
            host = 2,
            port = 3,
            path = 4,
            query = 5,
            fragment = 6,
        }
        module UriComponent {
            interface Formattable {
                toUriComponent(): string;
            }
            type Value = Primitive | Serialization.ISerializable | Formattable;
            interface Map extends IMap<Value | Value[]> {
            }
        }
        class QueryBuilder extends Collections.Dictionaries.OrderedStringKeyDictionary<UriComponent.Value | UriComponent.Value[]> {
            constructor(query: QueryParam.Convertible, decodeValues?: boolean);
            static init(query: QueryParam.Convertible, decodeValues?: boolean): QueryBuilder;
            importQuery(query: QueryParam.Convertible, decodeValues?: boolean): QueryBuilder;
            importFromString(values: string, deserialize?: boolean, decodeValues?: boolean): QueryBuilder;
            encode(prefixIfNotEmpty?: boolean): string;
            toString(): string;
        }
        module QueryParam {
            type Array = ArrayLike<StringKeyValuePair<UriComponent.Value | UriComponent.Value[]>>;
            type Enumerable = Collections.Enumeration.IEnumerable<StringKeyValuePair<UriComponent.Value | UriComponent.Value[]>>;
            type EnumerableOrArray = Collections.Enumeration.IEnumerableOrArray<StringKeyValuePair<UriComponent.Value | UriComponent.Value[]>>;
            type Convertible = string | UriComponent.Map | EnumerableOrArray;
        }
        function encode(values: UriComponent.Map | QueryParam.EnumerableOrArray, prefixIfNotEmpty?: boolean): string;
        function encodeValue(value: UriComponent.Value): string;
        function isUriComponentFormattable(instance: any): instance is UriComponent.Formattable;
        function parse(query: string, entryHandler: (key: string, value: Primitive) => void, deserialize?: boolean, decodeValues?: boolean): void;
        function parseToMap(query: string, deserialize?: boolean, decodeValues?: boolean): IMap<Primitive | Primitive[]>;
        function parseToArray(query: string, deserialize?: boolean, decodeValues?: boolean): IStringKeyValuePair<Primitive>[];
    }
    namespace Serialization {
        interface ISerializable {
            serialize(): string;
        }
        function toString(value: Primitive | ISerializable | undefined | null, defaultForUnknown?: string): string;
        function isSerializable(instance: any): instance is ISerializable;
        function toPrimitive(value: string, caseInsensitive?: boolean, unknownHandler?: (v: string) => string): Primitive | null | undefined;
    }
    namespace Text {
        module RegexOptions {
            type Global = "g";
            type IgnoreCase = "i";
            type MultiLine = "m";
            type Unicode = "u";
            type Sticky = "y";
            type IgnorePatternWhitespace = "w";
            type Literal = Global | IgnoreCase | MultiLine | Unicode | Sticky | IgnorePatternWhitespace;
            const IGNORE_CASE: IgnoreCase;
            const I: IgnoreCase;
            const GLOBAL: Global;
            const G: Global;
            const MULTI_LINE: MultiLine;
            const M: MultiLine;
            const UNICODE: Unicode;
            const U: Unicode;
            const STICKY: Sticky;
            const Y: Sticky;
            const IGNORE_PATTERN_WHITESPACE: IgnorePatternWhitespace;
            const W: IgnorePatternWhitespace;
        }
        class Regex {
            private readonly _re;
            private readonly _keys;
            constructor(pattern: string | RegExp, options?: RegexOptions.Literal | RegexOptions.Literal[], ...extra: RegexOptions.Literal[]);
            match(input: string, startIndex?: number): Match;
            matches(input: string): Match[];
            replace(input: string, replacement: Primitive, count?: number): string;
            replace(input: string, evaluator: SelectorWithIndex<Match, Primitive>, count?: number): string;
            isMatch(input: string): boolean;
            static isMatch(input: string, pattern: string, options?: RegexOptions.Literal[]): boolean;
            static replace(input: string, pattern: string, replacement: string, options?: RegexOptions.Literal[]): string;
            static replace(input: string, pattern: string, evaluator: SelectorWithIndex<Match, Primitive>, options?: RegexOptions.Literal[]): string;
        }
        class Capture {
            readonly value: string;
            readonly index: number;
            readonly length: number;
            constructor(value?: string, index?: number);
            freeze(): void;
        }
        class Group extends Capture {
            readonly success: boolean;
            constructor(value?: string, index?: number);
            static readonly Empty: Group;
        }
        class Match extends Group {
            readonly groups: Group[];
            readonly namedGroups: IMap<Group>;
            constructor(value?: string, index?: number, groups?: Group[], namedGroups?: IMap<Group>);
            freeze(): void;
            static readonly Empty: Match;
        }
        class RegexMatchEnumerator {
            private readonly _pattern;
            constructor(pattern: string | RegExp | Regex);
            matches(input: string): Collections.Enumeration.IEnumerator<Match>;
            static matches(input: string, pattern: string | RegExp | Regex): Collections.Enumeration.IEnumerator<Match>;
        }
        namespace Padding {
            function padStringLeft(source: string, minLength: number, pad?: string): string;
            function padStringRight(source: string, minLength: number, pad?: string): string;
            function padNumberLeft(source: number, minLength: number, pad?: string | number): string;
            function padNumberRight(source: number, minLength: number, pad?: string | number): string;
            function padLeft(source: string, minLength: number, pad?: string): string;
            function padLeft(source: number, minLength: number, pad?: string | number): string;
            function padRight(source: string, minLength: number, pad?: string): string;
            function padRight(source: number, minLength: number, pad?: string | number): string;
        }
        class StringBuilder implements Disposable.IDisposable {
            private _partArray;
            private _latest;
            constructor(...initial: any[]);
            private appendSingle(item);
            appendThese(items: any[]): StringBuilder;
            append(...items: any[]): StringBuilder;
            appendLine(...items: any[]): StringBuilder;
            appendLines(items: any[]): StringBuilder;
            readonly isEmpty: boolean;
            toString(): string;
            join(delimiter: string): string;
            clear(): void;
            dispose(): void;
        }
        namespace Encoding {
            class UTF8 {
                static GetBytes(text: string): ArrayBuffer;
                static GetString(buf: ArrayBuffer): string;
            }
            var Unicode: typeof UTF8;
        }
    }
    namespace Web {
        class HttpUtility {
            static UrlEncode(uri: string): string;
            static UrlDecode(enc: string): string;
        }
    }
    namespace Time {
        module Hours {
            const enum Per {
                Day = 24,
            }
        }
        module Minutes {
            const enum Per {
                Hour = 60,
                Day = 1440,
            }
        }
        module Seconds {
            const enum Per {
                Minute = 60,
                Hour = 3600,
                Day = 86400,
            }
        }
        module Milliseconds {
            const enum Per {
                Second = 1000,
                Minute = 60000,
                Hour = 3600000,
                Day = 86400000,
            }
        }
        module Ticks {
            const enum Per {
                Millisecond = 10000,
                Second = 10000000,
                Minute = 600000000,
                Hour = 36000000000,
                Day = 864000000000,
            }
        }
        module Gregorian {
            const enum Month {
                January = 0,
                February = 1,
                March = 2,
                April = 3,
                May = 4,
                June = 5,
                July = 6,
                August = 7,
                September = 8,
                October = 9,
                November = 10,
                December = 11,
            }
            const enum DayOfWeek {
                Sunday = 0,
                Monday = 1,
                Tuesday = 2,
                Wednesday = 3,
                Thursday = 4,
                Friday = 5,
                Saturday = 6,
            }
        }
        interface ICalendarDate {
            year: number;
            month: number;
            day: number;
        }
        interface IClockTime {
            hour: number;
            minute: number;
            second: number;
            millisecond: number;
            tick: number;
        }
        interface ITimeStamp extends ICalendarDate, IClockTime {
        }
        interface IDateTime {
            toJsDate(): Date;
        }
        interface ITimeQuantity {
            getTotalMilliseconds(): number;
            total: ITimeMeasurement;
        }
        interface ITimeMeasurement {
            ticks: number;
            milliseconds: number;
            seconds: number;
            minutes: number;
            hours: number;
            days: number;
        }
        enum TimeUnit {
            Ticks = 0,
            Milliseconds = 1,
            Seconds = 2,
            Minutes = 3,
            Hours = 4,
            Days = 5,
        }
        module TimeUnit {
            function toMilliseconds(value: number, units?: TimeUnit): number;
            function fromMilliseconds(ms: number, units: TimeUnit): number;
            function from(quantity: ITimeQuantity, unit: TimeUnit): number;
            function assertValid(unit: TimeUnit): true | never;
        }
        module DateTime {
            const enum Kind {
                Unspecified = 0,
                Local = 1,
                Utc = 2,
            }
        }
        class DateTime implements ICalendarDate, IDateTime, IEquatable<IDateTime>, IComparable<IDateTime> {
            private readonly _value;
            toJsDate(): Date;
            constructor();
            constructor(dateString: string, kind?: DateTime.Kind);
            constructor(milliseconds: number, kind?: DateTime.Kind);
            constructor(source: Date, kind?: DateTime.Kind);
            constructor(source: DateTime, kind?: DateTime.Kind);
            private readonly _kind;
            readonly kind: DateTime.Kind;
            readonly year: number;
            readonly month: Gregorian.Month;
            readonly calendarMonth: number;
            readonly calendar: ICalendarDate;
            readonly day: number;
            readonly dayIndex: number;
            readonly dayOfWeek: Gregorian.DayOfWeek;
            addMilliseconds(ms: number): DateTime;
            addSeconds(seconds: number): DateTime;
            addMinutes(minutes: number): DateTime;
            addHours(hours: number): DateTime;
            addDays(days: number): DateTime;
            addMonths(months: number): DateTime;
            addYears(years: number): DateTime;
            add(time: ITimeQuantity): DateTime;
            subtract(time: ITimeQuantity): DateTime;
            timePassedSince(previous: Date | DateTime): TimeSpan;
            readonly date: DateTime;
            private _time;
            readonly timeOfDay: ClockTime;
            toTimeStamp(): ITimeStamp;
            static readonly now: DateTime;
            readonly toUniversalTime: DateTime;
            equals(other: Date): boolean;
            equals(other: IDateTime, strict?: boolean): boolean;
            compareTo(other: IDateTime | Date): number;
            equivalent(other: IDateTime | Date): boolean;
            static readonly today: DateTime;
            static readonly tomorrow: DateTime;
            static between(first: Date | DateTime, last: Date | DateTime): TimeSpan;
            static isLeapYear(year: number): boolean;
            static daysInMonth(year: number, month: Gregorian.Month): number;
            static from(calendarDate: ICalendarDate): DateTime;
            static from(year: number, month: Gregorian.Month, day: number): DateTime;
            static fromCalendarDate(calendarDate: ICalendarDate): DateTime;
            static fromCalendarDate(year: number, month: number, day: number): DateTime;
        }
        class TimeQuantity implements IEquatable<ITimeQuantity>, IComparable<ITimeQuantity>, ITimeQuantity {
            protected _quantity: number;
            constructor(_quantity?: number);
            getTotalMilliseconds(): number;
            readonly direction: number;
            equals(other: ITimeQuantity): boolean;
            compareTo(other: ITimeQuantity): number;
            protected _total: Lazy<ITimeMeasurement>;
            protected _resetTotal(): void;
            readonly total: ITimeMeasurement;
            getTotal(units: TimeUnit): number;
        }
        class ClockTime extends TimeQuantity implements IClockTime {
            readonly days: number;
            readonly hour: number;
            readonly minute: number;
            readonly second: number;
            readonly millisecond: number;
            readonly tick: number;
            constructor(milliseconds: number);
            constructor(hours: number, minutes: number, seconds?: number, milliseconds?: number);
            static from(hours: number, minutes: number, seconds?: number, milliseconds?: number): ClockTime;
            static millisecondsFromTime(hours: number, minutes: number, seconds?: number, milliseconds?: number): number;
            toString(): string;
        }
        class TimeStamp implements ITimeStamp, IDateTime {
            readonly year: number;
            readonly month: Gregorian.Month;
            readonly day: number;
            readonly hour: number;
            readonly minute: number;
            readonly second: number;
            readonly millisecond: number;
            readonly tick: number;
            constructor(year: number, month: Gregorian.Month, day?: number, hour?: number, minute?: number, second?: number, millisecond?: number, tick?: number);
            toJsDate(): Date;
            static from(d: Date | IDateTime): TimeStamp;
        }
        class TimeSpan extends TimeQuantity implements ITimeMeasurement {
            readonly ticks: number;
            readonly milliseconds: number;
            readonly seconds: number;
            readonly minutes: number;
            readonly hours: number;
            readonly days: number;
            constructor(value: number, units?: TimeUnit);
            readonly total: TimeSpan;
            private _time;
            readonly time: ClockTime;
            add(other: ITimeQuantity): TimeSpan;
            addUnit(value: number, units?: TimeUnit): TimeSpan;
            static from(value: number, units: TimeUnit): TimeSpan;
            static fromDays(value: number): TimeSpan;
            static fromHours(value: number): TimeSpan;
            static fromMinutes(value: number): TimeSpan;
            static fromSeconds(value: number): TimeSpan;
            static fromMilliseconds(value: number): TimeSpan;
            static fromTicks(value: number): TimeSpan;
            static readonly zero: TimeSpan;
        }
    }
    namespace Timers {
        interface ITimer {
            isRunning: boolean;
            start(): void;
            stop(): void;
            reset(): void;
        }
    }
    namespace Diagnostics {
        import TimeSpan = Time.TimeSpan;
        class Stopwatch implements Timers.ITimer {
            static getTimestampMilliseconds(): number;
            private _elapsed;
            private _startTimeStamp;
            private _isRunning;
            readonly isRunning: boolean;
            constructor();
            static startNew(): Stopwatch;
            static measure(closure: () => void): Time.TimeSpan;
            start(): void;
            stop(): void;
            restart(): void;
            reset(): void;
            lap(): TimeSpan;
            readonly currentLapMilliseconds: number;
            readonly currentLap: TimeSpan;
            readonly elapsedMilliseconds: number;
            readonly elapsed: TimeSpan;
        }
    }
    module TypeValue {
        type Boolean = "boolean";
        type Number = "number";
        type String = "string";
        type Symbol = "symbol";
        type Object = "object";
        type Undefined = "undefined";
        type Function = "function";
        type Primitive = String | Number | Boolean;
        type Any = Primitive | Symbol | Undefined | Function;
    }
    type Primitive = string | number | boolean;
    module Char {
        function isWhiteSpace(ch: number): boolean;
        function isLetter(ch: number): boolean;
        function isLetterOrDigit(ch: number): boolean;
        function isDigit(ch: number): boolean;
        function isDigit(str: string, index: number): boolean;
    }
}
