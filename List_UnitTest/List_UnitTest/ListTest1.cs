using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace List_UnitTest
{
    [TestClass]
    public class ListTest1
    {
        [TestMethod]
        public void CanAddAtEnd()
        {
            List<int> NumList = new List<int> { 1, 2, 3 };
            NumList.Add(4); // Adding number to our list so there will be +1 size/more index 

            Assert.AreEqual(4, NumList[3]);
        }

        [TestMethod]
        public void CanAddAtPosition()
        {
            List<int> NumList = new List<int> { 1, 2, 3 };
            NumList.Insert(2, 4); // Replacing number from index 2 ( 3 to 4 ) 

            Assert.AreEqual(4, NumList[2]);
        }

        [TestMethod]
        public void CanRemove()
        {
            List<int> NumList = new List<int> { 1, 2, 3 };
            NumList.Remove(2);

            Assert.IsTrue(NumList.SequenceEqual(new[] { 1, 3 }));
        }

        [TestMethod]
        public void CanSearchInIndex() // Search number 3 in just one index
        {
            List<int> NumList = new List<int> { 1, 2, 3 };

            Assert.AreEqual(NumList.IndexOf(3), 2);
        }

        [TestMethod]
        public void CanSearchInList() // Search number 3 in whole list
        {
            List<int> NumList = new List<int> { 1, 2, 3 };

            Assert.IsTrue(NumList.Contains(3));
        }

        [TestMethod]
        public void CanAddRangeOfNumbers()
        {
            List<int> NumList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var nums = new List<int> { 11, 12, 13, 14 };

            NumList.AddRange(nums); // Adding our range to our NumList list

            Assert.AreEqual(14, NumList[13]);

        }
    }
}
