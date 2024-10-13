using AdministracionTienda.Datos;
using System.Data;

namespace AdministracionTienda.Negocios
{
    internal class Negocio
    {
        public class UserBusiness
        {
            private BaseDatos.Conexion db;

            public UserBusiness()
            {
                db = new BaseDatos.Conexion();
            }

            // Método para verificar el login de un usuario
            public bool Login(string username, string password)
            {
                string query = $"SELECT * FROM Login WHERE User = 'Admin' AND Pass = '1234'"; 
                DataTable result = db.ExecuteQuery(query);
               
                if (result.Rows.Count > 0)
                {
                    // Usuario encontrado
                    return true;
                }

                // Usuario no encontrado
                return false;
            }

        }
    }
}
