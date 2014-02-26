using System;
using System.Linq;
using NUnit.Framework;

namespace Data_Structures.Unit
{   
    [TestFixture]
    class ListTest
    {
        [Test]
        public void ListMustBeEmptyOnStartup()
        {
            var list = new Listing<String>();
            var x = list.GetItems();
            var count = x.Count();

            Assert.AreEqual(0,count);
        }

        [Test]
        public void ItemSoudBeAddedToListIfAddIsCalled()
        {
            var list = new Listing<String>();
            list.Add("Test");
            var count = list.GetItems().Count();

            Assert.AreEqual(1,count);
        }

        [Test]
        public void ItemShouldBeRemovedFromListIfRemoveIsCalled()
        {
            var list = new Listing<String>();
            list.Add("Test");
            list.Remove("Test");

            var count = list.GetItems().Count();

            Assert.AreEqual(0, count);
        }

        [Test]
        public void BinarySearchShouldReturnTheCorrectPositionOfItem()
        {
            var list = new Listing<String>();
            list.Add("1");
            list.Add("4");
            list.Add("12");
            list.Add("15");
            list.Add("22");
            list.Add("67");
            list.Add("100");

            var index = list.BinarySearch("22");

            Assert.AreEqual(4,index);

        }
    }
}
