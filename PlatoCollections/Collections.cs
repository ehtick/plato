﻿/*
    This is the standard library for Plato collection interfaces.
    All Plato collections are immutable, side-effect free, and thread-safe.
  
    Plato is inspired heavily by LINQ. Many of the LINQ extension methods 
    will implemented for the various types, as they makes sense.     
*/
namespace Plato;

//================================================================
// High Level interfaces for abstract concepts 
//================================================================

/// <summary>
/// A generator can generate infinite values. This is very similar to 
/// an IEnumerator in the C# standard library. Unlike IEnumerator it has 
/// no side-effects and is not mutable. IGenerator supports 
/// a number of LINQ operations on it directly.  
/// </summary>
public partial interface IGenerator<T> : ISequence<T>
{
    IGenerator<T> Next { get; }
    bool HasValue { get; }
    T Value { get; }     
}

/// <summary>
/// A sequence is roughly equivalent of IEnumerable in the C# standard library. 
/// It is a potentially infinite sequence of values, however
/// it is guaranteed to have no side effects and can be enumerated multiple times. 
/// </summary>
public partial interface ISequence<T>
{
    IGenerator<T> Generator { get; }
}

/// <summary>
/// An abstraction of the concept of a mathematical mapping. 
/// </summary>
public partial interface IMap<T1, T2>
{
    T2 this[T1 input] { get; }
}

/// <summary>
/// An immutable set. It tells us only whether membership exists or not.
/// A pure set is infinite and unordered, so we cannot extract
/// members from it. In such cases you will want to use a bag or dictionary. 
/// </summary>
public partial interface ISet<T>
{
    bool Contains(T item);
}

/// <summary>
/// An immutable array. It contains only a count and an indexer. 
/// Both are expected to return in O(1) time. 
/// An array is a specialization of a map (from the integer domain to any codomain)
/// and it can be trivially used as a sequence. 
/// </summary>
public partial interface IArray<T> 
    : IMap<int, T>, ISequence<T>
{
    int Count { get; }
}

//========================================================================================
// Interface for containers. 
//=========================================================================================

/// <summary>
/// Bags are unordered collections of things, with an unknown (but finite) quantity 
/// (until you convert to a sequence). 
/// Bags are known only to be empty or not. They can be explicitly converted into a sequence,
/// but it requires an ordering to be applied. Bags do not return membership information.
/// You cannot remove items from a bag. 
/// </summary>
public partial interface IBag<T>
{
    bool Empty { get; }
    ISortedSequence<T> ToSequence(Func<T, T, int> ordering);
}

/// <summary>
/// Containers are finite sets, bags that are of membership.
/// </summary>
public partial interface IContainer<T> 
    : IBag<T>, ISet<T>
{
}

/// <summary>
/// A classic linked list with a head and the rest of the list. 
/// </summary>
public partial interface IList<T> 
    : ISequence<T>, IBag<T>
{
    T Value { get; }
    IList<T>? Next { get; }
}

//======================================================================
// Sorted/Ordered Collections
//======================================================================

/// <summary>
/// Collections with a specific ordering store their ordering function. 
/// </summary>
public partial interface ISorted<T>
{
    Func<T, T, int> Ordering { get; }
}

/// <summary>
/// This is used by types that support the notion of being searchable in 
/// at least O(Log N) time. For example a sorted sequence or a binary tree. 
/// </summary>
public partial interface ISearchable<TValue, TKey>
{
    TKey FindKey(TValue item);
}

/// <summary>
/// An ordered array enables much faster finding of items.
/// </summary>
public partial interface ISortedArray<T> 
    : IArray<T>, ISorted<T>, ISearchable<T, int>
{
}

/// <summary>
/// An ordered bag has a predefined order that it maintains.
/// </summary>
public partial interface ISortedBag<T> 
    : IBag<T>, ISorted<T>
{
    ISortedSequence<T> ToSequence();
}

