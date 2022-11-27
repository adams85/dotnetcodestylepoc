using System;
using System.Collections;
using System.Collections.Generic;

namespace Custom.Collections
{
    /// <summary>
    /// Represents a generic read-only collection of key/value pairs that are ordered independently of the key and value.
    /// </summary>
    /// <typeparam name="TKey">The type of the keys in the dictionary</typeparam>
    /// <typeparam name="TValue">The type of the values in the dictionary</typeparam>
    public interface IReadOnlyOrderedDictionary<TKey, TValue> : IReadOnlyDictionary<TKey, TValue>
    {
        /// <summary>
        /// Gets the value at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the value to get or set.</param>
        /// <value>The value of the item at the specified index.</value>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="index"/> is less than 0.<br/>
        /// -or-<br/>
        /// <paramref name="index"/> is equal to or greater than <see cref="ICollection.Count"/>.</exception>
        TValue this[int index] { get; }

        /// <summary>
        /// Gets the key at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the key to get.</param>
        /// <returns>The key of the item at the specified index.</returns>
        TKey GetKeyAt(int index);

        /// <summary>
        /// Returns the zero-based index of the specified key in the <see cref="OrderedDictionary{TKey,TValue}">OrderedDictionary&lt;TKey,TValue&gt;</see>
        /// </summary>
        /// <param name="key">The key to locate in the <see cref="OrderedDictionary{TKey,TValue}">OrderedDictionary&lt;TKey,TValue&gt;</see></param>
        /// <returns>The zero-based index of <paramref name="key"/>, if <paramref name="ley"/> is found in the <see cref="OrderedDictionary{TKey,TValue}">OrderedDictionary&lt;TKey,TValue&gt;</see>; otherwise, -1</returns>
        /// <remarks>This method performs a linear search; therefore it has a cost of O(n) at worst.</remarks>
        int IndexOfKey(TKey key);
    }
}
