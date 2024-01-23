using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.VisualBasic;

namespace ClixFelippeWidjaHugo
{
    internal class Funcionario
    {
        Database database = new Database();

        /// <summary>
        /// Adiciona um novo registo a tabela 'Funcionarios' na base de dados.
        /// </summary>
        /// <param name="nome"></param>
        /// <exception cref="Exception"></exception>
        public void AdicionarFuncionario(string nome)
        {
            string stringSql = string.Format("INSERT INTO Funcionarios(Nome) VALUES ('{0}');", nome);

            if (database.ExecutarComando(stringSql) < 0)
            {
                throw new Exception();
            }
        }

        /// <summary>
        /// Remove um registo da tabela 'Funcionarios' da base de dados.
        /// </summary>
        /// <param name="idFuncionario"></param>
        /// <exception cref="Exception"></exception>
        public void RemoverFuncionario(string idFuncionario)
        {
            string stringSql = string.Format("DELETE FROM Funcionarios WHERE Id = {0};", idFuncionario);

            if (database.ExecutarComando(stringSql) < 0)
            {
                throw new Exception();
            }
        }

        /// <summary>
        /// Busca na base de dados, todos os registos de funcionarios.
        /// </summary>
        /// <returns>DataTable com os dados de todos os funcionarios.</returns>
        public DataTable BuscarFuncionarios()
        {
            string stringSql = "SELECT * FROM Funcionarios;";

            return database.BuscarDados(stringSql);
        }
    }
}
