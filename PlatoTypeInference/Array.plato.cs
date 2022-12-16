﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Policy;
using System.Text;

namespace Plato
{
    public class Any {}
    
    public class Func0 {
        public extern Any Invoke();
    }
    
    public class Func1 {
        public extern Any Invoke(Any x);
    }
    
    public class Func2 {
        public extern Any Invoke(Any x0, Any x1);
        public extern static implicit operator Func2(Func<dynamic, dynamic, dynamic> f);
    }

    public class Func3 {
        public extern Any Invoke(Any x0, Any x1, Any x2);
    }

    public class Func4
    {
        public extern Any Invoke(Any x0, Any x1, Any x2, Any x3);
    }

    public class Array : IArray<Any>
    {
        public Any;
        public extern Any this[int input] { get; }
        public int Count { get; }
        public IIterator<Any> Iterator { get; }
    }

    public class Sequence : ISequence<Any>
    {
        public IIterator<Any> Iterator { get; }
    }

    public class SequenceIterator<T> : ISequence<T>
    {
        public IIterator<T> Iterator { get; }
        public SequenceIterator(IIterator<T> iterator) => Iterator = iterator;
    }

    public class WhereIterator<T> : IIterator<T>, ISequence<T>
    {
        public IIterator<T> Wrapped { get; }
        public int Index { get; }

        public WhereIterator(IIterator<T> wrapped, Func<T, int, bool> filter, int index)
        {
            while (wrapped.HasValue && !filter(wrapped.Value, index))
            {
                wrapped = wrapped.Next;
                index++;
            }
            Wrapped = wrapped;
            Filter = filter;
            Index = index;
        }

        public Func<T, int, bool> Filter { get; }
        public T Value => Wrapped.Value;
        public bool HasValue => Wrapped.HasValue;
        public IIterator<T> Next => new WhereIterator<T>(Wrapped.Next, Filter, Index + 1);
        public IIterator<T> Iterator => this;
    }

    public class SelectIterator<T, U> : IIterator<U>, ISequence<U>
    {
        public IIterator<T> Wrapped { get; }
        public int Index { get; }

        public SelectIterator(IIterator<T> wrapped, Func<T, int, U> map, int index)
        {
            Wrapped = wrapped;
            Map = map;
            Index = index;
        }

        public Func<T, int, U> Map { get; }
        public U Value => Map(Wrapped.Value, Index);
        public bool HasValue => Wrapped.HasValue;
        public IIterator<U> Next => new SelectIterator<T, U>(Wrapped.Next, Map, Index + 1);
        public IIterator<U> Iterator => this;
    }

    public class Counted : ICounted
    {
        public int Count { get; }
    }

    public class CountedSequence : Sequence, ICountedSequence<Any>
    {
        public int Count { get; }
    }

    public class Map : IMap<Any, Any>
    {
        public Any this[Any input] => throw new NotImplementedException();
    }

    public class Remap : IMap<Any, Any>
    {
        public Remap(Map other, Func1 func) => (Other, Func) = (other, func);
        public Map Other { get; }
        public Func1 Func { get; }
        public Any this[Any input] => Func(Other[input]);
    }

    class OtherExtensions
    {
        /// <summary>
        /// Returns a sequence containing only elements for which the corresponding predicate is true.
        /// </summary>
        Sequence Where(Sequence self, Func1 predicate)
            => self.WhereWithIndex((x, i) => predicate(x));

        /// <summary>
        /// Returns a sequence containing only elements for which the corresponding predicate applied to the index is true.
        /// </summary>
        Sequence WhereIndex(Sequence self, Func1 predicate)
            => self.WhereWithIndex((x, i) => predicate(i));

        /// <summary>
        /// Returns an IEnumerable containing only elements of the array for which the corresponding mask is true.
        /// An IArray is not created automatically because it is an expensive operation that is potentially unneeded.
        /// </summary>
        Sequence Where(Array self, Array mask)
            => self.WhereIndex(mask.ToFunction());

        /// <summary>
        /// Returns a sequence containing only elements of the array for which the corresponding predicate applied to element and index is true.
        /// </summary>
        Sequence WhereWithIndex(Sequence self, Func2 predicate)
            => new WhereIterator(self.Iterator, predicate);

