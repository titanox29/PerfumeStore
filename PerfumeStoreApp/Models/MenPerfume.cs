using PerfumeStoreApp.Abstracts;
using System;
namespace PerfumeStoreApp.Models
{
    public class MenPerfume : Perfume
    {
        public MenPerfume(string id, string name, double price, int quantity)
            : base(id, name, price, quantity) { }
        public override void DisplayInfo()
        {
            Console.WriteLine($"[Men] {Name} - {Price}$ - quantity: {Quantity}");
        }
    }
}