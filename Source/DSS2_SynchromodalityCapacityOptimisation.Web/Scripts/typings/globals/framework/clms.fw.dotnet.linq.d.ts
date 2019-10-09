declare namespace System.Linq {
    import IEnumerable = Collections.Enumeration.IEnumerable;
    import ForEachEnumerable = Collections.Enumeration.ForEachEnumerable;
    import IEnumerator = Collections.Enumeration.IEnumerator;
    import IDisposable = Disposable.IDisposable;
    import DisposableBase = Disposable.DisposableBase;
    import IDictionary = Collections.Dictionaries.IDictionary;
    import InfiniteValueFactory = Collections.Enumeration.InfiniteValueFactory;
    const enum EnumerableAction {
        Break = 0,
        Return = 1,
        Skip = 2,
    }
    interface IInfiniteEnumerable<T> extends IEnumerable<T>, IDisposable {
        getEnumerator(): IEnumerator<T>;
        asEnumerable(): this;
        doAction(action: ActionWithIndex<T> | PredicateWithIndex<T> | SelectorWithIndex<T, number> | SelectorWithIndex<T, EnumerableAction>, initializer: Closure | null, isEndless: true, onComplete?: Action<number>): IInfiniteEnumerable<T>;
        doAction(action: ActionWithIndex<T> | PredicateWithIndex<T> | SelectorWithIndex<T, number> | SelectorWithIndex<T, EnumerableAction>, initializer?: Closure | null, isEndless?: boolean | null | undefined, onComplete?: Action<number>): ILinqEnumerable<T>;
        force(): void;
        skip(count: number): IInfiniteEnumerable<T>;
        take(count: number): IFiniteEnumerable<T>;
        elementAt(index: number): T;
        elementAtOrDefault(index: number): T | undefined;
        elementAtOrDefault(index: number, defaultValue: T): T;
        first(): T;
        firstOrDefault(): T | undefined;
        firstOrDefault(defaultValue: T): T;
        single(): T;
        singleOrDefault(): T | undefined;
        singleOrDefault(defaultValue: T): T;
        any(): boolean;
        isEmpty(): boolean;
        traverseDepthFirst(childrenSelector: (element: T) => ForEachEnumerable<T> | null | undefined): ILinqEnumerable<T>;
        traverseDepthFirst<TNode>(childrenSelector: (element: T | TNode) => ForEachEnumerable<TNode> | null | undefined): ILinqEnumerable<TNode>;
        traverseDepthFirst<TResult>(childrenSelector: (element: T) => ForEachEnumerable<T> | null | undefined, resultSelector: SelectorWithIndex<T, TResult>): ILinqEnumerable<TResult>;
        traverseDepthFirst<TNode, TResult>(childrenSelector: (element: T | TNode) => ForEachEnumerable<TNode> | null | undefined, resultSelector: SelectorWithIndex<T, TResult>): ILinqEnumerable<TResult>;
        flatten<TFlat>(): IInfiniteEnumerable<TFlat>;
        flatten(): IInfiniteEnumerable<any>;
        pairwise<TSelect>(selector: (prev: T, current: T) => TSelect): IInfiniteEnumerable<TSelect>;
        scan(func: (a: T, b: T) => T, seed?: T): this;
        select<TResult>(selector: SelectorWithIndex<T, TResult>): IInfiniteEnumerable<TResult>;
        selectMany<TResult>(collectionSelector: SelectorWithIndex<T, ForEachEnumerable<TResult> | null | undefined>): IInfiniteEnumerable<TResult>;
        selectMany<TElement, TResult>(collectionSelector: SelectorWithIndex<T, ForEachEnumerable<TElement> | null | undefined>, resultSelector: (collection: T, element: TElement) => TResult): IInfiniteEnumerable<TResult>;
        choose(): IInfiniteEnumerable<T>;
        choose<TResult>(selector?: Selector<T, TResult>): IInfiniteEnumerable<TResult>;
        where(predicate: PredicateWithIndex<T>): this;
        nonNull(): this;
        ofType<TType>(type: {
            new (...params: any[]): TType;
        }): IInfiniteEnumerable<TType>;
        except<TCompare>(second: ForEachEnumerable<T>, compareSelector?: Selector<T, TCompare>): this;
        distinct(compareSelector?: Selector<T, string | number | symbol>): this;
        distinctUntilChanged(compareSelector?: Selector<T, any>): this;
        defaultIfEmpty(defaultValue?: T): this;
        zip<TSecond, TResult>(second: ForEachEnumerable<TSecond>, resultSelector: (first: T, second: TSecond, index: number) => TResult): ILinqEnumerable<TResult>;
        zipMultiple<TSecond, TResult>(second: ArrayLike<ForEachEnumerable<TSecond>>, resultSelector: (first: T, second: TSecond, index: number) => TResult): ILinqEnumerable<TResult>;
        join<TInner, TKey, TResult>(inner: ForEachEnumerable<TInner>, outerKeySelector: Selector<T, TKey>, innerKeySelector: Selector<TInner, TKey>, resultSelector: (outer: T, inner: TInner) => TResult, compareSelector?: Selector<TKey, string | number | symbol>): ILinqEnumerable<TResult>;
        groupJoin<TInner, TKey, TResult, TCompare>(inner: ForEachEnumerable<TInner>, outerKeySelector: Selector<T, TKey>, innerKeySelector: Selector<TInner, TKey>, resultSelector: (outer: T, inner: TInner[] | null) => TResult, compareSelector?: Selector<TKey, TCompare>): ILinqEnumerable<TResult>;
        merge(enumerables: ArrayLike<ForEachEnumerable<T>>): this;
        concat(...enumerables: Array<ForEachEnumerable<T>>): this;
        union<TCompare>(second: ForEachEnumerable<T>, compareSelector?: Selector<T, TCompare>): this;
        insertAt(index: number, other: ForEachEnumerable<T>): this;
        alternateMultiple(sequence: ForEachEnumerable<T>): this;
        alternateSingle(value: T): this;
        alternate(...sequence: T[]): this;
        catchError(handler: (e: any) => void): this;
        finallyAction(action: Closure): this;
        buffer(size: number): IInfiniteEnumerable<T[]>;
        share(): this;
    }
    interface ILinqEnumerable<T> extends IInfiniteEnumerable<T> {
        skip(count: number): ILinqEnumerable<T>;
        skipWhile(predicate: PredicateWithIndex<T>): ILinqEnumerable<T>;
        takeWhile(predicate: PredicateWithIndex<T>): this;
        takeUntil(predicate: PredicateWithIndex<T>, includeUntilValue?: boolean): this;
        forEach(action: ActionWithIndex<T>, max?: number): number;
        forEach(action: PredicateWithIndex<T>, max?: number): number;
        toArray(predicate?: PredicateWithIndex<T>): T[];
        toList(predicate?: PredicateWithIndex<T>): System.Collections.List<T>;
        copyTo(target: T[], index?: number, count?: number): T[];
        toLookup<TKey, TValue>(keySelector: SelectorWithIndex<T, TKey>, elementSelector?: SelectorWithIndex<T, TValue>, compareSelector?: Selector<TKey, string | number | symbol>): ILookup<TKey, TValue>;
        toMap<TResult>(keySelector: Selector<T, string | number | symbol>, elementSelector: Selector<T, TResult>): IMap<TResult>;
        toDictionary<TKey, TValue>(keySelector: SelectorWithIndex<T, TKey> | Selector<T, TKey>, elementSelector: SelectorWithIndex<T, TValue> | Selector<T, TValue>, compareSelector?: Selector<TKey, string | number | symbol>): IDictionary<TKey, TValue>;
        toJoinedString(separator?: string, selector?: Selector<T, string>): string;
        takeExceptLast(count?: number): this;
        skipToLast(count: number): this;
        select<TResult>(selector: SelectorWithIndex<T, TResult>): ILinqEnumerable<TResult>;
        selectMany<TResult>(collectionSelector: SelectorWithIndex<T, ForEachEnumerable<TResult> | null | undefined>): ILinqEnumerable<TResult>;
        selectMany<TElement, TResult>(collectionSelector: SelectorWithIndex<T, ForEachEnumerable<TElement> | null | undefined>, resultSelector: (collection: T, element: TElement) => TResult): ILinqEnumerable<TResult>;
        choose(): ILinqEnumerable<T>;
        choose<TResult>(selector: SelectorWithIndex<T, TResult>): ILinqEnumerable<TResult>;
        reverse(): this;
        shuffle(): this;
        count(predicate?: PredicateWithIndex<T>): number;
        all(predicate: PredicateWithIndex<T>): boolean;
        every(predicate: PredicateWithIndex<T>): boolean;
        any(predicate?: PredicateWithIndex<T>): boolean;
        some(predicate?: PredicateWithIndex<T>): boolean;
        contains(value: T, compareSelector?: Selector<T, any>): boolean;
        indexOf(value: T, compareSelector?: SelectorWithIndex<T, any>): number;
        lastIndexOf(value: T, compareSelector?: SelectorWithIndex<T, any>): number;
        intersect(second: ForEachEnumerable<T>, compareSelector?: Selector<T, string | number | symbol>): ILinqEnumerable<T>;
        sequenceEqual(second: ForEachEnumerable<T>, equalityComparer?: EqualityComparison<T>): boolean;
        ofType<TType>(type: {
            new (...params: any[]): TType;
        }): ILinqEnumerable<TType>;
        traverseBreadthFirst(childrenSelector: (element: T) => ForEachEnumerable<T> | null | undefined): ILinqEnumerable<T>;
        traverseBreadthFirst<TNode>(childrenSelector: (element: T | TNode) => ForEachEnumerable<TNode> | null | undefined): ILinqEnumerable<TNode>;
        traverseBreadthFirst<TResult>(childrenSelector: (element: T) => ForEachEnumerable<T> | null | undefined, resultSelector: SelectorWithIndex<T, TResult>): ILinqEnumerable<TResult>;
        traverseBreadthFirst<TNode, TResult>(childrenSelector: (element: T | TNode) => ForEachEnumerable<TNode> | null | undefined, resultSelector: SelectorWithIndex<T, TResult>): ILinqEnumerable<TResult>;
        orderBy<TKey extends Comparable>(keySelector?: Selector<T, TKey>): IOrderedEnumerable<T>;
        orderUsing(comparison: Comparison<T>): IOrderedEnumerable<T>;
        orderUsingReversed(comparison: Comparison<T>): IOrderedEnumerable<T>;
        orderByDescending<TKey extends Comparable>(keySelector?: Selector<T, TKey>): IOrderedEnumerable<T>;
        buffer(size: number): ILinqEnumerable<T[]>;
        groupBy<TKey>(keySelector: SelectorWithIndex<T, TKey>): ILinqEnumerable<IGrouping<TKey, T>>;
        groupBy<TKey>(keySelector: SelectorWithIndex<T, TKey>, elementSelector: SelectorWithIndex<T, T>, compareSelector?: Selector<TKey, string | number | symbol>): ILinqEnumerable<IGrouping<TKey, T>>;
        groupBy<TKey, TElement>(keySelector: SelectorWithIndex<T, TKey>, elementSelector: SelectorWithIndex<T, TElement>, compareSelector?: Selector<TKey, string | number | symbol>): ILinqEnumerable<IGrouping<TKey, TElement>>;
        partitionBy<TKey>(keySelector: Selector<T, TKey>): ILinqEnumerable<IGrouping<TKey, T>>;
        partitionBy<TKey, TElement>(keySelector: Selector<T, TKey>, elementSelector?: Selector<T, TElement>, resultSelector?: (key: TKey, element: TElement[]) => IGrouping<TKey, TElement>, compareSelector?: Selector<TKey, any>): ILinqEnumerable<IGrouping<TKey, TElement>>;
        flatten<TFlat>(): IInfiniteEnumerable<TFlat>;
        flatten(): IInfiniteEnumerable<any>;
        pairwise<TSelect>(selector: (prev: T, current: T) => TSelect): ILinqEnumerable<TSelect>;
        aggregate(func: (previous: T, current: T, index?: number) => T, seed: T): T;
        aggregate(func: (previous: T, current: T, index?: number) => T, seed?: T): T | undefined;
        average(selector: Selector<T, number>): number;
        average(selector?: SelectorWithIndex<T, number>): number;
        max(): T | undefined;
        min(): T | undefined;
        maxBy(keySelector?: Selector<T, Primitive>): T | undefined;
        minBy(keySelector?: Selector<T, Primitive>): T | undefined;
        sum(selector?: SelectorWithIndex<T, number>): number;
        product(selector?: SelectorWithIndex<T, number>): number;
        quotient(selector?: SelectorWithIndex<T, number>): number;
        last(): T;
        lastOrDefault(): T | undefined;
        lastOrDefault(defaultValue: T): T;
        memoize(): this;
        throwWhenEmpty(): NotEmptyEnumerable<T>;
    }
    interface NotEmptyEnumerable<T> extends ILinqEnumerable<T> {
        aggregate(func: (previous: T | undefined, current: T) => T, seed?: T): T;
        max(): T;
        min(): T;
        maxBy(keySelector?: Selector<T, Primitive>): T;
        minBy(keySelector?: Selector<T, Primitive>): T;
    }
    interface IFiniteEnumerable<T> extends ILinqEnumerable<T> {
    }
    interface IGrouping<TKey, TElement> extends ILinqEnumerable<TElement> {
        key: TKey;
    }
    interface ILookup<TKey, TElement> extends IEnumerable<IGrouping<TKey, TElement>> {
        count: number;
        get(key: TKey): TElement[] | null;
        contains(key: TKey): boolean;
    }
    interface IOrderedEnumerable<T> extends IFiniteEnumerable<T> {
        thenBy(keySelector: (value: T) => any): IOrderedEnumerable<T>;
        thenByDescending(keySelector: (value: T) => any): IOrderedEnumerable<T>;
        thenUsing(comparison: Comparison<T>): IOrderedEnumerable<T>;
        thenUsingReversed(comparison: Comparison<T>): IOrderedEnumerable<T>;
    }
    class InfiniteLinqEnumerable<T> extends DisposableBase implements IInfiniteEnumerable<T> {
        protected _enumeratorFactory: () => IEnumerator<T>;
        constructor(_enumeratorFactory: () => IEnumerator<T>, finalizer?: Closure | null);
        protected _isEndless: boolean | undefined;
        readonly isEndless: boolean | undefined;
        getEnumerator(): IEnumerator<T>;
        protected _onDispose(): void;
        asEnumerable(): this;
        doAction(action: ActionWithIndex<T> | PredicateWithIndex<T> | SelectorWithIndex<T, number> | SelectorWithIndex<T, EnumerableAction>, initializer: Closure | null, isEndless: true, onComplete?: Action<number>): any;
        doAction(action: ActionWithIndex<T> | PredicateWithIndex<T> | SelectorWithIndex<T, number> | SelectorWithIndex<T, EnumerableAction>, initializer?: Closure | null, isEndless?: boolean | null | undefined, onComplete?: Action<number>): LinqEnumerable<T>;
        force(): void;
        skip(count: number): any;
        take(count: number): any;
        elementAt(index: number): T;
        elementAtOrDefault(index: number): T | undefined;
        elementAtOrDefault(index: number, defaultValue: T): T;
        first(): T;
        firstOrDefault(): T | undefined;
        firstOrDefault(defaultValue: T): T;
        single(): T;
        singleOrDefault(): T | undefined;
        singleOrDefault(defaultValue: T): T;
        any(): boolean;
        isEmpty(): boolean;
        traverseDepthFirst(childrenSelector: (element: T) => ForEachEnumerable<T> | null | undefined): any;
        traverseDepthFirst<TNode>(childrenSelector: (element: T | TNode) => ForEachEnumerable<TNode> | null | undefined): LinqEnumerable<TNode>;
        traverseDepthFirst<TResult>(childrenSelector: (element: T) => ForEachEnumerable<T> | null | undefined, resultSelector: SelectorWithIndex<T, TResult>): LinqEnumerable<TResult>;
        traverseDepthFirst<TNode, TResult>(childrenSelector: (element: T | TNode) => ForEachEnumerable<TNode> | null | undefined, resultSelector: SelectorWithIndex<T, TResult>): LinqEnumerable<TResult>;
        flatten<TFlat>(): any;
        flatten(): InfiniteLinqEnumerable<any>;
        pairwise<TSelect>(selector: (previous: T, current: T, index: number) => TSelect): any;
        scan(func: (previous: T, current: T, index: number) => T, seed?: T): this;
        select<TResult>(selector: SelectorWithIndex<T, TResult>): any;
        protected _selectMany<TElement, TResult>(collectionSelector: SelectorWithIndex<T, ForEachEnumerable<TElement> | null | undefined>, resultSelector?: (collection: T, element: TElement) => TResult): LinqEnumerable<TResult>;
        selectMany<TResult>(collectionSelector: SelectorWithIndex<T, ForEachEnumerable<TResult> | null | undefined>): any;
        selectMany<TElement, TResult>(collectionSelector: SelectorWithIndex<T, ForEachEnumerable<TElement> | null | undefined>, resultSelector: (collection: T, element: TElement) => TResult): InfiniteLinqEnumerable<TResult>;
        protected _filterSelected(selector?: SelectorWithIndex<T, T>, filter?: PredicateWithIndex<T>): LinqEnumerable<T>;
        protected _filterSelected<TResult>(selector: SelectorWithIndex<T, TResult>, filter?: PredicateWithIndex<TResult>): LinqEnumerable<TResult>;
        choose(): any;
        choose(): InfiniteLinqEnumerable<T>;
        choose<TResult>(selector?: Selector<T, TResult>): InfiniteLinqEnumerable<TResult>;
        where(predicate: PredicateWithIndex<T>): this;
        nonNull(): this;
        ofType<TType>(type: {
            new (...params: any[]): TType;
        }): any;
        ofType<TType>(type: {
            new (...params: any[]): TType;
        }): InfiniteLinqEnumerable<TType>;
        except(second: any, compareSelector?: any): any;
        distinct(compareSelector?: Selector<T, string | number | symbol>): this;
        distinctUntilChanged(compareSelector?: Selector<T, any>): this;
        defaultIfEmpty(defaultValue?: T): this;
        zip<TSecond, TResult>(second: ForEachEnumerable<TSecond>, resultSelector: (first: T, second: TSecond, index: number) => TResult): any;
        zipMultiple<TSecond, TResult>(second: ArrayLike<ForEachEnumerable<TSecond>>, resultSelector: (first: T, second: TSecond, index: number) => TResult): any;
        join<TInner, TKey, TResult>(inner: ForEachEnumerable<TInner>, outerKeySelector: Selector<T, TKey>, innerKeySelector: Selector<TInner, TKey>, resultSelector: (outer: T, inner: TInner) => TResult, compareSelector?: Selector<TKey, string | number | symbol>): any;
        groupJoin<TInner, TKey, TResult>(inner: any, outerKeySelector: Selector<T, TKey>, innerKeySelector: Selector<TInner, TKey>, resultSelector: (outer: T, inner: TInner[] | null) => TResult, compareSelector?: Selector<TKey, any>): any;
        merge(enumerables: ArrayLike<ForEachEnumerable<T>>): this;
        concat(...enumerables: Array<ForEachEnumerable<T>>): this;
        union(second: any, compareSelector?: Selector<T, any>): any;
        insertAt(index: number, other: ForEachEnumerable<T>): this;
        alternateMultiple(sequence: ForEachEnumerable<T>): this;
        alternateSingle(value: T): this;
        alternate(...sequence: T[]): this;
        catchError(handler: (e: any) => void): this;
        finallyAction(action: Closure): this;
        buffer(size: number): InfiniteLinqEnumerable<T[]>;
        share(): this;
    }
    class LinqEnumerable<T> extends InfiniteLinqEnumerable<T> implements ILinqEnumerable<T> {
        constructor(enumeratorFactory: () => IEnumerator<T>, finalizer?: Closure | null, isEndless?: boolean);
        asEnumerable(): this;
        skip(count: number): any;
        skipWhile(predicate: PredicateWithIndex<T>): any;
        takeWhile(predicate: PredicateWithIndex<T>): this;
        takeUntil(predicate: PredicateWithIndex<T>, includeUntilValue?: boolean): this;
        traverseBreadthFirst(childrenSelector: (element: T) => ForEachEnumerable<T> | null | undefined): LinqEnumerable<T>;
        traverseBreadthFirst<TNode>(childrenSelector: (element: T | TNode) => ForEachEnumerable<TNode> | null | undefined): LinqEnumerable<TNode>;
        traverseBreadthFirst<TResult>(childrenSelector: (element: T) => ForEachEnumerable<T> | null | undefined, resultSelector: SelectorWithIndex<T, TResult>): LinqEnumerable<TResult>;
        traverseBreadthFirst<TNode, TResult>(childrenSelector: (element: T | TNode) => ForEachEnumerable<TNode> | null | undefined, resultSelector: SelectorWithIndex<T, TResult>): LinqEnumerable<TResult>;
        forEach(action: ActionWithIndex<T>, max?: number): number;
        forEach(action: PredicateWithIndex<T>, max?: number): number;
        toArray(predicate?: PredicateWithIndex<T>): T[];
        toList(predicate?: PredicateWithIndex<T>): System.Collections.List<T>;
        copyTo(target: T[], index?: number, count?: number): T[];
        toLookup<TKey, TValue>(keySelector: SelectorWithIndex<T, TKey>, elementSelector?: SelectorWithIndex<T, TValue>, compareSelector?: Selector<TKey, string | number | symbol>): ILookup<TKey, TValue>;
        toMap<TResult>(keySelector: SelectorWithIndex<T, string | number | symbol>, elementSelector: SelectorWithIndex<T, TResult>): IMap<TResult>;
        toDictionary<TKey, TValue>(keySelector: SelectorWithIndex<T, TKey>, elementSelector: SelectorWithIndex<T, TValue>, compareSelector?: Selector<TKey, string | number | symbol>): IDictionary<TKey, TValue>;
        toJoinedString(separator?: string, selector?: Selector<T, string>): string;
        takeExceptLast(count?: number): this;
        skipToLast(count: number): this;
        select<TResult>(selector: SelectorWithIndex<T, TResult>): LinqEnumerable<TResult>;
        selectMany<TResult>(collectionSelector: SelectorWithIndex<T, ForEachEnumerable<TResult> | null | undefined>): LinqEnumerable<TResult>;
        selectMany<TElement, TResult>(collectionSelector: SelectorWithIndex<T, ForEachEnumerable<TElement> | null | undefined>, resultSelector: (collection: T, element: TElement) => TResult): LinqEnumerable<TResult>;
        choose(): LinqEnumerable<T>;
        choose<TResult>(selector: SelectorWithIndex<T, TResult>): LinqEnumerable<TResult>;
        reverse(): this;
        shuffle(): this;
        count(predicate?: PredicateWithIndex<T>): number;
        all(predicate: PredicateWithIndex<T>): boolean;
        every(predicate: PredicateWithIndex<T>): boolean;
        any(predicate?: PredicateWithIndex<T>): boolean;
        some(predicate?: PredicateWithIndex<T>): boolean;
        contains(value: T, compareSelector?: Selector<T, any>): boolean;
        indexOf(value: T, compareSelector?: SelectorWithIndex<T, any>): number;
        lastIndexOf(value: T, compareSelector?: SelectorWithIndex<T, any>): number;
        intersect(second: ForEachEnumerable<T>, compareSelector?: Selector<T, string | number | symbol>): this;
        sequenceEqual(second: ForEachEnumerable<T>, equalityComparer?: EqualityComparison<T>): boolean;
        ofType<TType>(type: {
            new (...params: any[]): TType;
        }): LinqEnumerable<TType>;
        orderBy<TKey extends Comparable>(keySelector?: Selector<T, TKey>): IOrderedEnumerable<T>;
        orderUsing(comparison: Comparison<T>): IOrderedEnumerable<T>;
        orderUsingReversed(comparison: Comparison<T>): IOrderedEnumerable<T>;
        orderByDescending<TKey extends Comparable>(keySelector?: Selector<T, TKey>): IOrderedEnumerable<T>;
        buffer(size: number): LinqEnumerable<T[]>;
        groupBy<TKey>(keySelector: SelectorWithIndex<T, TKey>): LinqEnumerable<IGrouping<TKey, T>>;
        groupBy<TKey>(keySelector: SelectorWithIndex<T, TKey>, elementSelector: SelectorWithIndex<T, T>, compareSelector?: Selector<TKey, string | number | symbol>): LinqEnumerable<IGrouping<TKey, T>>;
        groupBy<TKey, TElement>(keySelector: SelectorWithIndex<T, TKey>, elementSelector: SelectorWithIndex<T, TElement>, compareSelector?: Selector<TKey, string | number | symbol>): LinqEnumerable<IGrouping<TKey, TElement>>;
        partitionBy<TKey>(keySelector: Selector<T, TKey>): LinqEnumerable<IGrouping<TKey, T>>;
        partitionBy<TKey, TElement>(keySelector: Selector<T, TKey>, elementSelector?: Selector<T, TElement>, resultSelector?: (key: TKey, element: TElement[]) => IGrouping<TKey, TElement>, compareSelector?: Selector<TKey, any>): LinqEnumerable<IGrouping<TKey, TElement>>;
        flatten<TFlat>(): LinqEnumerable<TFlat>;
        flatten(): LinqEnumerable<any>;
        pairwise<TSelect>(selector: (previous: T, current: T, index: number) => TSelect): LinqEnumerable<TSelect>;
        aggregate(func: (previous: T, current: T, index: number) => T, seed: T): T;
        aggregate(func: (previous: T, current: T, index: number) => T, seed?: T): T | undefined;
        average(selector?: SelectorWithIndex<T, number>): number;
        max(): T | undefined;
        min(): T | undefined;
        maxBy(keySelector?: Selector<T, Primitive>): T | undefined;
        minBy(keySelector?: Selector<T, Primitive>): T | undefined;
        sum(selector?: SelectorWithIndex<T, number>): number;
        product(selector?: SelectorWithIndex<T, number>): number;
        quotient(selector?: SelectorWithIndex<T, number>): number;
        last(): T;
        lastOrDefault(): T | undefined;
        lastOrDefault(defaultValue: T): T;
        memoize(): this;
        throwWhenEmpty(): NotEmptyEnumerable<T>;
    }
    class FiniteEnumerable<T> extends LinqEnumerable<T> implements IFiniteEnumerable<T> {
        constructor(enumeratorFactory: () => IEnumerator<T>, finalizer?: Closure);
    }
    function Enumerable<T>(source: InfiniteValueFactory<T>): InfiniteLinqEnumerable<T>;
    function Enumerable<T>(source: ForEachEnumerable<T>, ...additional: Array<ForEachEnumerable<T>>): LinqEnumerable<T>;
    module Enumerable {
        function from<T>(source: InfiniteValueFactory<T>): InfiniteLinqEnumerable<T>;
        function from<T>(source: ForEachEnumerable<T>, ...additional: Array<ForEachEnumerable<T>>): LinqEnumerable<T>;
        function fromAny<T>(source: any, defaultEnumerable?: LinqEnumerable<T>): LinqEnumerable<T> | LinqEnumerable<T> | InfiniteLinqEnumerable<T> | undefined;
        function fromThese<T>(sources: ForEachEnumerable<T>[]): LinqEnumerable<T>;
        function fromOrEmpty<T>(source: ForEachEnumerable<T>): LinqEnumerable<T>;
        function toArray<T>(source: ForEachEnumerable<T>): T[];
        function toList<T>(source: ForEachEnumerable<T>): System.Collections.List<T>;
        function _choice<T>(values: T[]): InfiniteLinqEnumerable<T>;
        function choice<T>(values: ArrayLike<T>): InfiniteLinqEnumerable<T>;
        function chooseFrom<T>(arg: T, ...args: T[]): InfiniteLinqEnumerable<T>;
        function cycle<T>(values: ArrayLike<T>): InfiniteLinqEnumerable<T>;
        function cycleThrough<T>(arg: T, ...args: T[]): InfiniteLinqEnumerable<T>;
        function empty<T>(): FiniteEnumerable<T>;
        function repeat<T>(element: T): InfiniteLinqEnumerable<T>;
        function repeat<T>(element: T, count: number): FiniteEnumerable<T>;
        function repeatWithFinalize<T>(initializer: () => T, finalizer: Closure): InfiniteLinqEnumerable<T>;
        function repeatWithFinalize<T>(initializer: () => T, finalizer?: Action<T>): InfiniteLinqEnumerable<T>;
        function make<T>(element: T): FiniteEnumerable<T>;
        function range(start: number, count: number, step?: number): FiniteEnumerable<number>;
        function rangeDown(start: number, count: number, step?: number): FiniteEnumerable<number>;
        function toInfinity(start?: number, step?: number): InfiniteLinqEnumerable<number>;
        function toNegativeInfinity(start?: number, step?: number): InfiniteLinqEnumerable<number>;
        function rangeTo(start: number, to: number, step?: number): FiniteEnumerable<number>;
        function matches(input: string, pattern: any, flags?: string): FiniteEnumerable<RegExpExecArray>;
        function generate<T>(factory: (index: number) => T): InfiniteLinqEnumerable<T>;
        function unfold<T>(seed: T, valueFactory: SelectorWithIndex<T, T>, skipSeed?: Boolean): InfiniteLinqEnumerable<T>;
        function forEach<T>(e: ForEachEnumerable<T>, action: ActionWithIndex<T>, max?: number): number;
        function forEach<T>(e: ForEachEnumerable<T>, action: PredicateWithIndex<T>, max?: number): number;
        function map<T, TResult>(enumerable: ForEachEnumerable<T>, selector: SelectorWithIndex<T, TResult>): TResult[];
        function max(values: FiniteEnumerable<number>): number;
        function min(values: FiniteEnumerable<number>): number;
        function weave<T>(enumerables: ForEachEnumerable<ForEachEnumerable<T>>): LinqEnumerable<T>;
    }
}
