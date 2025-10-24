using PerfumeStoreApp.Interfaces;
namespace PerfumeStoreApp.Abstracts
{
    public abstract class Perfume : IProduct
    {
        private string id;
        private string name;
        private double price;
        private int quantity;
        public string Id => id;
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public Perfume(string id, string name, double price, int quantity)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }
        public abstract void DisplayInfo();
    }
}