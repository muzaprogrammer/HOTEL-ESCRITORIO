using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class DCliente
    {
        private int CLI_ID;
        private string CLI_NOMBRES;
        private string CLI_APELLIDOS;
        private string CLI_TIPO_DOCUMENTO;
        private string CLI_N_DOCUMENTO;
        private DateTime CLI_FECHA_NAC;
        private string CLI_GENERO;
        private string CLI_TELEFONO;
        private string CLI_PAIS;
        private string CLI_EMAIL;
        private string CLI_TEXTOBUSCAR;
        private string CLI_TEXTOBUSCARR;

        public int CLI_ID1
        {
            get
            {
                return CLI_ID;
            }

            set
            {
                CLI_ID = value;
            }
        }

        public string CLI_NOMBRES1
        {
            get
            {
                return CLI_NOMBRES;
            }

            set
            {
                CLI_NOMBRES = value;
            }
        }

        public string CLI_APELLIDOS1
        {
            get
            {
                return CLI_APELLIDOS;
            }

            set
            {
                CLI_APELLIDOS = value;
            }
        }

        public string CLI_TIPO_DOCUMENTO1
        {
            get
            {
                return CLI_TIPO_DOCUMENTO;
            }

            set
            {
                CLI_TIPO_DOCUMENTO = value;
            }
        }

        public string CLI_N_DOCUMENTO1
        {
            get
            {
                return CLI_N_DOCUMENTO;
            }

            set
            {
                CLI_N_DOCUMENTO = value;
            }
        }
        public DateTime CLI_FECHA_NAC1
        {
            get
            {
                return CLI_FECHA_NAC;
            }

            set
            {
                CLI_FECHA_NAC = value;
            }
        }

        public string CLI_GENERO1
        {
            get
            {
                return CLI_GENERO;
            }

            set
            {
                CLI_GENERO = value;
            }
        }

        public string CLI_TELEFONO1
        {
            get
            {
                return CLI_TELEFONO;
            }

            set
            {
                CLI_TELEFONO = value;
            }
        }

        public string CLI_PAIS1
        {
            get
            {
                return CLI_PAIS;
            }

            set
            {
                CLI_PAIS = value;
            }
        }
        public string CLI_EMAIL1
        {
            get
            {
                return CLI_EMAIL;
            }

            set
            {
                CLI_EMAIL = value;
            }
        }

        public string CLI_TEXTOBUSCAR1
        {
            get
            {
                return CLI_TEXTOBUSCAR;
            }

            set
            {
                CLI_TEXTOBUSCAR = value;
            }        
        }

        public string CLI_TEXTOBUSCARR1
        {
            get
            {
                return CLI_TEXTOBUSCARR;
            }

            set
            {
                CLI_TEXTOBUSCARR = value;
            }
        }

        public DCliente()
        {

        }
        public DCliente(int id, string nombre, string apellido, string tipodoc, string ndoc, 
            DateTime fechanac, string genero, string telefono, string pais, string email, string textobuscar, string textbuscarr)
        {
            this.CLI_ID1 = id;
            this.CLI_NOMBRES1 = nombre;
            this.CLI_APELLIDOS1=apellido;
            this.CLI_TIPO_DOCUMENTO1=tipodoc;
            this.CLI_N_DOCUMENTO1 = ndoc;
            this.CLI_FECHA_NAC1=fechanac;
            this.CLI_GENERO1=genero;
            this.CLI_TELEFONO1=telefono;
            this.CLI_PAIS1=pais;
            this.CLI_EMAIL1 = email;
            this.CLI_TEXTOBUSCAR1=textobuscar;
            this.CLI_TEXTOBUSCARR1 = textbuscarr;
        }
        //metodo insertar cliente
        public string InsertarCliente(DCliente Cliente)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "CLI_INSERTAR";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCliid = new SqlParameter();
                ParCliid.ParameterName = "@IDCLIENTE";
                ParCliid.SqlDbType = SqlDbType.Int;
                ParCliid.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParCliid);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@NOMBRE";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Cliente.CLI_NOMBRES1;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellidos = new SqlParameter();
                ParApellidos.ParameterName = "@APELLIDOS";
                ParApellidos.SqlDbType = SqlDbType.VarChar;
                ParApellidos.Size = 50;
                ParApellidos.Value = Cliente.CLI_APELLIDOS1;
                SqlCmd.Parameters.Add(ParApellidos);

                SqlParameter ParTipoDoc = new SqlParameter();
                ParTipoDoc.ParameterName = "@TIPO_DOC";
                ParTipoDoc.SqlDbType = SqlDbType.VarChar;
                ParTipoDoc.Size = 50;
                ParTipoDoc.Value = Cliente.CLI_TIPO_DOCUMENTO1;
                SqlCmd.Parameters.Add(ParTipoDoc);

                SqlParameter ParNumDoc = new SqlParameter();
                ParNumDoc.ParameterName = "@NUM_DOC";
                ParNumDoc.SqlDbType = SqlDbType.VarChar;
                ParNumDoc.Size = 50;
                ParNumDoc.Value = Cliente.CLI_N_DOCUMENTO1;
                SqlCmd.Parameters.Add(ParNumDoc);
              
                SqlParameter ParFechNac = new SqlParameter();
                ParFechNac.ParameterName = "@FECHA_NAC";
                ParFechNac.SqlDbType = SqlDbType.Date;                
                ParFechNac.Value = Cliente.CLI_FECHA_NAC1;
                SqlCmd.Parameters.Add(ParFechNac);

                SqlParameter ParGenero = new SqlParameter();
                ParGenero.ParameterName = "@GENERO";
                ParGenero.SqlDbType = SqlDbType.VarChar;
                ParGenero.Size = 50;
                ParGenero.Value = Cliente.CLI_GENERO1;
                SqlCmd.Parameters.Add(ParGenero);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@TELEFONO";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 50;
                ParTelefono.Value = Cliente.CLI_TELEFONO1;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParPais = new SqlParameter();
                ParPais.ParameterName = "@PAIS";
                ParPais.SqlDbType = SqlDbType.VarChar;
                ParPais.Size = 50;
                ParPais.Value = Cliente.CLI_PAIS1;
                SqlCmd.Parameters.Add(ParPais);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@EMAIL";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 50;
                ParEmail.Value = Cliente.CLI_EMAIL1;
                SqlCmd.Parameters.Add(ParEmail);



                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se agrego el Cliente correctamente";
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
        //metodo editar cliente
        public string EditarCliente(DCliente Cliente)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "CLI_EDITAR";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCliid = new SqlParameter();
                ParCliid.ParameterName = "@IDCLIENTE";
                ParCliid.SqlDbType = SqlDbType.Int;
                ParCliid.Value = Cliente.CLI_ID1;                
                SqlCmd.Parameters.Add(ParCliid);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@NOMBRE";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Cliente.CLI_NOMBRES1;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellidos = new SqlParameter();
                ParApellidos.ParameterName = "@APELLIDOS";
                ParApellidos.SqlDbType = SqlDbType.VarChar;
                ParApellidos.Size = 50;
                ParApellidos.Value = Cliente.CLI_APELLIDOS1;
                SqlCmd.Parameters.Add(ParApellidos);

                SqlParameter ParTipoDoc = new SqlParameter();
                ParTipoDoc.ParameterName = "@TIPO_DOC";
                ParTipoDoc.SqlDbType = SqlDbType.VarChar;
                ParTipoDoc.Size = 50;
                ParTipoDoc.Value = Cliente.CLI_TIPO_DOCUMENTO1;
                SqlCmd.Parameters.Add(ParTipoDoc);

                SqlParameter ParNumDoc = new SqlParameter();
                ParNumDoc.ParameterName = "@NUM_DOC";
                ParNumDoc.SqlDbType = SqlDbType.VarChar;
                ParNumDoc.Size = 50;
                ParNumDoc.Value = Cliente.CLI_N_DOCUMENTO1;
                SqlCmd.Parameters.Add(ParNumDoc);

                SqlParameter ParFechNac = new SqlParameter();
                ParFechNac.ParameterName = "@FECHA_NAC";
                ParFechNac.SqlDbType = SqlDbType.Date;
                ParFechNac.Value = Cliente.CLI_FECHA_NAC1;
                SqlCmd.Parameters.Add(ParFechNac);

                SqlParameter ParGenero = new SqlParameter();
                ParGenero.ParameterName = "@GENERO";
                ParGenero.SqlDbType = SqlDbType.VarChar;
                ParGenero.Size = 50;
                ParGenero.Value = Cliente.CLI_GENERO1;
                SqlCmd.Parameters.Add(ParGenero);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@TELEFONO";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 50;
                ParTelefono.Value = Cliente.CLI_TELEFONO1;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParPais = new SqlParameter();
                ParPais.ParameterName = "@PAIS";
                ParPais.SqlDbType = SqlDbType.VarChar;
                ParPais.Size = 50;
                ParPais.Value = Cliente.CLI_PAIS1;
                SqlCmd.Parameters.Add(ParPais);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@EMAIL";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 50;
                ParEmail.Value = Cliente.CLI_EMAIL1;
                SqlCmd.Parameters.Add(ParEmail);



                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se Edito el Cliente correctamente";
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
        public string EliminaCliente(DCliente Cliente)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "CLI_ELIMINAR";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCliid = new SqlParameter();
                ParCliid.ParameterName = "@IDCLIENTE";
                ParCliid.SqlDbType = SqlDbType.Int;
                ParCliid.Value = Cliente.CLI_ID1;
                SqlCmd.Parameters.Add(ParCliid);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se elimino el cliente correctamente";
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
        public DataTable MostrarCliente()
        {
            DataTable DtResultado = new DataTable("CLIENTES");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "CLI_MOSTRAR";
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
        public DataTable BuscarClienteNombreApellido(DCliente Cliente)
        {
            DataTable DtResultado = new DataTable("CLIENTES");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "CLI_BUSCAR_NOMBRE_APELLIDO";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@NOMBRES";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Cliente.CLI_TEXTOBUSCAR1;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlParameter ParTextoBuscar1 = new SqlParameter();
                ParTextoBuscar1.ParameterName = "@APELLIDO";
                ParTextoBuscar1.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar1.Size = 50;
                ParTextoBuscar1.Value = Cliente.CLI_TEXTOBUSCARR1;
                SqlCmd.Parameters.Add(ParTextoBuscar1);

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
        public DataTable BuscarClienteId(DCliente Cliente)
        {
            DataTable DtResultado = new DataTable("CLIENTES");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "CLI_BUSCAR_ID";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                Convert.ToInt32(CLI_TEXTOBUSCAR1);
                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@TEXTOBUSCAR";
                ParTextoBuscar.SqlDbType = SqlDbType.Int;
                ParTextoBuscar.Value = Cliente.CLI_TEXTOBUSCAR1;
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
        public DataTable BuscarClienteNombre(DCliente Cliente)
        {
            DataTable DtResultado = new DataTable("CLIENTES");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "CLI_BUSCAR_NOMBRE";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@TEXTOBUSCAR";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Cliente.CLI_TEXTOBUSCAR1;
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
        public DataTable BuscarClienteApellido(DCliente Cliente)
        {
            DataTable DtResultado = new DataTable("CLIENTES");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "CLI_BUSCAR_APELLIDO";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@TEXTOBUSCAR";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Cliente.CLI_TEXTOBUSCAR1;
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
        public DataTable BuscarClienteNUmDocumento(DCliente Cliente)
        {
            DataTable DtResultado = new DataTable("CLIENTES");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "CLI_BUSCAR_N_DOCUMENTO";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@TEXTOBUSCAR";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Cliente.CLI_TEXTOBUSCAR1;
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
        public DataTable BuscarClienteFechaNac(DCliente Cliente)
        {
            DataTable DtResultado = new DataTable("CLIENTES");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "CLI_BUSCAR_FECHA_NAC";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@TEXTOBUSCAR";
                ParTextoBuscar.SqlDbType = SqlDbType.Date;                
                ParTextoBuscar.Value = Cliente.CLI_TEXTOBUSCAR1;
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
        public DataTable BuscarClienteGenero(DCliente Cliente)
        {
            DataTable DtResultado = new DataTable("CLIENTES");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "CLI_BUSCAR_GENERO";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@TEXTOBUSCAR";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Cliente.CLI_TEXTOBUSCAR1;
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
        public DataTable BuscarClienteTelefono(DCliente Cliente)
        {
            DataTable DtResultado = new DataTable("CLIENTES");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "CLI_BUSCAR_TELEFONO";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@TEXTOBUSCAR";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Cliente.CLI_TEXTOBUSCAR1;
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
        public DataTable BuscarClientePais(DCliente Cliente)
        {
            DataTable DtResultado = new DataTable("CLIENTES");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "CLI_BUSCAR_PAIS";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@TEXTOBUSCAR";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Cliente.CLI_TEXTOBUSCAR1;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlParameter ParTextoBuscar2 = new SqlParameter();
                ParTextoBuscar2.ParameterName = "@TEXTOBUSCAR2";
                ParTextoBuscar2.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar2.Size = 50;
                ParTextoBuscar2.Value = Cliente.CLI_TEXTOBUSCARR1;
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
        public DataTable BuscarClienteEmail(DCliente Cliente)
        {
            DataTable DtResultado = new DataTable("CLIENTES");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "CLI_BUSCAR_GENERO";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@TEXTOBUSCAR";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Cliente.CLI_TEXTOBUSCAR1;
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
