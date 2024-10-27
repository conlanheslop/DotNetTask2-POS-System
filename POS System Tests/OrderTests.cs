using NUnit.Framework;
using POS_System.Classes;  // Reference to your main project

namespace POS_System.Tests
{
    [TestFixture]
    public class OrderTests
    {
        private Order order;

        [SetUp]
        public void Setup()
        {
            order = new Order();  // Initialize a new order before each test
        }

        [Test]
        public void AddItem_IncreasesItemCount()
        {
            // Arrange
            var item = new POSItem("Big Mac", 5.99m);

            // Act
            order.AddItem(item);

            // Assert
            Assert.That(order.GetItems().Count(), Is.EqualTo(1),
                "Item count should be 1 after adding an item.");
        }

        [Test]
        public void GetTotal_ReturnsCorrectSum()
        {
            // Arrange
            var item1 = new POSItem("Big Mac", 5.99m);
            var item2 = new POSItem("Fries", 2.99m);

            // Act
            order.AddItem(item1);
            order.AddItem(item2);

            // Assert
            Assert.That(order.GetTotal(), Is.EqualTo(8.98m),
                "Total should be the sum of item prices.");
        }
    }
}
