using System;
using PerfumeStoreApp.Models;
using PerfumeStoreApp.Managers;
using PerfumeStoreApp.Utilities;
namespace PerfumeStoreApp
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            PerfumeStore store = new PerfumeStore();
            InventoryManager manager = new InventoryManager();
            // Event when stock is low
            manager.OnLowStock += name => Console.WriteLine($" Low stock for perfume: {name}");
            // Create some perfumes
            var p1 = new MenPerfume("001", "Blue Night", 50, 3);
            var p2 = new WomenPerfume("002", "Rose Dream", 70, 10);
            var p3 = new OrientalPerfume("003", "Oud Elite", 90, 2);
            // Add perfumes to store
            store.AddPerfume(p1);
            store.AddPerfume(p2);
            store.AddPerfume(p3);
            // Display all perfumes
            store.DisplayAll();
            // Show total
            Console.WriteLine($"Total perfumes in store: {StoreStatistics.TotalPerfumes}");
            // Check stock
            manager.CheckStock(p1);
            manager.CheckStock(p3);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}