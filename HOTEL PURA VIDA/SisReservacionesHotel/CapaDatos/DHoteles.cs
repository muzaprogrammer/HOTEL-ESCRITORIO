using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DHoteles
    {
        private int _HOT_ID;
        private string _HOT_NOMBRE;
        private string _PAIS;
        private string _TEXTO_BUSCAR1;
        private string _TEXTO_BUSCAR2;

        public int HOT_ID
        {
            get
            {
                return _HOT_ID;
            }

            set
            {
                _HOT_ID = value;
            }
        }

        public string HOT_NOMBRE
        {
            get
            {
                return _HOT_NOMBRE;
            }

            set
            {
                _HOT_NOMBRE = value;
            }
        }

        public string PAIS
        {
            get
            {
                return _PAIS;
            }

            set
            {
                _PAIS = value;
            }
        }

        public string TEXTO_BUSCAR1
        {
            get
            {
                return _TEXTO_BUSCAR1;
            }

            set
            {
                _TEXTO_BUSCAR1 = value;
            }
        }

        public string TEXTO_BUSCAR2
        {
            get
            {
                return _TEXTO_BUSCAR2;
            }

            set
            {
                _TEXTO_BUSCAR2 = value;
            }
        }
        public DHoteles()
        {

        }
        public DHoteles(int hot_id, string nombre,  string pais, string textobuscar1, string textobuscar2)
        {
            HOT_ID = hot_id;
            HOT_NOMBRE = nombre;
            PAIS = pais;
            TEXTO_BUSCAR1 = textobuscar1;
            TEXTO_BUSCAR2 = textobuscar2;
        }
        public string InsertarHotel(DHoteles Hotel)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "HOT_INSERT";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParHabid = new SqlParameter();
                ParHabid.ParameterName = "@ID";
                ParHabid.SqlDbType = SqlDbType.Int;
                ParHabid.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParHabid);

                SqlParameter ParNom = new SqlParameter();
                ParNom.ParameterName = "@NOMBRE";
                ParNom.SqlDbType = SqlDbType.VarChar;
                ParNom.Size = 50;
                ParNom.Value = Hotel.HOT_NOMBRE;
                SqlCmd.Parameters.Add(ParNom);

                SqlParameter ParHabNum = new SqlParameter();
                ParHabNum.ParameterName = "@PAIS";
                ParHabNum.SqlDbType = SqlDbType.VarChar;
                ParHabNum.Size = 50;
                ParHabNum.Value = Hotel.PAIS;
                SqlCmd.Parameters.Add(ParHabNum);
                

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
        public string EliminarHotel(DHoteles HOTEL)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "HOT_ELIMINAR";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParHabid = new SqlParameter();
                ParHabid.ParameterName = "@ID";
                ParHabid.SqlDbType = SqlDbType.Int;
                ParHabid.Value = HOTEL.HOT_ID;
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
        public DataTable MostrarHoteles()
        {
            DataTable DtResultado = new DataTable("HOTELES");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "HOT_MOSTRAR";
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
        public DataTable BuscarHotel(DHoteles Hotel)
        {
            DataTable DtResultado = new DataTable("HOTELES");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "HOT_BUCAR";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@NOMBRE";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Hotel.TEXTO_BUSCAR1;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlParameter ParTextoBuscar2 = new SqlParameter();
                ParTextoBuscar2.ParameterName = "@PAIS";
                ParTextoBuscar2.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar2.Size = 50;
                ParTextoBuscar2.Value = Hotel.TEXTO_BUSCAR2;
                SqlCmd.Parameters.Add(ParTextoBuscar2);

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