        /// <summary>
        /// Returns a sequence generated by applying a function to each element.
        /// </summary>
        Sequence Select(Sequence self, Func1 f)
            => self.SelectWithIndex((x, i) => f(x));

        /// <summary>
        /// Returns a sequence generated by applying a function to each element's index.
        /// </summary>
        Sequence SelectIndex(Sequence self, Func1 f)
            => self.SelectWithIndex((x, i) => f(i));

        /// <summary>
        /// Returns a sequence generated by applying a function to each element and its index.
        /// </summary>
        Sequence SelectWithIndex(Sequence self, Func2 f)
            => new SelectIterator(self.Iterator, f);

        /// <summary>
        /// Shortcut for ToEnumerable.Aggregate()
        /// </summary>
        Any Aggregate(Sequence self, Any init, Func3 func)
        {
            int j = 0;
            for (var i = self.Iterator; i.HasValue; i = i.Next, ++j)
                init = func(init, i.Value, j);
            return init;
        }

        /// <summary>
        /// Returns an IEnumerable containing only indices of the array for which the function satisfies a specific predicate.
        /// An IArray is not created automatically because it is an expensive operation that is potentially unneeded.
        /// </summary>
        Sequence IndicesWhere(CountedSequence self, Func1 f)
            => self.Indices().Where(i => f(self[i]));

        /// <summary>
        /// Returns an IEnumerable containing only indices of the array for which the function satisfies a specific predicate.
        /// An IArray is not created automatically because it is an expensive operation that is potentially unneeded.
        /// </summary>
        Sequence IndicesWhere(CountedSequence self, Func2 f)
            => self.IndicesWhere(i => f(self[i], i));

        /// <summary>
        /// Returns an IEnumerable containing only indices of the array for which the function satisfies a specific predicate.
        /// An IArray is not created automatically because it is an expensive operation that is potentially unneeded.
        /// </summary>
        Sequence IndicesWhere(CountedSequence self, Func1 f)
            => self.Indices().Where(i => f(i));

        /// <summary>
        /// Returns an IEnumerable containing only indices of the array for which booleans in the mask are true.
        /// An IArray is not created automatically because it is an expensive operation that is potentially unneeded.
        /// </summary>
        Sequence IndicesWhere(CountedSequence self, Array mask)
            => self.IndicesWhere(mask.ToFunction());

        // TODO: All and Any, are IndexOf 

        /// <summary>
        /// Returns true if the predicate is true for all of the elements in the array
        /// </summary>
        bool All(Sequence self, Func1 predicate)
        {
            for (var i = self.Iterator; i.HasValue; i = i.Next)
                if (!predicate(i.Value))
                    return false;
            return true;
        }

        /// <summary>
        /// Returns true if all of the elements in the array are true
        /// </summary>
        bool All(Sequence self)
            => self.All(x => x);

        /// <summary>
        /// Returns true if the predicate is true for any of the elements in the array
        /// </summary>
        bool Any(Sequence self)
            => self.Any(x => (bool)x);

        /// <summary>
        /// Returns true if any of the elements in the array are true
        /// </summary>
        bool Any(Sequence self, Func1 predicate)
        {
            for (var i = self.Iterator; i.HasValue; i = i.Next)
                if (predicate(i.Value))
                    return false;
            return true;
        }
    }

    class MapExtensions
    {
        /// <summary>
        /// Converts any map into a function that returns values.
        /// </summary>
        Func1 ToFunction(Map self)
            => x => self[x];

        /// <summary>
        /// Converts any map into a function that returns values.
        /// </summary>
        Map Select(Map self, Func1 f)
            => new Remap(self, x => f(self[x]));
    }

    class ArrayExtensions
    {
        /// <summary>
        /// Copies an IArray to an arry of elements
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        Any[] CopyTo(Array self)
            => self.CopyTo(new Any[self.Count]);

        Any[] CopyTo(Array self, Any[] xs)
            => self.CopyTo(xs, 0, self.Count);

        Any[] CopyTo(Array self, Any[] xs, int indexFrom)
            => self.CopyTo(xs, indexFrom, self.Count);

