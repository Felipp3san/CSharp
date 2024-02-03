using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoClix.Models
{
    internal class Movimento
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public string Situacao { get; set; }
        public Cliente Cliente { get; set; }
        public Tipo Tipo { get; set; }
    }
}