/// <summary>
/// An ordered container has a predefined order that it maintains.
/// Retrieving a sorted sequence from a sorted container is faster, 
/// but adding items to it is slower. 
/// </summary>
public partial interface ISortedContainer<T> 
    : IContainer<T>, ISorted<T>
{
}

/// <summary>
/// An ordered sequence is a sequence with a predefined ordering that it maintains. 
/// </summary>
public partial interface ISortedSequence<T> 
    : ISequence<T>, ISortedBag<T>
{
}

//======================================================================
// Tree structures
//======================================================================

/// <summary>
/// A binary tree.
/// </summary>
public partial interface ITree<T> : ISequence<T>
{
    T Value { get; }
    ITree<T>? Left { get; }
    ITree<T>? Right { get; }
}

/// <summary>
/// A tree where all values on the left sub-trees are always less than or equal to values on the right sub-tree
/// </summary>
public partial interface ISortedTree<T> 
    : ITree<T>, ISorted<T>, ISearchable<T, ISortedTree<T>>
{
    ISortedTree<T> Add(T item);
}

/// <summary>
/// A heap is a tree where each item is greater than the elements in all the sub-trees. 
/// </summary>
public partial interface IHeap<T> 
    : ITree<T>, ISorted<T>
{
    IHeap<T> Add(T item);
}

//================================================================
// Stack, Queue, Deques
//================================================================

public partial interface IStack<T> 
    : IBag<T>
{
    IStack<T> Pop(int n = 1);
    IStack<T> Push(ISequence<T> item);
    T Top { get; }
}

public partial interface IQueue<T> 
    : IBag<T>
{
    T Front { get; }
    IQueue<T> Dequeue(int n = 1);
    IQueue<T> Enqueue(ISequence<T> item);
}

public partial interface IDeque<T> 
    : IBag<T>
{
    T Front { get; }
    T Back { get; }
    IDeque<T> PushFront(ISequence<T> item);
    IDeque<T> PushEnd(ISequence<T> item);
    IDeque<T> PopFront(int n = 1);
    IDeque<T> PopEnd(int n = 1);
}

public partial interface IPriorityQueue<TKey, TValue> 
    : ISorted<TKey>, IStack<(TKey, TValue)>
{    
}

//================================================================
// Dictionary data types
//================================================================

/// <summary>
/// A dictionary data type is a mapping from key to values,
/// where the keys have an explicit ordering, and are finite.
/// </summary>
public partial interface IDictionary<TKey, TValue> 
    : IMap<TKey, TValue>, ISorted<TKey>, ISet<TKey>
{
    ISortedSequence<(TKey, TValue)> ToSequence();
}

/// <summary>
/// A dictionary data type that allows multiple items per key 
/// </summary>
public partial interface IMultiDictionary<TKey, TValue> 
    : IDictionary<TKey, ISequence<TValue>>
{
}

/// <summary>
/// A dictionary data type that allows multiple items per key, and can retrieve keys from values. 
/// </summary>
public partial interface IBiDictionary<TKey, TValue> 
    : IDictionary<TKey, TValue>
{
    IMultiDictionary<TValue, TKey> GetValueDictionary();
}

//====================================================
// Specialized Collections
//====================================================

/// <summary>
/// An interval is a special kind of set based on two ordered values. 
/// </summary>
public partial interface IInterval<T> : ISorted<T>, ISet<T>
{
    T From { get; }
    T To { get; }
}

/// <summary>
/// A subsequence is a sequence built from another sequence, starting from
/// a particular location and continuing for a set number of values.
/// </summary>
public partial interface ISubSequence<T> : ISequence<T>
{
    ISequence<T> Sequence { get; }
    int Index { get; }
    int Count { get; }
}

/// <summary>
/// A slice is a section of array, which itself is also an array. 
/// </summary>
public partial interface ISlice<T> : IArray<T>
{
    IArray<T> Array { get; }
    int Index { get; }
}

