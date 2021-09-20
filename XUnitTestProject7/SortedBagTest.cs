using SortedBagExample;
using System;
using System.Linq;
using Xunit;

namespace XUnitTestProject7
{
    public class SortedBagTest
    {
        /// <summary>
        /// Tests creation of the SortedBag.
        /// Items should be empty and the Count be zero.
        /// </summary>
        [Fact]
        public void CreateSortedBag()
        {
            ISortedBag bag = new SortedBag();

            Assert.NotNull(bag);
            Assert.True(bag is SortedBag);
            Assert.Equal(0, bag.Count);
            Assert.Empty(bag.Items);
        }

        /// <summary>
        /// Tests adding a new item to the SortedBag.
        /// The item should be added to the Items and the Count increased.
        /// </summary>
        [Fact]
        public void Add()
        { 
            
            // arrange
            int x = 1;
            ISortedBag bag = new SortedBag();
            Assert.Empty(bag.Items);
            Assert.Equal(0, bag.Count);

            // act
            bag.Add(x);

            // assert
            Assert.True(bag.Items.Contains(x));
            Assert.Equal(1, bag.Count);
        }

        [Fact]
        public void AddSameItemTwice()
        {
            int x = 1234;
            ISortedBag bag = new SortedBag();
            bag.Add(x);
            Assert.Contains(x, bag.Items);

            bag.Add(x);
            Assert.Equal(2, bag.Items.Count( i => i == x));
        }

        [Fact]
        public void GetMinEmptySortedBagExpectExceptionTOBeThrown()
        {
            // arrange
            ISortedBag bag = new SortedBag();
            Assert.Empty(bag.Items);

            // act + assert
            var ex = Assert.Throws<InvalidOperationException>(() => bag.GetMin());
            Assert.Equal("SortedBag is empty", ex.Message);
        }

        [Fact]
        public void GetMinMoreItemsInItemsCollection()
        {
            // arrange
            ISortedBag bag = new SortedBag();
            bag.Add(2);
            bag.Add(1);
            int oldCount = bag.Count;

            // act
            int result = bag.GetMin();
            
            // assert
            Assert.Equal(1, result);
            Assert.Equal(oldCount, bag.Count);
        }

        [Fact]
        public void FetchMinEmptySortedBagExpectExceptionTOBeThrown()
        {
            // arrange
            ISortedBag bag = new SortedBag();
            Assert.Empty(bag.Items);

            // act + assert
            var ex = Assert.Throws<InvalidOperationException>(() => bag.FetchMin());
            Assert.Equal("SortedBag is empty", ex.Message);
        }

        [Fact]
        public void FetchMinMoreItemsInItemsCollection()
        {
            // arrange
            ISortedBag bag = new SortedBag();
            bag.Add(2);
            bag.Add(1);
            int oldCount = bag.Count;

            // act
            int result = bag.FetchMin();
            
            // assert
            Assert.Equal(1, result);
            Assert.Equal(oldCount-1, bag.Count);
        }
    }
}
