using System;
using System.Collections;
using System.Collections.Generic;

namespace Custom.Collections
{
    /// <summary>
    /// Represents a generic collection of key/value pairs that are ordered independently of the key and value.
    /// </summary>
    /// <typeparam name="TKey">The type of the keys in the dictionary</typeparam>
    /// <typeparam name="TValue">The type of the values in the dictionary</typeparam>
    public interface IOrderedDictionary<TKey, TValue> : IDictionary<TKey, TValue>, IReadOnlyOrderedDictionary<TKey, TValue>
    {
        /// <summary>
        /// Gets or sets the value at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the value to get or set.</param>
        /// <value>The value of the item at the specified index.</value>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="index"/> is less than 0.<br/>
        /// -or-<br/>
        /// <paramref name="index"/> is equal to or greater than <see cref="ICollection.Count"/>.</exception>
        new TValue this[int index] { get; set; }

        /// <summary>
        /// Inserts a new entry into the <see cref="IOrderedDictionary{TKey,TValue}">IOrderedDictionary&lt;TKey,TValue&gt;</see> collection with the specified key and value at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index at which the element should be inserted.</param>
        /// <param name="key">The key of the entry to add.</param>
        /// <param name="value">The value of the entry to add. The value can be <null/> if the type of the values in the dictionary is a reference type.</param>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="index"/> is less than 0.<br/>
        /// -or-<br/>
        /// <paramref name="index"/> is greater than <see cref="ICollection.Count"/>.</exception>
        /// <exception cref="ArgumentException">An element with the same key already exists in the <see cref="IOrderedDictionary{TKey,TValue}">IOrderedDictionary&lt;TKey,TValue&gt;</see>.</exception>
        /// <exception cref="NotSupportedException">The <see cref="IOrderedDictionary{TKey,TValue}">IOrderedDictionary&lt;TKey,TValue&gt;</see> is read-only.<br/>
        /// -or-<br/>
        /// The <see cref="IOrderedDictionary{TKey,TValue}">IOrderedDictionary&lt;TKey,TValue&gt;</see> has a fized size.</exception>
        void Insert(int index, TKey key, TValue value);

        /// <summary>
        /// Removes the entry at the specified index from the <see cref="OrderedDictionary{TKey,TValue}">OrderedDictionary&lt;TKey,TValue&gt;</see> collection.
        /// </summary>
        /// <param name="index">The zero-based index of the entry to remove.</param>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="index"/> is less than 0.<br/>
        /// -or-<br/>
        /// index is equal to or greater than <see cref="Count"/>.</exception>
        void RemoveAt(int index);

        new int Count { get; }
        new ICollection<TKey> Keys { get; }
        new ICollection<TValue> Values { get; }
        new TValue this[TKey key] { get; set; }
        new bool ContainsKey(TKey key);
        new bool TryGetValue(TKey key, out TValue value);
    }
}
