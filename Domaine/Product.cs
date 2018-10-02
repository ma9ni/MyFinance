using System;
using System.Collections.Generic;

namespace Domaine
{
    public class Product
    {
        public int ProductId { get; set; }
        public DateTime? DateProd { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public double price { get; set; }
        public int Quantity { get; set; }
        public string imageName { get; set; }
        public virtual ICollection<Provider> Providers { get; set; }
        //virtual pour activer lazyloading
        public virtual Category Category { get; set; }
        //? nullable
        public int? CategoryId { get; set; }
     
    }
}
