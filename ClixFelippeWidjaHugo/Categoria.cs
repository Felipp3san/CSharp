using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.VisualBasic;

namespace ClixFelippeWidjaHugo
{
    internal class Categoria
    {
        Database database = new Database();

        /// <summary>
        /// Adiciona um novo registo a tabela 'Categorias' na base de dados.
        /// </summary>
        /// <param name="nome"></param>
        /// <exception cref="Exception"></exception>
        public void AdicionarCategoria(string nome)
        {
            string stringSql = string.Format("INSERT INTO Categorias(Nome) VALUES ('{0}');", nome);

            if (database.ExecutarComando(stringSql) < 0)
            {
                throw new Exception();
            }
        }

        /// <summary>
        /// Remove um registo da tabela 'Categorias' da base de dados.
        /// </summary>
        /// <param name="idCategoria">Nome da categoria a ser removido.</param>
        /// <exception cref="Exception"></exception>
        public void RemoverCategoria(string idCategoria)
        {
            string stringSql = string.Format("DELETE FROM Categorias WHERE Id = {0};", idCategoria);

            if (database.ExecutarComando(stringSql) < 0)
            {
                throw new Exception();
            }
        }

        /// <summary>
        /// Busca na base de dados, todos os registos de categorias.
        /// </summary>
        /// <returns>DataTable com os dados de todos as categorias.</returns>
        public DataTable BuscarCategorias()
        {
            string stringSql = "SELECT * FROM Categorias;";

            return database.BuscarDados(stringSql);
        }
    }
}
