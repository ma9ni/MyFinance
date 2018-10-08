using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class Provider
    {
        //PK
        //  [Key]
        public int ProviderKey { get; set; }
        public int Username { get; set; }
        //password,minimum 8 caractéres ,required
        [DataType(DataType.Password)]
        [MinLength(8,ErrorMessage ="min 8")]
        [Required(ErrorMessage ="Obligatoire !")]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [NotMapped]
        [Compare("Password",ErrorMessage ="verifiez")]
        public string ConfirmPassword { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsApproved { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
