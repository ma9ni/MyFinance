using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class Client
    {
        [Key]
        public int CIN { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }


        public virtual ICollection<Facture> Factures { get; set; }
    }
}
