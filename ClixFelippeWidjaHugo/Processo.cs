using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClixFelippeWidjaHugo
{
 
    internal class Processo
    {
        Database database = new Database();

        /// <summary>
        /// Adiciona um novo processo a base de dados.
        /// </summary>
        /// <param name="descricao"></param>
        /// <param name="data"></param>
        /// <param name="tempoGasto"></param>
        /// <param name="idFuncionario"></param>
        /// <param name="idCliente"></param>
        /// <param name="idCategoria"></param>
        /// <exception cref="Exception"></exception>
        public void AdicionarProcesso(string descricao, string data, string tempoGasto, string idFuncionario, string idCliente, string idCategoria)
        {

            string stringSql = string.Format("INSERT INTO Processos(Descricao, Data, Tempo, FuncionarioId, ClienteId, CategoriaId) VALUES ('{0}','{1}',{2},{3},{4},{5});",
                                descricao, data, tempoGasto, idFuncionario, idCliente, idCategoria);

            if (database.ExecutarComando(stringSql) < 0)
            {
                throw new Exception();     
            }
        }

        /// <summary>
        /// Remove os processos relacionados ao id e tabela indicados da base de dados.
        /// </summary>
        /// <param name="id">ID do cliente, funcionario ou categoria ao qual serao excluidos os processos.</param>
        /// <param name="nomeTabela">Nome da tabela a qual os processos relacionados serao excluidos.</param>
        /// <exception cref="Exception"></exception>
        public void RemoverProcessos(string id, string nomeTabela)
        {
            string stringSql = "";

            if (nomeTabela.Equals("cliente"))
            {
                stringSql = string.Format("DELETE FROM Processos WHERE ClienteId = {0};", id);
            }
            else if (nomeTabela.Equals("funcionario"))
            {
                stringSql = string.Format("DELETE FROM Processos WHERE FuncionarioId = {0};", id);
            }
            else if (nomeTabela.Equals("categoria"))
            {
                stringSql = string.Format("DELETE FROM Processos WHERE CategoriaId = {0};", id);
            }

            if (database.ExecutarComando(stringSql) < 0)
            {
                throw new Exception();
            }
        }

        /// <summary>
        /// Faz a contagem dos processos relacionados ao id e tabela indicados da base de dados.
        /// </summary>
        /// <param name="id">ID do cliente, funcionario ou categoria ao qual serao contados os processos.</param>
        /// <param name="nomeTabela">Nome da tabela a qual os processos relacionados serao contados.</param>
        /// <returns>Retorna a contagem em processos.</returns>
        public int ContarProcessos(string id, string nomeTabela)
        {
            string stringSql = "";

            if (nomeTabela.Equals("cliente"))
            {
                stringSql = string.Format("SELECT COUNT(*) AS 'Contagem' FROM Processos WHERE ClienteId = {0};", id);
            }
            else if (nomeTabela.Equals("funcionario"))
            {
                stringSql = string.Format("SELECT COUNT(*) AS 'Contagem' FROM Processos WHERE FuncionarioId = {0};", id);
            }
            else if (nomeTabela.Equals("categoria"))
            {
                stringSql = string.Format("SELECT COUNT(*) AS 'Contagem' FROM Processos WHERE CategoriaId = {0};", id);
            }

            DataTable processos = database.BuscarDados(stringSql);
            int contagemProcessos = Convert.ToInt16(processos.Rows[0]["Contagem"]);

            return contagemProcessos;
        }

        /// <summary>
        /// Busca na base de dados, uma datatable com os processos de acordo com a filtragem selecionada.
        /// (Filtrar pro clientes, funcionários, ou não filtrar.).
        /// </summary>
        /// <param name="idClienteFuncionario">id do cliente ou funcionario que deseja utilizar para agrupar</param>
        /// <param name="agruparPorCliente"></param>
        /// <param name="agruparPorFuncionario"></param>
        /// <returns>DataTable com a lista de processos de acordo com a opçao de filtragem.</returns>
        public DataTable ListarProcessos(string idClienteFuncionario, bool agruparPorCliente, bool agruparPorFuncionario)
        {
            
            DataTable datatable = new DataTable();
            string stringSql;

            if (agruparPorFuncionario)
            {
                stringSql = string.Format("SELECT Funcionarios.Nome As 'Funcionario', MONTH(Processos.Data) AS 'Mes', CONCAT(SUM(Tempo), ' minuto(s)') As 'Tempo_total' FROM Processos " +
                                            "INNER JOIN Funcionarios ON Funcionarios.Id = Processos.FuncionarioId " +
                                            "WHERE FuncionarioId = {0} " +
                                            "GROUP BY MONTH(Processos.Data), Funcionarios.Nome", idClienteFuncionario);
            }
            else if (agruparPorCliente)
            {
                stringSql = string.Format("SELECT Clientes.Nome As 'Cliente', MONTH(Processos.Data) AS 'Mes', CONCAT(SUM(Tempo), ' minuto(s)') As 'Tempo_total' FROM Processos " +
                                            "INNER JOIN Clientes ON Clientes.Id = Processos.ClienteId " +
                                            "WHERE ClienteId = {0} " +
                                            "GROUP BY MONTH(Processos.Data), Clientes.Nome", idClienteFuncionario);
            }
            else
            {
                stringSql = ("SELECT Processos.Id, Processos.Descricao, Processos.Data, CONCAT(Processos.Tempo, ' minuto(s)')  AS 'Tempo', Funcionarios.Nome As 'Funcionario', Clientes.Nome As 'Cliente', Categorias.Nome As 'Categoria' FROM Processos " +
                                            "INNER JOIN Funcionarios ON Funcionarios.Id = Processos.FuncionarioId " +
                                            "INNER JOIN Clientes ON Clientes.Id = Processos.ClienteId " +
                                            "INNER JOIN Categorias ON Categorias.Id = Processos.CategoriaId;");
            }

            if (agruparPorCliente || agruparPorFuncionario)
            {
                datatable = ConverterNumeroMes(database.BuscarDados(stringSql));
            }
            else
            {
                datatable = database.BuscarDados(stringSql);
            }

            return datatable;
        }

        /// <summary>
        /// Recebe uma tabela com os meses em números converte para o nome do mês, 
        /// no final remove a coluna de meses antiga e altera o índice da nova coluna 'Mês'
        /// </summary>
        /// <param name="dataTable"></param>
        /// <returns>DataTable com meses no formato 'Janeiro', 'Fevereiro'...</returns>
        private DataTable ConverterNumeroMes(DataTable dataTable)
        {
            int op;

            DataColumn newcolumn = new DataColumn("Mês");
            dataTable.Columns.Add(newcolumn);

            foreach (DataRow row in dataTable.Rows)
            {

                op = Convert.ToInt16(row[1].ToString());
                string nomeMes;

                switch (op)
                {
                    case 1:
                        nomeMes = "Janeiro";
                        break;
                    case 2:
                        nomeMes = "Fevereiro";
                        break;
                    case 3:
                        nomeMes = "Março";
                        break;
                    case 4:
                        nomeMes = "Abril";
                        break;
                    case 5:
                        nomeMes = "Maio";
                        break;
                    case 6:
                        nomeMes = "Junho";
                        break;
                    case 7:
                        nomeMes = "Julho";
                        break;
                    case 8:
                        nomeMes = "Agosto";
                        break;
                    case 9:
                        nomeMes = "Setembro";
                        break;
                    case 10:
                        nomeMes = "Outubro";
                        break;
                    case 11:
                        nomeMes = "Novembro";
                        break;
                    case 12:
                        nomeMes = "Dezembro";
                        break;
                    default:
                        nomeMes = "Inválido";
                        break;
                }

                row[newcolumn] = nomeMes;

            }

            dataTable.Columns[3].SetOrdinal(1);
            dataTable.Columns.RemoveAt(2);

            return dataTable;
        }
    }
}
