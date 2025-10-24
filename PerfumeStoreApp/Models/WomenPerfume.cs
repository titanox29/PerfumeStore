using PerfumeStoreApp.Abstracts;
using System;
namespace PerfumeStoreApp.Models
{
    public class WomenPerfume : Perfume
    {
        public WomenPerfume(string id, string name, double price, int quantity)
            : base(id, name, price, quantity) { }
        public override void DisplayInfo()
        {
            Console.WriteLine($"[Women] {Name} - {Price}$ - quantity: {Quantity}");
        }
    }
}