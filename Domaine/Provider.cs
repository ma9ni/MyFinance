using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class Provider
    {
        public int ProviderKey { get; set; }
        public int Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsApproved { get; set; }
        public string Email { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
