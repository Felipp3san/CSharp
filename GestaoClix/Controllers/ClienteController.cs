using GestaoClix.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestaoClix.Models;

namespace GestaoClix.Controllers
{
    internal class ClienteController
    {

        Context context = new Context();
        Cliente? cliente = null;

        public void adicionarCliente(string nif, string nome, string situacao)
        {
            cliente = new Cliente(nome, nif, situacao);

            if (context.Cliente is not null && cliente is not null)
            {
                context.Cliente.Add(cliente);
                context.SaveChanges();
            }
        }

        public List<Cliente> listarClientes()
        {
            var listaClientes = context.Cliente.ToList();
            return listaClientes;
        }
    }
}
