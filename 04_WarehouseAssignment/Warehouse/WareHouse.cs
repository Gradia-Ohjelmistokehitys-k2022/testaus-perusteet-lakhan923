using System;
namespace Warehouse
{
    public class WareHouse
    {
        private List<Stock> _stockOfItems;

        public WareHouse()
        {

        }

        public void WareHouseSimulator()
        {
            _stockOfItems = new List<Stock>();
            Stock item1 = new Stock("Hat", 2);
            Stock item2 = new Stock("Shoes", 3);
            Stock item3 = new Stock("Jacket", 5);
            Stock item4 = new Stock("Hat", 3);

            _stockOfItems.Add(item1);
            _stockOfItems.Add(item2);
            _stockOfItems.Add(item3);
            _stockOfItems.Add(item4);
        }

        public void AddToStocks(string itemName, int itemCount)
        {
            if (_stockOfItems == null)
            {
                _stockOfItems = new List<Stock>();
            }
            Stock stock = new Stock(itemName, itemCount);
            _stockOfItems.Add(stock);
        }

        public bool InStock(string itemName)
        {
            // Checking if _stockOfItems is null
            if (_stockOfItems == null)
            {
                return false;
            }

            return _stockOfItems.Any(item => item.ItemName == itemName && item.Quantity > 0);
        }

        public void TakeFromStock(string itemName, int quantity)
        {
            Stock? stock = null;
            if (InStock(itemName))
            {

                stock = _stockOfItems.FirstOrDefault(item => item.Quantity > 0 && item.ItemName == itemName);
                stock.Quantity -= quantity;
            }
            else
            {
                throw new Exception("Oversold" + stock.ItemName);
            }
        }

        public int StockCount(string itemName)
        {
            var matches = _stockOfItems.Where(item => item.ItemName == itemName);
            int count = 0;
            foreach (var item in matches)
            {
                count += item.Quantity;
            }
            return count;
        }
    }
}

