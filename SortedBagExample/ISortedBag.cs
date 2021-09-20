using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SortedBagExample
{
    public interface ISortedBag
    {
        ICollection<int> Items { get; }

        int Count { get; }
        void Add(int item);
        int GetMin();
        int FetchMin();
    }
}
