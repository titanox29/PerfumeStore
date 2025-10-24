using PerfumeStoreApp.Abstracts;
using System;
namespace PerfumeStoreApp.Managers
{
    public delegate void LowStockHandler(string perfumeName);
    public class InventoryManager
    {
        public event LowStockHandler OnLowStock;
        public void CheckStock(Perfume p)
        {
            if (p.Quantity < 5)
                OnLowStock?.Invoke(p.Name);
        }
    }
}