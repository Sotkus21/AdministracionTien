using System;
using System.Data;
using System.Data.OleDb;

namespace AdministracionTienda.Datos
{
    internal class BaseDatos
    {
        public class Conexion
        {

            private OleDbConnection connection;


            public Conexion()
            {

                string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\AdministracionTienda1.accdb";
                connection = new OleDbConnection(connectionString);

            }

            public void OpenConnection()
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
            }

            public void CloseConnection()
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            public DataTable ExecuteQuery(string query)
            {
                DataTable dataTable = new DataTable();
                try
                {
                    OpenConnection();
                    OleDbCommand command = new OleDbCommand(query, connection);
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                    adapter.Fill(dataTable);
                }

                catch (Exception ex)
                {
                    throw new Exception("Error al ejecutar la consulta: " + ex.Message);
                }
                finally
                {
                    CloseConnection();
                }
                return dataTable;
            }

        }
    }
}
