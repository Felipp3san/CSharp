using GestaoClix.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestaoClix.Models;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using Microsoft.VisualBasic.ApplicationServices;

namespace GestaoClix.Controllers
{
    internal class GestorCliente
    {

        Database database = Database.getInstance();
        Cliente? cliente = null;

        public void adicionarCliente(string nif, string nome, string situacao)
        {
            try
            {
                cliente = new Cliente(nif, nome, situacao);

                if (database.Cliente is not null && cliente is not null)
                {
                    database.Cliente.Add(cliente);
                    database.SaveChanges();
                }

                cliente = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void atualizarCliente(string idCliente, string nif, string nome, string situacao) {

            cliente = null;

            if (database.Cliente is not null)
            {
                cliente = database.Cliente.FirstOrDefault(e => e.Id == Convert.ToInt16(idCliente));

                if (cliente is not null)
                {
                    cliente.Nome = nome;
                    cliente.Nif = nif;
                    cliente.Situacao = situacao;
                }
            }

            try
            {
                database.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void removerCliente(string idCliente)
        {
            cliente = null;
            
            if (database.Cliente is not null)
            {
                cliente = database.Cliente.Where(x => x.Id == Convert.ToInt16(idCliente)).FirstOrDefault();

                if (cliente is not null)
                {
                    database.Cliente.Remove(cliente);
                    database.SaveChanges();
                    cliente = null;
                }
            }
        }

        public List<Cliente>? ListarClientes()
        {
            List<Cliente>? listaClientes = null;

            if (database.Cliente is not null)
                listaClientes = [.. database.Cliente];
            
            return listaClientes;
        }

        public Cliente? BuscarCliente(string idCliente)
        {
            cliente = null;

            if (database.Cliente is not null)
                cliente = database.Cliente.Find(idCliente);

            return cliente;
        }
    }
}
