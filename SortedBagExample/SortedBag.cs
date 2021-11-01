using System;
using System.Collections.Generic;
using System.Linq;

namespace SortedBagExample
{
    public class SortedBag : ISortedBag
    {
        /// <summary>
        /// Property containing the items of the SortedBag.
        /// Is empty when created.
        /// </summary>
        public ICollection<int> Items { get; private set; }

        /// <summary>
        /// Property showing the current number of items in the SortedBag.
        /// Is zero when SortedBag is created.
        /// </summary>
        public int Count 
        { 
            get
            { 
                return Items.Count;
            } 
        }

        /// <summary>
        /// Creates an instance of the SortedBag.
        /// The Items collection is empty and the Count is zero.
        /// </summary>
        public SortedBag()
        {
            Items = new List<int>();
        }

        /// <summary>
        /// Adds an item to the SortedBag.
        /// The Count is increased.
        /// </summary>
        /// <param name="item">The item to add</param>
        public void Add(int item)
        {
            Items.Add(item);
        }

        /// <summary>
        /// Removes and returns the smallest item in the SortedBag.
        /// If empty, an InvalidOperationException is thrown.
        /// the Count is Decreased.
        /// </summary>
        /// <returns>The smallest item in the SortedBag</returns>
        public int FetchMin()
        {
            if (Count == 0)
                throw new InvalidOperationException("SortedBag is empty");
            int result = Items.Min(); // O(n)
            Items.Remove(result);     // O(n)
            return result;
        }

        /// <summary>
        /// Returns the smallest item in the SortedBag.
        /// If empty, an InvalidOperationException is thrown.
        /// the Count is not changed.
        /// </summary>
        /// <returns>The smallest item in the SortedBag</returns>
        public int GetMin()
        {
            if (Count == 0)
                throw new InvalidOperationException("SortedBag is empty");
            return Items.Min();  // O(n)
        }

    }
}
