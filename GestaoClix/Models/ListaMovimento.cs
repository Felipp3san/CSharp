using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoClix.Models
{
    internal class ListaMovimento
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Situacao { get; set; }
        public DateTime Data {  get; set; }
        public string Cliente { get; set; }
        public int ClienteId { get; set; }
        public decimal Valor { get; set; }
        public string Tipo { get; set; }
        public int TipoId { get; set; }
    }
}
