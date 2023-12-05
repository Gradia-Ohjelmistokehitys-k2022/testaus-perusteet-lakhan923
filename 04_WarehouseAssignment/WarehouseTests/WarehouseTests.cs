using Warehouse;

namespace WarehouseTests
{
    [TestClass]
    public class WarehouseTests
    {
        [TestMethod]
        public void WareHouseSimulator()
        {
            // Arrange
            WareHouse wareHouse = new WareHouse();

            // Act
            wareHouse.WareHouseSimulator();

            // Assert
            Assert.AreEqual(5, wareHouse.StockCount("Hat"));
            Assert.AreEqual(3, wareHouse.StockCount("Shoes"));
            Assert.AreEqual(5, wareHouse.StockCount("Jacket"));
        }

        [TestMethod]
        public void AddToStocks()
        {
            //Arrange
            WareHouse warehouse = new WareHouse();

            //Act
            warehouse.AddToStocks("Gloves", 6);

            //Assert
            Assert.AreEqual(6, warehouse.StockCount("Gloves"));
        }

        [TestMethod]
        public void InStock_ItemExists()
        {
            // Arrange
            WareHouse wareHouse = new WareHouse();
            wareHouse.WareHouseSimulator();

            // Act
            bool inStock = wareHouse.InStock("Shoes");

            // Assert
            Assert.IsTrue(inStock);
        }

        [TestMethod]
        public void InStock_ItemDoesNotExist()
        {
            // Arrange
            WareHouse wareHouse = new WareHouse();

            // Act
            bool inStock = wareHouse.InStock("Gloves");

            // Assert
            Assert.IsFalse(inStock);
        }

        [TestMethod]
        public void TakeFromStock_ItemInStock()
        {
            // Arrange
            WareHouse wareHouse = new WareHouse();
            wareHouse.WareHouseSimulator();

            // Act
            wareHouse.TakeFromStock("Shoes", 2);

            // Assert
            Assert.AreEqual(1, wareHouse.StockCount("Shoes"));
        }

        [TestMethod]
        public void TakeFromStock_ItemNotInStock()
        {
            // Arrange
            WareHouse wareHouse = new WareHouse();
            wareHouse.WareHouseSimulator();

            // Act and Assert
            Assert.ThrowsException<NullReferenceException>(() => wareHouse.TakeFromStock("Gloves", 1));
        }

        [TestMethod]
        public void TestStockCount()
        {
            // Arrange
            WareHouse wareHouse = new WareHouse();
            wareHouse.WareHouseSimulator();

            // Act
            int stockCount = wareHouse.StockCount("Shoes");

            // Assert
            Assert.AreEqual(3, stockCount);
        }
    }
}


