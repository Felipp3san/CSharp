using GestaoClix.Models;
using GestaoClix.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GestaoClix.Controllers
{
    internal class GestorMovimento
    {
        Database database = new Database();
        Movimento? movimento = null;

        public void AdicionarMovimento(DateTime data, string descricao, decimal valor, string situacao, int clienteId, int tipoId)
        {
            try
            {
                movimento = new Movimento(data, descricao, valor, situacao, clienteId, tipoId);

                if (database.Movimento is not null && movimento is not null)
                {
                    database.Movimento.Add(movimento);
                    database.SaveChanges();
                }

                movimento = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<Movimento>? ListarMovimentos()
        {
            List<Movimento>? listaMovimentos = null;

            if (database.Movimento is not null)
                listaMovimentos = database.Movimento.ToList();

            return listaMovimentos;
        }
    }
}
