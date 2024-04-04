using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class Leilao
    {
        private String descricao;
        private ArrayList lances;
        public string Descricao { get => descricao; set => descricao = value; }
        public ArrayList Lances { get => lances; }

        public Leilao(string descricao)
        {
            this.descricao = descricao;
            this.lances = new ArrayList();
        }

        public void propoe(Lance lance)
        {
            lances.Add(lance);
        }
    }
}