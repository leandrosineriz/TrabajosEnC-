using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ClaseVeinte.Library
{
    public class ProveedorDeDatos
    {
        public SqlConnection sqlConnection;
        //  public SqlCommand sqlCommand;

        public ProveedorDeDatos()
        {
            try
            {
                //this.sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\alumno\Desktop\DATA\Padron.mdf;Integrated Security=True;Connect Timeout=30");
                this.sqlConnection = new SqlConnection(Properties.Settings.Default.Conexion);
                //this.sqlConnection.Open(); estar conectado todo el tiempo da problemas de performance
                // this.sqlCommand = new SqlCommand();
            }
            catch (Exception)
            {

            }


        }

        //Agrega algunas personas a una lista
        public static List<Persona> ObtenerPersonaHC()
        {
            Persona pers1 = new Persona(1, "Pepe", "Argento", 44);
            Persona pers2 = new Persona(2, "Juan", "Lopez", 33);
            Persona pers3 = new Persona(3, "Laura", "Argento", 22);
            Persona pers4 = new Persona(4, "Juan", "Putin", 55);

            List<Persona> auxPersonas = new List<Persona>();

            auxPersonas.Add(pers1);
            auxPersonas.Add(pers2);
            auxPersonas.Add(pers3);
            auxPersonas.Add(pers4);

            return auxPersonas;
        }

        public DataTable ObtenerPersonaBD(bool condicion)
        { 
            DataTable retorno = null;

              retorno = new DataTable("Personas");

                SqlCommand sc = new SqlCommand();
                sc.Connection = this.sqlConnection;
                sc.CommandType = CommandType.Text;
                sc.CommandText = "SELECT Id,Nombre,Apellido,Edad FROM Personas";
                sqlConnection.Open();

                SqlDataReader dr = sc.ExecuteReader();

                retorno.Load(dr);

                dr.Close();

                sqlConnection.Close();

           


            return retorno;
        }

        public List<Persona> ObtenerPersonaBD()
        {
            List<Persona> auxPersonas = new List<Persona>();

            try
            {
                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.Connection = this.sqlConnection;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "SELECT Id,Nombre,Apellido,Edad FROM Personas";
                //sqlCommand.CommandText = "SELECT * FROM Personas"; *==todo

                sqlConnection.Open();
                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    //auxPersonas.Add(new Persona((int)dataReader[0], dataReader[1].ToString(), dataReader[2].ToString(), (int)dataReader[3]));
                    auxPersonas.Add(new Persona((int)dataReader["Id"], dataReader["Nombre"].ToString(), dataReader["Apellido"].ToString(), (int)dataReader["Edad"]));
                }
                sqlConnection.Close();

            }
            catch (Exception)
            {


            }


            return auxPersonas;
        }

        public Persona ObtenerPersonaPorIDBD(int id)
        {

            Persona retorno = null;

            SqlCommand sc = new SqlCommand();

            sc.Connection = this.sqlConnection;
            sc.CommandType = CommandType.Text;
            sc.CommandText = "SELECT * FROM Personas WHERE Id=" + id;
            this.sqlConnection.Open();
            SqlDataReader dr = sc.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                retorno = new Persona((int)dr["Id"], dr["Nombre"].ToString(), dr["Apellido"].ToString(), (int)dr["Edad"]);

            }

            this.sqlConnection.Close();
            return retorno;
        }
        //llamada a ObtenerPersona
        public static Persona ObtenerPersonaPorID(int id)
        {
            List<Persona> auxPersonas = ObtenerPersonaHC();

            Persona retorno = null;

            foreach (Persona i in auxPersonas)
            {
                if (i.id == id)
                {
                    retorno = i;
                    break;
                }

            }

            return retorno;
        }

        public bool AgregarPersonaBD(DataRow persona)
        {
            bool retorno = true;

            try
            {
                ProveedorDeDatos prov= new ProveedorDeDatos();
                DataTable dt=new DataTable("Personas");
                dt = prov.ObtenerPersonaBD(true);

                dt.Rows.Add(persona);

            }
            catch (Exception)
            {
                              
            }

            return retorno;
        }


        public bool AgregarPersonaBD(Persona persona)
        {
            bool retorno = false;

            try
            {
                SqlCommand sc = new SqlCommand();
                sc.Connection = this.sqlConnection;
                sc.CommandType = CommandType.Text;
                sc.CommandText = "INSERT INTO Personas (Nombre,Apellido,Edad) VALUES('" + persona.nombre + "','" + persona.apellido + "','" + persona.edad + "')";
                this.sqlConnection.Open();
                sc.ExecuteNonQuery();
                retorno = true;
                this.sqlConnection.Close();
            }
            catch (Exception)
            {


            }
            return retorno;

        }
        public static bool AgregarPersona(Persona persona)
        {

            List<Persona> auxPersonas = ObtenerPersonaHC();

            auxPersonas.Add(persona);

            return true;
        }

        public static bool ModificarPersona(Persona persona)
        {
            bool retorno = true;
            List<Persona> auxPersonas = ObtenerPersonaHC();

            try
            {
                auxPersonas[auxPersonas.IndexOf(ObtenerPersonaPorID(persona.id))] = persona;

            }
            catch (Exception)
            {
                retorno = false;

            }


            return retorno;
        }

        public bool ModificarPersonaBD(Persona persona)
        {
            bool retorno = false;
            try
            {
                SqlCommand sc = new SqlCommand();
                sc.CommandType = CommandType.Text;
                sc.CommandText = "UPDATE Personas SET Nombre='" + persona.nombre + "',Apellido='" + persona.apellido + "',Edad=" + persona.edad + " WHERE ID=" + persona.id;
                sc.Connection = this.sqlConnection;

                sqlConnection.Open();

                sc.ExecuteNonQuery();

                sqlConnection.Close();

                retorno = true;

            }
            catch (Exception)
            {


            }

            return retorno;
        }
        public static bool EliminarPersona(Persona persona)
        {
            List<Persona> auxPersonas = ObtenerPersonaHC();

            auxPersonas.Remove(ObtenerPersonaPorID(persona.id));

            return false;
        }

        public bool EliminarPersonaBD(Persona persona)
        {
            bool retorno = false;
            try
            {
                SqlCommand sc = new SqlCommand();
                sc.Connection = this.sqlConnection;
                sc.CommandType = CommandType.Text;
                sc.CommandText = "DELETE FROM Personas WHERE Id=" + persona.id;
                this.sqlConnection.Open();
                sc.ExecuteNonQuery();
                this.sqlConnection.Close();
                retorno = true;
            }
            catch (Exception)
            {


            }


            return retorno;
        }

    }
}
