using NUnit.Framework;
using POS_System.Classes;

namespace POS_SystemTests
{
    [TestFixture]
    public class OrderTests
    {
        private Order order;

        [SetUp]
        public void Setup()
        {
            order = new Order();  // initialisation
        }

        [Test]
        public void AddItem_IncreasesItemCount()
        {
            var item = new POSItem("Big Mac", 5.99m); // arrange

            order.AddItem(item); // act

            Assert.That(order.GetItems().Count(), Is.EqualTo(1), "Item count should be 1 after adding an item."); // assert
        }

        [Test]
        public void GetTotal_ReturnsCorrectSum()
        {
            var item1 = new POSItem("Big Mac", 5.99m);
            var item2 = new POSItem("Fries", 2.99m);

            order.AddItem(item1);
            order.AddItem(item2);


            Assert.That(order.GetTotal(), Is.EqualTo(8.98m),"Total should be the sum of item prices.");
        }
    }
}
