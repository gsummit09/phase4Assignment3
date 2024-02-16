using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment2
{
    public class Product
    {
        public string? PName { get; set; }
        public double PPrice { get; set; }
        public string? PBrand { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public DateTime ExpiryDate { get; set; }

        public Product(string Name, double Price, string Brand, DateTime mfDate, DateTime expDate)
        {
            PName = Name;
            PPrice = Price;
            PBrand = Brand;
            ManufacturingDate = mfDate;
            ExpiryDate = expDate;
        }
    }
}
