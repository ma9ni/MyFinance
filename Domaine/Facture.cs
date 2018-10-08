using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class Facture
    {
       



        //Primary Key -> ForeignKey from table Client
        [Key]
        [Column(Order =0)]
        [ForeignKey("Client")]
        public int ClientId { get; set; }


        //Primary Key -> ForeignKey from table Produit
        [Key]
        [Column(Order = 1)]
        [ForeignKey("Product")]
        public int ProductId { get; set; }

        //Primary Key 
        [Key]
        [Column(Order = 2)]

        //Object de navigation
        public DateTime DateFacture { get; set; }

        public Client Client { get; set; }

        public Product Product { get; set; }
    }
}