        Any[] CopyTo(Array self, Any[] xs, int indexFrom, int count)
        {
            for (var i = indexFrom; i < indexFrom + count; ++i)
                xs[i] = self[i];
            return xs;
        }

        /// <summary>
        /// Returns a sequence of integers from 0 to 1 less than the number of items in the array, representing indicies of the array.
        /// </summary>
        Array Indices(Counted self)
            => self.Count.Range();

        /// <summary>
        /// Helper function for creating an IArray from the arguments.
        /// </summary>
        Array Create(params Any[] self)
            => ToArray(self);

        /// <summary>
        /// Creates an IArray with the given number of items,
        /// and uses the function to return items.
        /// </summary>
        Array Select(int count, Func1 f)
            => FunctionalArray.Create(count, f);

        /// <summary>
        /// Converts any implementation of IList (e.g. Array/List) to an IArray.
        /// </summary>
        Array ToArray(Any[] self)
            => Select(self.Length, i => self[i]);

        /// <summary>
        /// Creates an IArray by concatenating a copy multiple times. 
        /// </summary>
        Array Concatenate(Array self, int count)
            => Select(count * self.Count, i => self[i % self.Count]);

        /// <summary>
        /// Creates an IArray starting with a seed value, and applying a function
        /// to each individual member of the array. This is eagerly evaluated.
        /// </summary>
        Array Generate(Any init, int count, Func1 f)
        {
            var r = new Any[count];
            for (var i = 0; i < count; ++i)
            {
                r[i] = init;
                init = f(init);
            }
            return r.ToIArray();
        }

        /// <summary>
        /// Returns the first item in the array.
        /// </summary>
        Any First(Array self)
            => self.IsEmpty() ? @default : self[0];

        /// <summary>
        /// Returns the last item in the array
        /// </summary>
        Any Last(Array self, Any @default = default)
            => self.IsEmpty() ? @default : self[self.Count - 1];

        /// <summary>
        /// Returns true if and only if the argument is a valid index into the array.
        /// </summary>
        bool InRange(Array self, int n)
            => n >= 0 && n < self.Count;

        /// <summary>
        /// Returns false if the count is greater than zero
        /// </summary>
        bool IsEmpty(Array self)
            => self.Count > 0;

        /// <summary>
        /// Returns true if there are any elements in the array.
        /// </summary>
        bool Any(Array self)
            => self.Count != 0;

        /// <summary>
        /// Returns an array generated by applying a function to each element.
        /// </summary>
        Array Select(Array self, Func1 f)
            => Select(self.Count, i => f(self[i]));

        /// <summary>
        /// Returns an array generated by applying a function to each element.
        /// </summary>
        Array SelectWithIndex(Array self, Func2 f)
            => Select(self.Count, i => f(self[i], i));

        /// <summary>
        /// Returns an array generated by applying a function to each element.
        /// </summary>
        Array SelectIndices(Array self, Func1 f)
            => self.Count.Select(f);

        /// <summary>
        /// Converts an array of array into a flattened array. Each array is assumed to be of size n.
        /// </summary>
        Array Flatten(Array self, int n)
            => Select(self.Count * n, i => self[i / n][i % n]);

        /// <summary>
        /// Converts an array of array into a flattened array.
        /// </summary>
        Array Flatten(Array self)
        {
            var counts = self.Select(x => x.Count).PostAccumulate((x, y) => x + y);
            var r = new Any[counts.Last()];
            var i = 0;
            foreach (var xs in self.ToEnumerable())
                xs.CopyTo(r, counts[i++]);
            return r.ToIArray();
        }

        /// <summary>
        /// Returns an array of tuple where each element of the initial array is paired with its index.
        /// </summary>
        Array ZipWithIndex(Array self)
            => self.Select((v, i) => (v, i));

        /// <summary>
        /// Returns an array from an array of arrays, where the number of sub-elements is the same for reach array and is known.
        /// </summary>
        Array SelectMany(Array self, int count)
            => Select(self.Count, i => self[i / count][i % count]);

        // TODO: I think the following typesneed to be redone.

