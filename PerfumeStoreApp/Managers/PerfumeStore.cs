using PerfumeStoreApp.Abstracts;
using PerfumeStoreApp.Utilities;
using System.Collections.Generic;
namespace PerfumeStoreApp.Managers
{
    public class PerfumeStore
    {
        public List<Perfume> Perfumes { get; private set; } = new List<Perfume>();
        public void AddPerfume(Perfume p)
        {
            Perfumes.Add(p);
            StoreStatistics.TotalPerfumes++;
        }
        public void DisplayAll()
        {
            foreach (var p in Perfumes)
                p.DisplayInfo();
        }
    }
}