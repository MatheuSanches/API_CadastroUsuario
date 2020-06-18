using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_emezu.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string telefone  { get; set; }
        public string endereco { get; set; }

        /*public Usuario(string text)
        {
            this.nome = text;
        }*/
    }
}