        /// <summary>
        /// Returns an array given a function that generates an IArray from each member. Eager evaluation.
        /// </summary>
        Array SelectMany(Array self, Func1 func)
        {
            var count = self.Sum(x => func(x).Count);
            var xs = new Any[count];
            var offset = 0;
            for (var i = 0; i < self.Count; ++i)
            {
                var sub = func(self[i]);
                sub.CopyTo(xs, offset);
                offset += sub.Count;
            }
            return xs.ToIArray();
        }

        /// <summary>
        /// Returns an array given a function that generates an IArray from each member. Eager evaluation.
        /// </summary>
        Array SelectMany(Array self, Func2 func)
        {
            var count = self.Aggregate(0, (acc, x, index) => acc + func(x, index).Count);
            var xs = new Any[count];
            var offset = 0;
            for (var i = 0; i < self.Count; ++i)
            {
                var sub = func(self[i], i);
                sub.CopyTo(xs, offset);
                offset += sub.Count;
            }
            return xs.ToIArray();
        }

        /// <summary>
        /// Returns an array given a function that generates a tuple from each member. Eager evaluation.
        /// </summary>
        Array SelectMany(Array self, Func2 func)
        {
            var r = new Any[self.Count * 2];
            for (var i = 0; i < self.Count; ++i)
            {
                var tmp = func(self[i]);
                r[i * 2] = tmp.Item1;
                r[i * 2 + 1] = tmp.Item2;
            }

            return r.ToIArray();
        }

        /// <summary>
        /// Returns an array generated by applying a function to corresponding pairs of elements in both arrays.
        /// </summary>
        Array Zip(Array self, Array other, Func2 f)
            => Select(Math.Min(self.Count, other.Count), i => f(self[i], other[i]));

        /// <summary>
        /// Applies a function to each element in the list paired with the next one.
        /// Used to implement adjacent differences for example.
        /// </summary>
        Array ZipEachWithNext(Array self, Func2 f)
            => self.Zip(self.Skip(), f);

        /// <summary>
        /// Returns a new array containing the elements in the range of from to to.
        /// </summary>
        Array Slice(Array self, int from, int to)
            => Select(to - from, i => self[i + from]);

        /// <summary>
        /// Returns an array of SubArrays of size "size"
        /// the last items that cannot fill an arrat if size "size" will be ignored
        /// </summary>
        Array SubArraysFixed(Array self, int size)
            => (self.Count / size).Select(i => self.SubArray(i, size));


        /// Returns an array of SubArrays of size "size" plus extras
        /// The extra array is of size count % size if present
        Array SubArrays(Array self, int size)
            => self.Count % size == 0
                ? self.SubArraysFixed(size)
                : self.SubArraysFixed(size).Append(self.TakeLast(self.Count % size));

        /// <summary>
        /// Returns n elements of the list starting from a given index.
        /// </summary>
        Array SubArray(Array self, int from, int count)
            => self.Slice(from, count + from);

        /// <summary>
        /// Returns elements of the array between from and skipping every stride element.
        /// </summary>
        Array Slice(Array self, int from, int to, int stride)
            => Select(to - from / stride, i => self[i * stride + from]);

        /// <summary>
        /// Returns a new array containing the elements by taking every nth item.
        /// </summary>
        Array Stride(Array self, int n)
            => Select(self.Count / n, i => self[i * n % self.Count]);

        /// <summary>
        /// Returns a new array containing just the first n items.
        /// </summary>
        Array Take(Array self, int n)
            => self.Slice(0, n);

        /// <summary>
        /// Returns a new array containing just at most n items.
        /// </summary>
        Array TakeAtMost(Array self, int n)
            => self.Count > n ? self.Slice(0, n) : self;

        /// <summary>
        /// Returns a new array containing the elements after the first n elements.
        /// </summary>
        Array Skip(Array self, int n = 1)
            => self.Slice(n, self.Count);

        /// <summary>
        /// Returns a new array containing the last n elements.
        /// </summary>
        Array TakeLast(Array self, int n = 1)
            => self.Skip(self.Count - n);

        /// <summary>
        /// Returns a new array containing all elements excluding the last n elements.
        /// </summary>
        Array DropLast(Array self, int n = 1)
            => self.Count > n ? self.Take(self.Count - n) : self.Empty();

