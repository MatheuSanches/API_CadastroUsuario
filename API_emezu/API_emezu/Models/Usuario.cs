using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_emezu.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public int pes_codigo { get; set; }
        public string pes_telefone  { get; set; }
        public string pes_endereco { get; set; }

        //public Usuario(string text)
        //{
        //    this.nome = text;
        //}
    }
}