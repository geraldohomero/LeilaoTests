using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class Usuario
    {
        private String nome;
        public string Nome { get => nome; set => nome = value; }

        public Usuario(string nome)
        {
            this.nome = nome;
        }
    }
}