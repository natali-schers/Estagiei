using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Estagiei.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        public string nome { get; set; }    

        public string documento { get; set; }

        public string email { get; set; }

        public string telefone { get; set; }
        
        public string senha { get; set; }
    }
}