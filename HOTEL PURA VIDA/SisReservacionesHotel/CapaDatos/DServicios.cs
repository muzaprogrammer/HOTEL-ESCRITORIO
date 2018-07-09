using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DServicios
    {
        private int _SER_ID;
        private string _SER_NOMBRE;
        private string _SER_DESCRIPCION;
        private double _SER_PRECIO;
        private string TEXTOBUSCAR;

        public int SER_ID
        {
            get
            {
                return _SER_ID;
            }

            set
            {
                _SER_ID = value;
            }

        }

        public string SER_NOMBRE
        {
            get
            {
                return _SER_NOMBRE;
            }

            set
            {
                _SER_NOMBRE = value;
            }

        }

        public string SER_DESCRIPCION
        {
            get
            {
                return _SER_DESCRIPCION;
            }

            set
            {
                _SER_DESCRIPCION = value;
            }
        }

        public double SER_PRECIO
        {
            get
            {
                return _SER_PRECIO;
            }

            set
            {
                _SER_PRECIO = value;
            }
        }

        public string TEXTOBUSCAR1
        {
            get
            {
                return TEXTOBUSCAR;
            }

            set
            {
                TEXTOBUSCAR = value;
            }
        }

        //METODO VACION

        public DServicios()
        {

        }

        public DServicios(int sER_ID, string sER_NOMBRE, string sER_DESCRIPCION, double sER_PRECIO, string tEXTOBUSCAR1)
        {
            SER_ID = sER_ID;
            SER_NOMBRE = sER_NOMBRE;
            SER_DESCRIPCION = sER_DESCRIPCION;
            SER_PRECIO = sER_PRECIO;
            TEXTOBUSCAR1 = tEXTOBUSCAR1;
        }

        //METODO CON PARAMETROS

        public string InsertarServicio(DServicios servicios)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SER_INSERTAR";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParHabid = new SqlParameter();
                ParHabid.ParameterName = "@SER_ID";
                ParHabid.SqlDbType = SqlDbType.Int;
                ParHabid.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParHabid);

                SqlParameter ParNom = new SqlParameter();
                ParNom.ParameterName = "@SER_NOMBRE";
                ParNom.SqlDbType = SqlDbType.VarChar;
                ParNom.Size = 50;
                ParNom.Value = servicios.SER_NOMBRE;
                SqlCmd.Parameters.Add(ParNom);

                SqlParameter ParDes = new SqlParameter();
                ParDes.ParameterName = "@SER_DESCRIPCION";
                ParDes.SqlDbType = SqlDbType.VarChar;
                ParDes.Size = 50;
                ParDes.Value = servicios.SER_DESCRIPCION;
                SqlCmd.Parameters.Add(ParDes);

                SqlParameter ParPrecio = new SqlParameter();
                ParPrecio.ParameterName = "@SER_PRECIO";
                ParPrecio.SqlDbType = SqlDbType.Money;                
                ParPrecio.Value = servicios.SER_PRECIO;
                SqlCmd.Parameters.Add(ParPrecio);


                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se agrego EL HOTEL correctamente";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }
        public string EliminarServicio(DServicios servicios)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SER_ELIMINAR";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParHabid = new SqlParameter();
                ParHabid.ParameterName = "@SER_ID";
                ParHabid.SqlDbType = SqlDbType.Int;
                ParHabid.Value = servicios.SER_ID;
                SqlCmd.Parameters.Add(ParHabid);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se elimino la Habitacion correctamente";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }
        public DataTable MostrarServicios()
        {
            DataTable DtResultado = new DataTable("SERVICIOS");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SER_MOSTRAR";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                string msm = Convert.ToString(ex);
                DtResultado = null;
            }
            return DtResultado;
        }
        public DataTable BuscarServicios(DServicios servicios)
        {
            DataTable DtResultado = new DataTable("SERVICIOS");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SER_BUSCAR_NOMBRE";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@TEXTOBUSCAR";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = servicios.SER_NOMBRE;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                string msm = Convert.ToString(ex);
                DtResultado = null;
            }
            return DtResultado;
        }
    }
}
