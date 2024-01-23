using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ClixFelippeWidjaHugo
{
    internal class Cliente
    {
        Database database = new Database();

        /// <summary>
        /// Adiciona um novo registo a tabela 'Clientes' na base de dados.
        /// </summary>
        /// <param name="nome">Nome do cliente a ser adicionado.</param>
        /// <exception cref="Exception"></exception>
        public void AdicionarCliente(string nome)
        {
            string stringSql = string.Format("INSERT INTO Clientes(Nome) VALUES ('{0}');", nome);

            if (database.ExecutarComando(stringSql) < 0)
            {
                throw new Exception();
            }
        }

        /// <summary>
        /// Remove um registo da tabela 'Clientes' da base de dados.
        /// </summary>
        /// <param name="idCliente">Nome do cliente a ser removido.</param>
        /// <exception cref="Exception"></exception>
        public void RemoverCliente(string idCliente)
        {
            string stringSql = string.Format("DELETE FROM Clientes WHERE Id = {0};", idCliente);

            if (database.ExecutarComando(stringSql) < 0)
            {
                throw new Exception();
            }
        }

        /// <summary>
        /// Busca na base de dados, todos os registos de clientes.
        /// </summary>
        /// <returns>DataTable com os dados de todos os clientes.</returns>
        public DataTable BuscarClientes()
        {
            string stringSql = "SELECT * FROM Clientes;";

            return database.BuscarDados(stringSql); 
        }
    }
}
