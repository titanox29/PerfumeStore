using PerfumeStoreApp.Abstracts;
using System;
namespace PerfumeStoreApp.Models
{
    public class OrientalPerfume : Perfume
    {
        public OrientalPerfume(string id, string name, double price, int quantity)
            : base(id, name, price, quantity) { }
        public override void DisplayInfo()
        {
            Console.WriteLine($"[Oriental] {Name} - {Price}$ -quantity: {Quantity}");
        }
    }
}