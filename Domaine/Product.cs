using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domaine
{
    public class Product
    {
        public int ProductId { get; set; }
        //displayed,Date
        [Display(Name="Date de production ")]
        [DataType(DataType.Date)]
        public DateTime? DateProd { get; set; }
        //the property Description Multiline
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        // the property Name Required
        //string length 25
        [Required(ErrorMessage ="obligatoire !")]
        [StringLength(25,ErrorMessage ="le nom ne doit pas depasser 25 caractéres") ]
        [MaxLength(50)]
        public string Name { get; set; }
        [DataType(DataType.Currency)]
        public double price { get; set; }
        //positive
        [Range(0,int.MaxValue)]
        public int Quantity { get; set; }
        public string imageName { get; set; }
        public virtual ICollection<Provider> Providers { get; set; }
        //virtual pour activer lazyloading
        //FK 1/2
     //   [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
        //? nullable
        //FK 2/2
        [ForeignKey("Category")]
        public int? CategoryId { get; set; }

        public virtual ICollection<Facture> Factures { get; set; }

    }
}