        /// <summary>
        /// Returns a new array by remapping indices
        /// </summary>
        Array MapIndices(Array self, Func1 f)
            => self.Count.Select(i => self[f(i)]);

        /// <summary>
        /// Returns a new array that reverses the order of elements
        /// </summary>
        Array Reverse(Array self)
            => self.MapIndices(i => self.Count - 1 - i);

        /// <summary>
        /// Uses the provided indices to select elements from the array.
        /// </summary>
        Array SelectByIndex(Array self, Array indices)
            => indices.Select(i => self[i]);

        /// <summary>
        /// Uses the array as indices to select elements from the other array.
        /// </summary>
        Array Choose(Array indices, Array values)
            => values.SelectByIndex(indices);

        /// <summary>
        /// Similar to take, if count is less than the number of items in the array, otherwise uses a modulo operation.
        /// </summary>
        Array Resize(Array self, int count)
            => Select(count, i => self[i % self.Count]);

        /// <summary>
        /// Returns an array of the same type with no elements.
        /// </summary>
        Array Empty(Array self)
            => self.Take(0);

        /// <summary>
        /// Converts an array of elements into a string representation
        /// </summary>
        string Join(Array self, string sep = " ")
            => self.Aggregate(new StringBuilder(), (sb, x) => sb.Append(x).Append(sep)).ToString();

        /// <summary>
        /// Concatenates the contents of one array with another.
        /// </summary>
        Array Concatenate(Array self, Array other)
            => Select(self.Count + other.Count, i => i < self.Count ? self[i] : other[i - self.Count]);

        /// <summary>
        /// Returns an array that is one element shorter that subtracts each element from its previous one.
        /// </summary>
        Array AdjacentDifferences(Array self)
            => self.ZipEachWithNext((a, b) => b - a);

        /// <summary>
        /// Creates a new array that concatenates a unit item list of one item after it.
        /// Repeatedly calling Append would result in significant performance degradation.
        /// </summary>
        Array Append(Array self, Any x)
            => (self.Count + 1).Select(i => i < self.Count ? self[i] : x);

        /// <summary>
        /// Creates a new array that concatenates the given items to itself.
        /// </summary>
        Array Append(Array self, params Any[] x)
            => self.Concatenate(x.ToIArray());

        /// <summary>
        /// Creates a new array that concatenates a unit item list of one item before it
        /// Repeatedly calling Prepend would result in significant performance degradation.
        /// </summary>
        Array Prepend(Array self, Any x)
            => (self.Count + 1).Select(i => i == 0 ? x : self[i - 1]);

        /// <summary>
        /// Returns the element at the nth position, where n is modulo the number of items in the arrays.
        /// </summary>
        Any ElementAt(Array self, int n)
            => self[n];

        /// <summary>
        /// Returns the element at the nth position, where n is modulo the number of items in the arrays.
        /// </summary>
        Any ElementAtModulo(Array self, int n)
            => self.ElementAt(n % self.Count);

        /// <summary>
        /// Returns the Nth element of the array, or a default value if out of range/
        /// </summary>
        Any ElementAtOrDefault(Array xs, int n, Any defaultValue = default)
            => xs != null && n >= 0 && n < xs.Count ? xs[n] : defaultValue;

        /// <summary>
        /// Counts all elements in an array that satisfy a predicate
        /// </summary>
        int CountWhere(Array self, Func1 p)
           => self.Aggregate(0, (n, x) => n + (p(x) ? 1 : 0));

        /// <summary>
        /// Counts all elements in an array that are equal to true
        /// </summary>
        int CountWhere(Array self)
            => self.CountWhere(x => x);

        /// <summary>
        /// Applies a function (like "+") to each element in the series to create an effect similar to partial sums.
        /// </summary>
        Array Accumulate(Array self, Func2 f)
        {
            var n = self.Count;
            if (n == 0) return self;
            var r = Any[n];
            var prev = r[0] = self[0];
            for (var i = 1; i < n; ++i)
            {
                prev = r[i] = f(prev, self[i]);
            }
            return r.ToIArray();
        }

        /// <summary>
        /// Creates an array of arrays, split at the given indices
        /// </summary>
        Array Split(Array self, Array indices)
            => indices.Prepend(0).Zip(indices.Append(self.Count), (x, y) => self.Slice(x, y));

