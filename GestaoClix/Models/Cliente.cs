using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoClix.Models
{
    internal class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Nif { get; set; }
        public string Situacao { get; set; }

        public Cliente(string nif, string nome, string situacao) 
        {
            Nif = nif;
            Nome = nome;
            Situacao = situacao;
        }
    }
}
