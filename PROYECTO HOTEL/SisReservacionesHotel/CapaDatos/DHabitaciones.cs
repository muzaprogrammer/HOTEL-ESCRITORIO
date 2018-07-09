using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class DHabitaciones
    {
        private int _Id;
        private int _NumHab;
        private int _Piso;
        private string _Tipo;
        private int _NumCamas;
        private double _Precio;
        private string _Estado;
        private int _HotelId;
        private string _TextoBuscar;        

        public int Id
        {
            get
            {
                return _Id;
            }

            set
            {
                _Id = value;
            }
        }

        public int NumHab
        {
            get
            {
                return _NumHab;
            }

            set
            {
                _NumHab = value;
            }
        }

        public int Piso
        {
            get
            {
                return _Piso;
            }

            set
            {
                _Piso = value;
            }
        }

        public string Tipo
        {
            get
            {
                return _Tipo;
            }

            set
            {
                _Tipo = value;
            }
        }

        public int NumCamas
        {
            get
            {
                return _NumCamas;
            }

            set
            {
                _NumCamas = value;
            }
        }

        public double Precio
        {
            get
            {
                return _Precio;
            }

            set
            {
                _Precio = value;
            }
        }

        public string Estado
        {
            get
            {
                return _Estado;
            }

            set
            {
                _Estado = value;
            }
        }

        public int HotelId
        {
            get
            {
                return _HotelId;
            }

            set
            {
                _HotelId = value;
            }
        }

        public string TextoBuscar
        {
            get
            {
                return _TextoBuscar;
            }

            set
            {
                _TextoBuscar = value;
            }
        }
        public DHabitaciones()
        {

        }
        public DHabitaciones(int id, int numHab, int piso, string tipo, int numCamas, double precio, string estado, int hotelId, string textoBuscar)
        {
            Id = id;
            NumHab = numHab;
            Piso = piso;
            Tipo = tipo;
            NumCamas = numCamas;
            Precio = precio;
            Estado = estado;
            HotelId = hotelId;
            TextoBuscar = textoBuscar;
        }
        public string InsertarHabitacion(DHabitaciones Habitaciones)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "HAB_INSERTAR";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParHabid = new SqlParameter();
                ParHabid.ParameterName = "@ID";
                ParHabid.SqlDbType = SqlDbType.Int;
                ParHabid.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParHabid);

                SqlParameter ParHabNum = new SqlParameter();
                ParHabNum.ParameterName = "@NUM";
                ParHabNum.SqlDbType = SqlDbType.Int;
                ParHabNum.Value = Habitaciones.NumHab;
                SqlCmd.Parameters.Add(ParHabNum);

                SqlParameter ParHabPiso = new SqlParameter();
                ParHabPiso.ParameterName = "@PISO";
                ParHabPiso.SqlDbType = SqlDbType.Int;
                ParHabPiso.Value = Habitaciones.Piso;
                SqlCmd.Parameters.Add(ParHabPiso);

                SqlParameter ParHabTipo = new SqlParameter();
                ParHabTipo.ParameterName = "@TIPO";
                ParHabTipo.SqlDbType = SqlDbType.VarChar;
                ParHabTipo.Size = 50;
                ParHabTipo.Value = Habitaciones.Tipo;
                SqlCmd.Parameters.Add(ParHabTipo);

                SqlParameter ParHabNumCamas = new SqlParameter();
                ParHabNumCamas.ParameterName = "@NUMCAMAS";
                ParHabNumCamas.SqlDbType = SqlDbType.Int;
                ParHabNumCamas.Value = Habitaciones.NumCamas;
                SqlCmd.Parameters.Add(ParHabNumCamas);

                SqlParameter ParHabPrecio = new SqlParameter();
                ParHabPrecio.ParameterName = "@PRECIO";
                ParHabPrecio.SqlDbType = SqlDbType.Money;
                ParHabPrecio.Value = Habitaciones.Precio;
                SqlCmd.Parameters.Add(ParHabPrecio);

                SqlParameter ParHabEstado = new SqlParameter();
                ParHabEstado.ParameterName = "@ESTADO";
                ParHabEstado.SqlDbType = SqlDbType.VarChar;
                ParHabEstado.Size = 15;
                ParHabEstado.Value = Habitaciones.Estado;
                SqlCmd.Parameters.Add(ParHabEstado);

                SqlParameter ParHotelId = new SqlParameter();
                ParHotelId.ParameterName = "@HOTEL";
                ParHotelId.SqlDbType = SqlDbType.Int;
                ParHotelId.Value = Habitaciones.HotelId;
                SqlCmd.Parameters.Add(ParHotelId);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se agrego la Habitacion correctamente";
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
        public string EditarHabitacion(DHabitaciones Habitaciones)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "HAB_EDITAR";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParHabid = new SqlParameter();
                ParHabid.ParameterName = "@ID";
                ParHabid.SqlDbType = SqlDbType.Int;
                ParHabid.Value = Habitaciones.Id;
                SqlCmd.Parameters.Add(ParHabid);

                SqlParameter ParHabNum = new SqlParameter();
                ParHabNum.ParameterName = "@NUM";
                ParHabNum.SqlDbType = SqlDbType.Int;
                ParHabNum.Value = Habitaciones.NumHab;
                SqlCmd.Parameters.Add(ParHabNum);

                SqlParameter ParHabPiso = new SqlParameter();
                ParHabPiso.ParameterName = "@PISO";
                ParHabPiso.SqlDbType = SqlDbType.Int;
                ParHabPiso.Value = Habitaciones.Piso;
                SqlCmd.Parameters.Add(ParHabPiso);

                SqlParameter ParHabTipo = new SqlParameter();
                ParHabTipo.ParameterName = "@TIPO";
                ParHabTipo.SqlDbType = SqlDbType.VarChar;
                ParHabTipo.Size = 50;
                ParHabTipo.Value = Habitaciones.Tipo;
                SqlCmd.Parameters.Add(ParHabTipo);

                SqlParameter ParHabNumCamas = new SqlParameter();
                ParHabNumCamas.ParameterName = "@NUMCAMAS";
                ParHabNumCamas.SqlDbType = SqlDbType.Int;
                ParHabNumCamas.Value = Habitaciones.NumCamas;
                SqlCmd.Parameters.Add(ParHabNumCamas);

                SqlParameter ParHabPrecio = new SqlParameter();
                ParHabPrecio.ParameterName = "@PRECIO";
                ParHabPrecio.SqlDbType = SqlDbType.Money;
                ParHabPrecio.Value = Habitaciones.Precio;
                SqlCmd.Parameters.Add(ParHabPrecio);

                SqlParameter ParHabEstado = new SqlParameter();
                ParHabEstado.ParameterName = "@ESTADO";
                ParHabEstado.SqlDbType = SqlDbType.VarChar;
                ParHabEstado.Size = 15;
                ParHabEstado.Value = Habitaciones.Estado;
                SqlCmd.Parameters.Add(ParHabEstado);

                SqlParameter ParHotelId = new SqlParameter();
                ParHotelId.ParameterName = "@HOTEL";
                ParHotelId.SqlDbType = SqlDbType.Int;
                ParHotelId.Value = Habitaciones.HotelId;
                SqlCmd.Parameters.Add(ParHotelId);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se edito la Habitacion correctamente";
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
        public string EliminarHabitacion(DHabitaciones Habitaciones)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "HAB_ELIMINAR";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParHabid = new SqlParameter();
                ParHabid.ParameterName = "@ID";
                ParHabid.SqlDbType = SqlDbType.Int;
                ParHabid.Value = Habitaciones.Id;
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
        public DataTable MostrarTodasLasHabitaciones()
        {
            DataTable DtResultado = new DataTable("HABITACIONES");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "HAB_MOSTRAR";
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
        public DataTable MostrarHabitacionesPrecioMax()
        {
            DataTable DtResultado = new DataTable("HABITACIONES");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "HAB_MOSTRAR_PRECIO_MAX";
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
        public DataTable MostrarHabitacionesPrecioMin()
        {
            DataTable DtResultado = new DataTable("HABITACIONES");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "HAB_MOSTRAR_PRECIO_MIN";
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
        public DataTable BuscarHabTipo(DHabitaciones Habitaciones)
        {
            DataTable DtResultado = new DataTable("HABITACIONES");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "HAB_MOSTRAR_TIPO";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                                
                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@TEXTOBUSCAR";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Habitaciones.TextoBuscar;
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
        public DataTable BuscarHabNUm(DHabitaciones Habitaciones)
        {
            DataTable DtResultado = new DataTable("HABITACIONES");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "HAB_MOSTRAR_NUM";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                Convert.ToInt32(TextoBuscar);
                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@TEXTOBUSCAR";
                ParTextoBuscar.SqlDbType = SqlDbType.Int;                
                ParTextoBuscar.Value = Habitaciones.TextoBuscar;
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
