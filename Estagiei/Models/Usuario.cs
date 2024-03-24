using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Estagiei.Models
{
    public class Usuario
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string nome { get; set; }

        [Display(Name = "Documento")]
        public string documento { get; set; }

        [Display(Name = "E-mail")]
        public string email { get; set; }

        [Display(Name = "Telefone")]
        public string telefone { get; set; }

        [Display(Name = "Senha")]
        public string senha { get; set; }
    }
}