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
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; } = null!;
        public int TipoId { get; set; }
        public Tipo Tipo { get; set; } = null!;

        public Movimento(DateTime data, string descricao, decimal valor, string situacao, int clienteId, int tipoId)
        {
            Data = data;
            Descricao = descricao;
            Valor = valor;
            Situacao = situacao;
            ClienteId = clienteId;
            TipoId = tipoId;
        }
    }
}
