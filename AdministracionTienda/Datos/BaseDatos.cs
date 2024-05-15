using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionTienda.Datos
{
    internal class BaseDatos
    {
        public class Conexion
        {
            //declaracion de variables privadas
            private string Base;
            private string Servidor;
            private string Usuario;
            private string Clave;
            private bool Seguridad;

            //Creacion de objeto estatico con instacia para la conexion

            private static Conexion con = null;

            //creacion de constructores (conexion a la BD)

            private Conexion()
            {
                this.Base = "demo_db";
                this.Servidor = "DESKTOP-MUG64SS";
                this.Usuario = "sa";
                this.Clave = "Libertad30";
                this.Seguridad = true;

            }
            //Definir el tipo de medos para utilizar la conexion y la BD
            public SqlConnection crearConexion()
            {
                SqlConnection cadena = new SqlConnection();
                try //incia el procedimiento
                {
                    cadena.ConnectionString = "Server" + this.Servidor + "; Database=" + this.Base + ";";
                    if (this.Seguridad)
                    {
                        // es autetincacion de windows
                        cadena.ConnectionString = cadena.ConnectionString + "Integrate Security = SSPI";
                    }
                    else
                    {
                        // es autetincacion de Super Admin de SQL
                        cadena.ConnectionString = cadena.ConnectionString + "UserId =" + this.Usuario + "; Password =" + this.Clave;
                    }

                }
                catch (Exception ex) //visualizacion de errores
                {
                    cadena = null;
                    throw ex;
                }

                return cadena;

            }

            public static Conexion getIntancia()
            {
                if (con == null)
                {
                    con = new Conexion();
                }
                return con;
            }

        }
    }
}
