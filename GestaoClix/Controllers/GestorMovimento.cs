using GestaoClix.Models;
using GestaoClix.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.InteropServices.ObjectiveC;
using Microsoft.EntityFrameworkCore;

namespace GestaoClix.Controllers
{
    internal class GestorMovimento
    {
        Database database = new Database();
        Movimento? movimento = null;

        public void AdicionarMovimento(DateTime data, string descricao, decimal valor, string situacao, int clienteId, int tipoId)
        {

                movimento = new Movimento(data, descricao, valor, situacao, clienteId, tipoId);

                if (database.Movimento is not null && movimento is not null)
                {
                    database.Movimento.Add(movimento);
                    database.SaveChanges();
                }

                movimento = null;
        }

        public List<ListaMovimento>? ListarMovimentos()
        {
            List<ListaMovimento>? listaMovimentos = null;

            if (database.Movimento is not null)
            {
                listaMovimentos = database.Movimento.Select(movimento => new ListaMovimento
                    {
                        Id = movimento.Id,
                        Descricao = movimento.Descricao,
                        Situacao = movimento.Situacao,
                        Data = movimento.Data,
                        Cliente = movimento.Cliente.Nome,
                        ClienteId = movimento.ClienteId,
                        Valor = movimento.Valor,
                        Tipo = movimento.Tipo.Designacao,
                        TipoId = movimento.TipoId
                    }).ToList();
            }

            return listaMovimentos;
        }
    }
}
