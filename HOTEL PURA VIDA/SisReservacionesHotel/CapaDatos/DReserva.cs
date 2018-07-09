using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DReserva
    {
        private int _RES_ID;
        private int _HAB_ID;
        private int _CLI_ID;
        private int _EMP_ID;
        private string _ESTADO_HAB;
        private DateTime _FECHA_RESERVACION;
        private DateTime _CHECKIN;
        private DateTime _CHECKOUT;
        private int _N_NOCHES;
        private double _COSTO_NOCHES;
        private double _COSTO_TOTAL;
        private string _ESTADO_PAGO;
        private string _OBSERVACIONES;
        private string _TEXTO_BUSCAR1;
        private string _TEXTO_BUSCAR2;
        private string _TEXTO_BUSCAR3;

        public int RES_ID
        {
            get
            {
                return _RES_ID;
            }

            set
            {
                _RES_ID = value;
            }
        }

        public int HAB_ID
        {
            get
            {
                return _HAB_ID;
            }

            set
            {
                _HAB_ID = value;
            }
        }

        public int CLI_ID
        {
            get
            {
                return _CLI_ID;
            }

            set
            {
                _CLI_ID = value;
            }
        }

        public int EMP_ID
        {
            get
            {
                return _EMP_ID;
            }

            set
            {
                _EMP_ID = value;
            }
        }

        public string ESTADO_HAB
        {
            get
            {
                return _ESTADO_HAB;
            }

            set
            {
                _ESTADO_HAB = value;
            }
        }

        public DateTime FECHA_RESERVACION
        {
            get
            {
                return _FECHA_RESERVACION;
            }

            set
            {
                _FECHA_RESERVACION = value;
            }
        }

        public DateTime CHECKIN
        {
            get
            {
                return _CHECKIN;
            }

            set
            {
                _CHECKIN = value;
            }
        }

        public DateTime CHECKOUT
        {
            get
            {
                return _CHECKOUT;
            }

            set
            {
                _CHECKOUT = value;
            }
        }

        public int N_NOCHES
        {
            get
            {
                return _N_NOCHES;
            }

            set
            {
                _N_NOCHES = value;
            }
        }

        public double COSTO_NOCHES
        {
            get
            {
                return _COSTO_NOCHES;
            }

            set
            {
                _COSTO_NOCHES = value;
            }
        }

        public double COSTO_TOTAL
        {
            get
            {
                return _COSTO_TOTAL;
            }

            set
            {
                _COSTO_TOTAL = value;
            }
        }

        public string ESTADO_PAGO
        {
            get
            {
                return _ESTADO_PAGO;
            }

            set
            {
                _ESTADO_PAGO = value;
            }
        }

        public string OBSERVACIONES
        {
            get
            {
                return _OBSERVACIONES;
            }

            set
            {
                _OBSERVACIONES = value;
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

        public string TEXTO_BUSCAR3
        {
            get
            {
                return _TEXTO_BUSCAR3;
            }

            set
            {
                _TEXTO_BUSCAR3 = value;
            }
        }

        public DReserva()
        {

        }

        public DReserva(int rES_ID, int hAB_ID, int cLI_ID, int eMP_ID, string eSTADO_HAB, DateTime fECHA_RESERVACION, DateTime cHECKIN, DateTime cHECKOUT, int n_NOCHES, double cOSTO_NOCHES, double cOSTO_TOTAL, string eSTADO_PAGO, string oBSERVACIONES, string tEXTO_BUSCAR1, string tEXTO_BUSCAR2, string tEXTO_BUSCAR3)
        {
            RES_ID = rES_ID;
            HAB_ID = hAB_ID;
            CLI_ID = cLI_ID;
            EMP_ID = eMP_ID;
            ESTADO_HAB = eSTADO_HAB;
            FECHA_RESERVACION = fECHA_RESERVACION;
            CHECKIN = cHECKIN;
            CHECKOUT = cHECKOUT;
            N_NOCHES = n_NOCHES;
            COSTO_NOCHES = cOSTO_NOCHES;
            COSTO_TOTAL = cOSTO_TOTAL;
            ESTADO_PAGO = eSTADO_PAGO;
            OBSERVACIONES = oBSERVACIONES;
            TEXTO_BUSCAR1 = tEXTO_BUSCAR1;
            TEXTO_BUSCAR2 = tEXTO_BUSCAR2;
            TEXTO_BUSCAR3 = tEXTO_BUSCAR3;
        }
        public DataTable MostrarHabsDisponible(DReserva Disponibilidad)
        {
            DataTable DtResultado = new DataTable("HABITACIONES");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "RES_HAB_DISPONIBLE";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Convert.ToDateTime(TEXTO_BUSCAR1);
                SqlParameter ParInicio = new SqlParameter();
                ParInicio.ParameterName = "@FECHA_INICIO";
                ParInicio.SqlDbType = SqlDbType.Date;
                ParInicio.Value = Disponibilidad.CHECKIN.Date;
                SqlCmd.Parameters.Add(ParInicio);

                //Convert.ToDateTime(TEXTO_BUSCAR2);
                SqlParameter ParFin= new SqlParameter();
                ParFin.ParameterName = "@FECHA_FIN";
                ParFin.SqlDbType = SqlDbType.Date;
                ParFin.Value = Disponibilidad.CHECKOUT.Date;
                SqlCmd.Parameters.Add(ParFin);

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
       
        public DataTable MostrarNoHabsDisponible(DReserva Disponibilidad)
        {
            DataTable DtResultado = new DataTable("HABITACIONES, RESERVA, CLIENTES");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "RES_HAB_NO_DISPONIBLE";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                                
                SqlParameter ParInicio = new SqlParameter();
                ParInicio.ParameterName = "@FECHA_INICIO";
                ParInicio.SqlDbType = SqlDbType.Date;
                ParInicio.Value = Disponibilidad.CHECKIN.Date;
                SqlCmd.Parameters.Add(ParInicio);
                               
                SqlParameter ParFin = new SqlParameter();
                ParFin.ParameterName = "@FECHA_FIN";
                ParFin.SqlDbType = SqlDbType.Date;
                ParFin.Value = Disponibilidad.CHECKOUT.Date;
                SqlCmd.Parameters.Add(ParFin);
                
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
        public DataTable BuscarResNomCli(DReserva Disponibilidad)
        {
            DataTable DtResultado = new DataTable("HABITACIONES, RESERVA, CLIENTES");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "RES_BUSCAR_CLIENTE";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                                
                SqlParameter ParNom = new SqlParameter();
                ParNom.ParameterName = "@NOMBRES";
                ParNom.SqlDbType = SqlDbType.VarChar;
                ParNom.Size = 50;
                ParNom.Value = Disponibilidad.TEXTO_BUSCAR1;
                SqlCmd.Parameters.Add(ParNom);

                //Convert.ToDateTime(TEXTO_BUSCAR2);
                SqlParameter ParFin = new SqlParameter();
                ParFin.ParameterName = "@APELLIDO";
                ParFin.SqlDbType = SqlDbType.VarChar;
                ParNom.Size = 50;
                ParFin.Value = Disponibilidad.TEXTO_BUSCAR2;
                SqlCmd.Parameters.Add(ParFin);

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
        public DataTable BuscarPaisCli(DReserva Disponibilidad)
        {
            DataTable DtResultado = new DataTable("HABITACIONES, RESERVA, CLIENTES");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "RES_BUSCAR_PAIS";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNom = new SqlParameter();
                ParNom.ParameterName = "@TEXTOBUSCAR1";
                ParNom.SqlDbType = SqlDbType.VarChar;
                ParNom.Size = 50;
                ParNom.Value = Disponibilidad.TEXTO_BUSCAR1;
                SqlCmd.Parameters.Add(ParNom);
                                
                SqlParameter ParFin = new SqlParameter();
                ParFin.ParameterName = "@TEXTOBUSCAR2";
                ParFin.SqlDbType = SqlDbType.VarChar;
                ParNom.Size = 50;
                ParFin.Value = Disponibilidad.TEXTO_BUSCAR2;
                SqlCmd.Parameters.Add(ParFin);

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


        public string Insertarreserva(DReserva Reserva)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "RES_INSERTAR";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParResid = new SqlParameter();
                ParResid.ParameterName = "@RES_ID";
                ParResid.SqlDbType = SqlDbType.Int;
                ParResid.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParResid);

                SqlParameter ParHabid = new SqlParameter();
                ParHabid.ParameterName = "@HAB_ID";
                ParHabid.SqlDbType = SqlDbType.Int;
                ParHabid.Value = Reserva.HAB_ID;
                SqlCmd.Parameters.Add(ParHabid);

                SqlParameter ParCliid = new SqlParameter();
                ParCliid.ParameterName = "@CLI_ID";
                ParCliid.SqlDbType = SqlDbType.Int;
                ParCliid.Value = Reserva.CLI_ID;
                SqlCmd.Parameters.Add(ParCliid);

                SqlParameter ParEmpbid = new SqlParameter();
                ParEmpbid.ParameterName = "@EMP_ID";
                ParEmpbid.SqlDbType = SqlDbType.Int;
                ParEmpbid.Value = Reserva.EMP_ID;
                SqlCmd.Parameters.Add(ParEmpbid);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@ESTADO";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 50;
                ParEstado.Value = Reserva.ESTADO_HAB;
                SqlCmd.Parameters.Add(ParEstado);

                SqlParameter ParFeRes = new SqlParameter();
                ParFeRes.ParameterName = "@FECHA_RESERVACION";
                ParFeRes.SqlDbType = SqlDbType.Date;
                ParFeRes.Value = Reserva.FECHA_RESERVACION;
                SqlCmd.Parameters.Add(ParFeRes);

                SqlParameter ParChckin = new SqlParameter();
                ParChckin.ParameterName = "@CHECKIN";
                ParChckin.SqlDbType = SqlDbType.Date;
                ParChckin.Value = Reserva.CHECKIN;
                SqlCmd.Parameters.Add(ParChckin);

                SqlParameter ParChckout = new SqlParameter();
                ParChckout.ParameterName = "@CHECKOUT";
                ParChckout.SqlDbType = SqlDbType.Date;
                ParChckout.Value = Reserva.CHECKOUT;
                SqlCmd.Parameters.Add(ParChckout);

                SqlParameter ParNoNoches= new SqlParameter();
                ParNoNoches.ParameterName = "@N_NOCHES";
                ParNoNoches.SqlDbType = SqlDbType.Int;
                ParNoNoches.Value = Reserva.N_NOCHES;
                SqlCmd.Parameters.Add(ParNoNoches);

                SqlParameter ParCostHab = new SqlParameter();
                ParCostHab.ParameterName = "@COSTO_HAB";
                ParCostHab.SqlDbType = SqlDbType.Money;
                ParCostHab.Value = Reserva.COSTO_NOCHES;
                SqlCmd.Parameters.Add(ParCostHab);

                SqlParameter ParCostaloj = new SqlParameter();
                ParCostaloj.ParameterName = "@TOTAL";
                ParCostaloj.SqlDbType = SqlDbType.Money;
                ParCostaloj.Value = Reserva.COSTO_TOTAL;
                SqlCmd.Parameters.Add(ParCostaloj);

                SqlParameter ParEstPago = new SqlParameter();
                ParEstPago.ParameterName = "@ESTADO_PAGO";
                ParEstPago.SqlDbType = SqlDbType.VarChar;
                ParEstPago.Size = 50;
                ParEstPago.Value = Reserva.ESTADO_PAGO;
                SqlCmd.Parameters.Add(ParEstPago);

                SqlParameter ParObsr = new SqlParameter();
                ParObsr.ParameterName = "@OBSERVACIONES";
                ParObsr.SqlDbType = SqlDbType.VarChar;
                ParObsr.Size = 600;
                ParObsr.Value = Reserva.OBSERVACIONES;
                SqlCmd.Parameters.Add(ParObsr);
                                
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se realizo la reserva correctamente";
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

        public string Editarreserva(DReserva Reserva)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "RES_EDITAR";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParResid = new SqlParameter();
                ParResid.ParameterName = "@RES_ID";
                ParResid.SqlDbType = SqlDbType.Int;
                ParResid.Value = Reserva.RES_ID;
                SqlCmd.Parameters.Add(ParResid);

                SqlParameter ParHabid = new SqlParameter();
                ParHabid.ParameterName = "@HAB_ID";
                ParHabid.SqlDbType = SqlDbType.Int;
                ParHabid.Value = Reserva.HAB_ID;
                SqlCmd.Parameters.Add(ParHabid);

                SqlParameter ParCliid = new SqlParameter();
                ParCliid.ParameterName = "@CLI_ID";
                ParCliid.SqlDbType = SqlDbType.Int;
                ParCliid.Value = Reserva.CLI_ID;
                SqlCmd.Parameters.Add(ParCliid);

                SqlParameter ParEmpbid = new SqlParameter();
                ParEmpbid.ParameterName = "@EMP_ID";
                ParEmpbid.SqlDbType = SqlDbType.Int;
                ParEmpbid.Value = Reserva.EMP_ID;
                SqlCmd.Parameters.Add(ParEmpbid);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@ESTADO";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 50;
                ParEstado.Value = Reserva.ESTADO_HAB;
                SqlCmd.Parameters.Add(ParEstado);

                SqlParameter ParFeRes = new SqlParameter();
                ParFeRes.ParameterName = "@FECHA_RESERVACION";
                ParFeRes.SqlDbType = SqlDbType.Date;
                ParFeRes.Value = Reserva.FECHA_RESERVACION;
                SqlCmd.Parameters.Add(ParFeRes);

                SqlParameter ParChckin = new SqlParameter();
                ParChckin.ParameterName = "@CHECKIN";
                ParChckin.SqlDbType = SqlDbType.Date;
                ParChckin.Value = Reserva.CHECKIN;
                SqlCmd.Parameters.Add(ParChckin);

                SqlParameter ParChckout = new SqlParameter();
                ParChckout.ParameterName = "@CHECKOUT";
                ParChckout.SqlDbType = SqlDbType.Date;
                ParChckout.Value = Reserva.CHECKOUT;
                SqlCmd.Parameters.Add(ParChckout);

                SqlParameter ParNoNoches = new SqlParameter();
                ParNoNoches.ParameterName = "@N_NOCHES";
                ParNoNoches.SqlDbType = SqlDbType.Int;
                ParNoNoches.Value = Reserva.N_NOCHES;
                SqlCmd.Parameters.Add(ParNoNoches);

                SqlParameter ParCostHab = new SqlParameter();
                ParCostHab.ParameterName = "@COSTO_HAB";
                ParCostHab.SqlDbType = SqlDbType.Money;
                ParCostHab.Value = Reserva.COSTO_NOCHES;
                SqlCmd.Parameters.Add(ParCostHab);

                SqlParameter ParCostaloj = new SqlParameter();
                ParCostaloj.ParameterName = "@TOTAL";
                ParCostaloj.SqlDbType = SqlDbType.Money;
                ParCostaloj.Value = Reserva.COSTO_TOTAL;
                SqlCmd.Parameters.Add(ParCostaloj);

                SqlParameter ParEstPago = new SqlParameter();
                ParEstPago.ParameterName = "@ESTADO_PAGO";
                ParEstPago.SqlDbType = SqlDbType.VarChar;
                ParEstPago.Size = 50;
                ParEstPago.Value = Reserva.ESTADO_PAGO;
                SqlCmd.Parameters.Add(ParEstPago);

                SqlParameter ParObsr = new SqlParameter();
                ParObsr.ParameterName = "@OBSERVACIONES";
                ParObsr.SqlDbType = SqlDbType.VarChar;
                ParObsr.Size = 600;
                ParObsr.Value = Reserva.OBSERVACIONES;
                SqlCmd.Parameters.Add(ParObsr);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se realizo la reserva correctamente";
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

        public string Eliminarreserva(DReserva Reserva)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "RES_ELIMINAR";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParResid = new SqlParameter();
                ParResid.ParameterName = "@TEXTO_BUSCAR";
                ParResid.SqlDbType = SqlDbType.Int;
                ParResid.Value = Reserva.RES_ID;
                SqlCmd.Parameters.Add(ParResid);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se elimino la Reserva correctamente";
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
        public DataTable MostrarReserva()
        {
            DataTable DtResultado = new DataTable("RESERVA");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "RES_MOSTRAR";
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
        
    }
}
