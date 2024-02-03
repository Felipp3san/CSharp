using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoClix.Models
{
    internal class Tipo
    {
        public int Id { get; set; }
        public string Designacao { get; set; }
        public Tipo(string designacao)
        {
            Designacao = designacao;
        }
    }

}