        /// <summary>
        /// Creates an array of arrays, split at the given index.
        /// </summary>
        Array Split(Array self, int index)
            => Create(self.Take(index), self.Skip(index));

        /// <summary>
        /// Splits an array of tuples into a tuple of array
        /// </summary>
        (Array, Array) Unzip(Array self)
            => (self.Select(pair => pair.Item1), self.Select(pair => pair.Item2));

        /// <summary>
        /// Sums items in an array using a selector function that returns integers.
        /// </summary>
        long Sum(Array self, Func1 func)
            => self.Aggregate(0L, (init, x) => init + func(x));

        /// <summary>
        /// Sums items in an array using a selector function that returns doubles.
        /// </summary>
        double Sum(Array self, Func1 func)
            => self.Aggregate(0.0, (init, x) => init + func(x));

        /// <summary>
        /// Forces evaluation (aka reification) of the array by creating a copy in memory.

        /// <summary>
        /// Maps pairs of elements to a new array.
        /// </summary>
        Array SelectPairs(Array xs, Func2 f)
            => (xs.Count / 2).Select(i => f(xs[i * 2], xs[i * 2 + 1]));

        /// <summary>
        /// Maps every 3 elements to a new array.
        /// </summary>
        Array SelectTriplets(Array xs, Func3 f)
            => (xs.Count / 3).Select(i => f(xs[i * 3], xs[i * 3 + 1], xs[i * 3 + 2]));

        /// <summary>
        /// Maps every 4 elements to a new array.
        /// </summary>
        Array SelectQuartets(Array xs, Func4 f)
            => (xs.Count / 4).Select(i => f(xs[i * 4], xs[i * 4 + 1], xs[i * 4 + 2], xs[i * 4 + 3]));

        /// <summary>
        /// Given an array of elements of type Any casts them to a Any
        /// </summary>
        Array Cast(Array xs) 
            => xs.Select(x => (Any)x);

        /// <summary>
        /// Returns true if the value is present in the array.
        /// </summary>
        bool Contains(Array xs, Any value)
            => xs.Any(x => x?.Equals(value) ?? false);

        Any FirstOrDefault(Array xs)
            => xs.FirstOrDefault(xs.DefaultElement);

        Any FirstOrDefault(Array xs, Any @default)
            => xs.Count > 0 ? xs[0] : @default;

        Any FirstOrDefault(Array xs, Func1 predicate)
            => xs.Where(predicate).FirstOrDefault();

        Array ToLongs(Array xs)
            => xs.Select(x => (long)x);

        Array PrefixSums(Array self)
            => self.ToLongs().PrefixSums();

        Array PrefixSums(Array self)
            => self.Scan(0f, (a, b) => a + b);

        Array PrefixSums(Array self)
            => self.Scan(0.0, (a, b) => a + b);

        Array Scan(Array self, Any init, Func2 scanFunc)
        {
            if (self.Count == 0)
                return Empty<Any>();
            var r = new Any[self.Count];
            for (var i = 0; i < self.Count; ++i)
                init = r[i] = scanFunc(init, self[i]);
            return r.ToIArray();
        }

        Array PrefixSums(Array counts)
            => counts.Scan(0L, (a, b) => a + b);

        // Similar to prefix sums, but starts at zero.
        // r[i] = Sum(count[0 to i])
        Array CountsToOffsets(Array counts)
        {
            var r = new int[counts.Count];
            for (var i = 1; i < counts.Count; ++i)
                r[i] = r[i - 1] + counts[i - 1];
            return r.ToIArray();
        }

        Array OffsetsToCounts(Array offsets, int last)
            => offsets.Indices().Select(i => i < offsets.Count - 1 ? offsets[i + 1] - offsets[i] : last - offsets[i]);

        Array SetElementAt(Array self, int index, Any value)
            => self.SelectIndices(i => i == index ? value : self[i]);

        Array SetFirstElementWhere(Array self, Func1 predicate, Any value)
        {
            var index = self.IndexOf(predicate);
            if (index < 0)
                return self;
            return self.SetElementAt(index, value);
        }
    }
}
