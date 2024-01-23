using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClixFelippeWidjaHugo
{
    internal class Database
    {
        private string str_connection = ConfigurationManager.ConnectionStrings["Lagostim"].ConnectionString;

        public DataTable BuscarDados(string str_sql)
        {
            SqlConnection connection = new SqlConnection(str_connection);
            connection.Open();

            SqlCommand command = new SqlCommand(str_sql, connection);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();

            dataAdapter.Fill(dataTable);
            dataAdapter.Dispose();

            connection.Close();

            return dataTable;
        }

        public int ExecutarComando(string str_sql) 
        {

            SqlConnection connection = new SqlConnection(str_connection);
            connection.Open();

            SqlCommand command = new SqlCommand(str_sql, connection);

            if(command.ExecuteNonQuery() > 0)
            {
                connection.Close();
                return 1;
            }
            else
            {
                connection.Close();
                return -1;
            }
        }

        public void FazerBackup(string mensagem)
        {
            string dataHora = DateTime.Now.ToString("yyyyMMddHHmmss");
            string stringSql = "Backup database bdClixFelippeWidjaHugo to disk='C:\\EFA240108\\" + mensagem + dataHora + ".bak;'";
            
            ExecutarComando(stringSql);
        }
    }
}
