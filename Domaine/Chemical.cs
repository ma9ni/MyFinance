using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class Chemical:Product
    {
        public string LabName { get; set; }

        public Adress Adress { get; set; }
    }
}
