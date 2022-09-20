using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Queue_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void QueuePeek()
        {
            var wheelie = new Queue<int>();

            wheelie.Enqueue(1);
            wheelie.Enqueue(2);
            wheelie.Enqueue(6);
            wheelie.Enqueue(10);
            wheelie.Enqueue(16);
            wheelie.Enqueue(3);

            Assert.AreEqual(1, wheelie.Peek());
        }

        [TestMethod]
        public void QueueContains()
        {
            var wheelie = new Queue<int>();

            wheelie.Enqueue(1);
            wheelie.Enqueue(2);
            wheelie.Enqueue(6);
            wheelie.Enqueue(10);
            wheelie.Enqueue(16);
            wheelie.Enqueue(3);

            Assert.IsTrue(wheelie.Contains(10));
        }

        [TestMethod]
        public void QueueToArray()
        {
            var wheelie = new Queue<int>();

            wheelie.Enqueue(1);
            wheelie.Enqueue(2);
            wheelie.Enqueue(6);
            wheelie.Enqueue(10);
            wheelie.Enqueue(16);
            wheelie.Enqueue(3);

            int[] tarray = wheelie.ToArray();

            Assert.AreEqual(6, tarray[2]);
        }
    }
}
