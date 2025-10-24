namespace PerfumeStoreApp.Utilities
{
    public static class Validator
    {
        public static bool IsValidPrice(double price) => price > 0;
        public static bool IsValidQuantity(int q) => q >= 0;
    }
}