using System;
using System.Linq;
using NUnit.Framework;

namespace Data_Structures.Unit
{
    [TestFixture]
    class QueueTest
    {
        [Test]
        public void OnStartQueueShouldBeEmpty()
        {
            var queue = new Queueing<String>();
            var count = queue.GetItems().Count();

            Assert.AreEqual(0,count);
        }

        [Test]
        public void EnqueueShouldAddItemToQueue()
        {
            var queue = new Queueing<String>();

            queue.Enqueue("TestString");

            var count = queue.GetItems().Count();

            Assert.AreEqual(1, count);
        }

        [Test]
        public void ShouldReturnFirstItemInQueue()
        {
            var queue = new Queueing<String>();

            queue.Enqueue("TestString");
            queue.Enqueue("TestString2");

            var firstQueue = queue.GetFirst();

            Assert.AreEqual("TestString", firstQueue);
        }

        [Test]
        public void DequeueShouldRemoveFirstItemInList()
        {
            var queue = new Queueing<String>();

            queue.Enqueue("TestString");
            queue.Enqueue("TestString2");
            queue.Dequeue();

            var firstQueue = queue.GetFirst();
            var count = queue.GetItems().Count();

            Assert.AreEqual("TestString2", firstQueue);
            Assert.AreEqual(1,count);
        }
    }


}
