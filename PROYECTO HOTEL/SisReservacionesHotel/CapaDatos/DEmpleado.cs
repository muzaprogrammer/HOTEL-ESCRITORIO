using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DEmpleado
    {
        private int _Id;
        private string _Nombres;
        private string _Apellidos;
        private string _TipoDoc;
        private string _NumeroDoc;
        private string _Direccion;
        private DateTime _FechaNacimiento;
        private DateTime _FechaIngreso;
        private double _sueldo;
        private string _Genero;
        private string _Telefono;
        private string _Turno;
        private string _User;
        private string _Pasword;
        private string _TextoBuscar;
        private string _TextoBuscarr;
        private string _Acceso;

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

        public string Nombres
        {
            get
            {
                return _Nombres;
            }

            set
            {
                _Nombres = value;
            }
        }

        public string Apellidos
        {
            get
            {
                return _Apellidos;
            }

            set
            {
                _Apellidos = value;
            }
        }

        public string TipoDoc
        {
            get
            {
                return _TipoDoc;
            }

            set
            {
                _TipoDoc = value;
            }
        }

        public string NumeroDoc
        {
            get
            {
                return _NumeroDoc;
            }

            set
            {
                _NumeroDoc = value;
            }
        }

        public string Direccion
        {
            get
            {
                return _Direccion;
            }

            set
            {
                _Direccion = value;
            }
        }

        public DateTime FechaNacimiento
        {
            get
            {
                return _FechaNacimiento;
            }

            set
            {
                _FechaNacimiento = value;
            }
        }

        public DateTime FechaIngreso
        {
            get
            {
                return _FechaIngreso;
            }

            set
            {
                _FechaIngreso = value;
            }
        }

        public double Sueldo
        {
            get
            {
                return _sueldo;
            }

            set
            {
                _sueldo = value;
            }
        }

        public string Genero
        {
            get
            {
                return _Genero;
            }

            set
            {
                _Genero = value;
            }
        }

        public string Telefono
        {
            get
            {
                return _Telefono;
            }

            set
            {
                _Telefono = value;
            }
        }

        public string Turno
        {
            get
            {
                return _Turno;
            }

            set
            {
                _Turno = value;
            }
        }

        public string User
        {
            get
            {
                return _User;
            }

            set
            {
                _User = value;
            }
        }

        public string Pasword
        {
            get
            {
                return _Pasword;
            }

            set
            {
                _Pasword = value;
            }
        }
        public string Acceso
        {
            get
            {
                return _Acceso;
            }

            set
            {
                _Acceso = value;
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

        public string TextoBuscarr
        {
            get
            {
                return _TextoBuscarr;
            }

            set
            {
                _TextoBuscarr = value;
            }
        }       

        public DEmpleado()
        {

        }
        public DEmpleado(int id, string nombres, string apelldios, string tipodoc, string numdoc, string direccion, DateTime fechanacimiento,
            DateTime fechaingreso, double sueldo, string genero, string telefono, string turno, string user, string pasword, string acceso, string textobuscar, string textobuscarr )
        {
            this.Id = id;
            this.Nombres = nombres;
            this.Apellidos = apelldios;
            this.TipoDoc = tipodoc;
            this.NumeroDoc = numdoc;
            this.Direccion = direccion;
            this.FechaNacimiento = fechanacimiento;
            this.FechaIngreso = _FechaIngreso;
            this.Sueldo = sueldo;
            this.Genero = genero;
            this.Telefono = telefono;
            this.Turno = turno;
            this.User = user;
            this.Pasword = pasword;
            this.Acceso = acceso;
            this.TextoBuscar = textobuscar;
            this.TextoBuscarr = textobuscarr;
        }
        public string InsertarEmpleado(DEmpleado Empleado)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "EMP_INSERTAR";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParEmpid = new SqlParameter();
                ParEmpid.ParameterName = "@ID";
                ParEmpid.SqlDbType = SqlDbType.Int;
                ParEmpid.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParEmpid);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@NOMBRES";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Empleado.Nombres;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellidos = new SqlParameter();
                ParApellidos.ParameterName = "@APELLIDOS";
                ParApellidos.SqlDbType = SqlDbType.VarChar;
                ParApellidos.Size = 50;
                ParApellidos.Value = Empleado.Apellidos;
                SqlCmd.Parameters.Add(ParApellidos);

                SqlParameter ParTipoDoc = new SqlParameter();
                ParTipoDoc.ParameterName = "@TIPODOC";
                ParTipoDoc.SqlDbType = SqlDbType.VarChar;
                ParTipoDoc.Size = 50;
                ParTipoDoc.Value = Empleado.TipoDoc;
                SqlCmd.Parameters.Add(ParTipoDoc);

                SqlParameter ParNumDoc = new SqlParameter();
                ParNumDoc.ParameterName = "@NUMERODOC";
                ParNumDoc.SqlDbType = SqlDbType.VarChar;
                ParNumDoc.Size = 20;
                ParNumDoc.Value = Empleado.NumeroDoc;
                SqlCmd.Parameters.Add(ParNumDoc);

                SqlParameter ParDir = new SqlParameter();
                ParDir.ParameterName = "@DIRECCION";
                ParDir.SqlDbType = SqlDbType.VarChar;
                ParDir.Size = 20;
                ParDir.Value = Empleado.Direccion;
                SqlCmd.Parameters.Add(ParDir);

                SqlParameter ParFechNac = new SqlParameter();
                ParFechNac.ParameterName = "@FECHANAC";
                ParFechNac.SqlDbType = SqlDbType.Date;
                ParFechNac.Value = Empleado.FechaNacimiento;
                SqlCmd.Parameters.Add(ParFechNac);

                SqlParameter ParFechIng = new SqlParameter();
                ParFechIng.ParameterName = "@FECHAINGRESO";
                ParFechIng.SqlDbType = SqlDbType.Date;
                ParFechIng.Value = Empleado.FechaIngreso;
                SqlCmd.Parameters.Add(ParFechIng);

                SqlParameter ParSueldo = new SqlParameter();
                ParSueldo.ParameterName = "@SUELDO";
                ParSueldo.SqlDbType = SqlDbType.Money;
                ParSueldo.Value = Empleado.Sueldo;
                SqlCmd.Parameters.Add(ParSueldo);

                SqlParameter ParGenero = new SqlParameter();
                ParGenero.ParameterName = "@GENERO";
                ParGenero.SqlDbType = SqlDbType.VarChar;
                ParGenero.Size = 15;
                ParGenero.Value = Empleado.Genero;
                SqlCmd.Parameters.Add(ParGenero);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@TELEFONO";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 10;
                ParTelefono.Value = Empleado.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParTurno = new SqlParameter();
                ParTurno.ParameterName = "@TURNO";
                ParTurno.SqlDbType = SqlDbType.VarChar;
                ParTurno.Size = 30;
                ParTurno.Value = Empleado.Turno;
                SqlCmd.Parameters.Add(ParTurno);

                SqlParameter ParUser = new SqlParameter();
                ParUser.ParameterName = "@USER";
                ParUser.SqlDbType = SqlDbType.VarChar;
                ParUser.Size = 50;
                ParUser.Value = Empleado.User;
                SqlCmd.Parameters.Add(ParUser);

                SqlParameter ParPasword = new SqlParameter();
                ParPasword.ParameterName = "@PASWORD";
                ParPasword.SqlDbType = SqlDbType.VarChar;
                ParPasword.Size = 50;
                ParPasword.Value = Empleado.Pasword;
                SqlCmd.Parameters.Add(ParPasword);

                SqlParameter ParAcceso = new SqlParameter();
                ParAcceso.ParameterName = "@ACCESO";
                ParAcceso.SqlDbType = SqlDbType.VarChar;
                ParAcceso.Size = 50;
                ParAcceso.Value = Empleado.Acceso;
                SqlCmd.Parameters.Add(ParAcceso);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se agrego el Empleado correctamente";
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
        public string EditarEmpleado(DEmpleado Empleado)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "EMP_EDITAR";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParEmpid = new SqlParameter();
                ParEmpid.ParameterName = "@ID";
                ParEmpid.SqlDbType = SqlDbType.Int;
                ParEmpid.Value = Empleado.Id;
                SqlCmd.Parameters.Add(ParEmpid);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@NOMBRES";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Empleado.Nombres;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellidos = new SqlParameter();
                ParApellidos.ParameterName = "@APELLIDOS";
                ParApellidos.SqlDbType = SqlDbType.VarChar;
                ParApellidos.Size = 50;
                ParApellidos.Value = Empleado.Apellidos;
                SqlCmd.Parameters.Add(ParApellidos);

                SqlParameter ParTipoDoc = new SqlParameter();
                ParTipoDoc.ParameterName = "@TIPODOC";
                ParTipoDoc.SqlDbType = SqlDbType.VarChar;
                ParTipoDoc.Size = 50;
                ParTipoDoc.Value = Empleado.TipoDoc;
                SqlCmd.Parameters.Add(ParTipoDoc);

                SqlParameter ParNumDoc = new SqlParameter();
                ParNumDoc.ParameterName = "@NUMERODOC";
                ParNumDoc.SqlDbType = SqlDbType.VarChar;
                ParNumDoc.Size = 20;
                ParNumDoc.Value = Empleado.NumeroDoc;
                SqlCmd.Parameters.Add(ParNumDoc);

                SqlParameter ParDir = new SqlParameter();
                ParDir.ParameterName = "@DIRECCION";
                ParDir.SqlDbType = SqlDbType.VarChar;
                ParDir.Size = 20;
                ParDir.Value = Empleado.Direccion;
                SqlCmd.Parameters.Add(ParDir);

                SqlParameter ParFechNac = new SqlParameter();
                ParFechNac.ParameterName = "@FECHANAC";
                ParFechNac.SqlDbType = SqlDbType.Date;
                ParFechNac.Value = Empleado.FechaNacimiento;
                SqlCmd.Parameters.Add(ParFechNac);

                SqlParameter ParFechIng = new SqlParameter();
                ParFechIng.ParameterName = "@FECHAINGRESO";
                ParFechIng.SqlDbType = SqlDbType.Date;
                ParFechIng.Value = Empleado.FechaIngreso;
                SqlCmd.Parameters.Add(ParFechIng);

                SqlParameter ParSueldo = new SqlParameter();
                ParSueldo.ParameterName = "@SUELDO";
                ParSueldo.SqlDbType = SqlDbType.Money;
                ParSueldo.Value = Empleado.Sueldo;
                SqlCmd.Parameters.Add(ParSueldo);

                SqlParameter ParGenero = new SqlParameter();
                ParGenero.ParameterName = "@GENERO";
                ParGenero.SqlDbType = SqlDbType.VarChar;
                ParGenero.Size = 15;
                ParGenero.Value = Empleado.Genero;
                SqlCmd.Parameters.Add(ParGenero);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@TELEFONO";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 10;
                ParTelefono.Value = Empleado.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParTurno = new SqlParameter();
                ParTurno.ParameterName = "@TURNO";
                ParTurno.SqlDbType = SqlDbType.VarChar;
                ParTurno.Size = 30;
                ParTurno.Value = Empleado.Turno;
                SqlCmd.Parameters.Add(ParTurno);

                SqlParameter ParUser = new SqlParameter();
                ParUser.ParameterName = "@USER";
                ParUser.SqlDbType = SqlDbType.VarChar;
                ParUser.Size = 50;
                ParUser.Value = Empleado.User;
                SqlCmd.Parameters.Add(ParUser);

                SqlParameter ParPasword = new SqlParameter();
                ParPasword.ParameterName = "@PASWORD";
                ParPasword.SqlDbType = SqlDbType.VarChar;
                ParPasword.Size = 50;
                ParPasword.Value = Empleado.Pasword;
                SqlCmd.Parameters.Add(ParPasword);

                SqlParameter ParAcceso = new SqlParameter();
                ParAcceso.ParameterName = "@ACCESO";
                ParAcceso.SqlDbType = SqlDbType.VarChar;
                ParAcceso.Size = 50;
                ParAcceso.Value = Empleado.Acceso;
                SqlCmd.Parameters.Add(ParAcceso);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se Edito el Empleado correctamente";
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
        public string EliminarEmpleado(DEmpleado Empleado)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "EMP_ELIMINAR";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParEmpid = new SqlParameter();
                ParEmpid.ParameterName = "@ID";
                ParEmpid.SqlDbType = SqlDbType.Int;
                ParEmpid.Value = Empleado.Id;
                SqlCmd.Parameters.Add(ParEmpid);
                
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se Edito el Empleado correctamente";
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
        public DataTable MostrarEmpleado()
        {
            DataTable DtResultado = new DataTable("EMPLEADOS");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "EMP_MOSTRAR";
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
        public DataTable BuscarEmpleadoId(DEmpleado Empleado)
        {
            DataTable DtResultado = new DataTable("EMPLEADOS");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "EMP_BUSCAR_ID";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                Convert.ToInt32(TextoBuscar);
                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@TEXTOBUSCAR";
                ParTextoBuscar.SqlDbType = SqlDbType.Int;
                ParTextoBuscar.Value = Empleado.TextoBuscar;
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
        public DataTable BuscarEmpleadoNombreApellidos(DEmpleado Empleado)
        {
            DataTable DtResultado = new DataTable("EMPLEADOS");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "EMP_BUSCAR_NOMBRE";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                                
                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@TEXTOBUSCAR";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Empleado.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlParameter ParTextoBuscarr = new SqlParameter();
                ParTextoBuscarr.ParameterName = "@TEXTOBUSCARR";
                ParTextoBuscarr.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscarr.Size = 50;
                ParTextoBuscarr.Value = Empleado.TextoBuscarr;
                SqlCmd.Parameters.Add(ParTextoBuscarr);

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
        public DataTable BuscarEmpleadoNDocumento(DEmpleado Empleado)
        {
            DataTable DtResultado = new DataTable("EMPLEADOS");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "EMP_BUSCAR_N_DOCUMENTO";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@TEXTOBUSCAR";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 20;
                ParTextoBuscar.Value = Empleado.TextoBuscar;
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
        public DataTable BuscarEmpleadoGenero(DEmpleado Empleado)
        {
            DataTable DtResultado = new DataTable("EMPLEADOS");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "EMP_BUSCAR_GENERO";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@TEXTOBUSCAR";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 15;
                ParTextoBuscar.Value = Empleado.TextoBuscar;
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
        public DataTable BuscarEmpleadoTelefono(DEmpleado Empleado)
        {
            DataTable DtResultado = new DataTable("EMPLEADOS");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "EMP_BUSCAR_TELEFONO";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@TEXTOBUSCAR";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 10;
                ParTextoBuscar.Value = Empleado.TextoBuscar;
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
        public DataTable BuscarEmpleadoTurno(DEmpleado Empleado)
        {
            DataTable DtResultado = new DataTable("EMPLEADOS");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "EMP_BUSCAR_TURNO";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@TEXTOBUSCAR";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 15;
                ParTextoBuscar.Value = Empleado.TextoBuscar;
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
        public DataTable BuscarEmpleadoUser(DEmpleado Empleado)
        {
            DataTable DtResultado = new DataTable("EMPLEADOS");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "EMP_BUSCAR_USER";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@TEXTOBUSCAR";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Empleado.TextoBuscar;
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
        public DataTable Login(DEmpleado Empleado)
        {
            DataTable DtResultado = new DataTable("EMPLEADOS");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SRLOGIN";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@USUARIO";
                ParUsuario.SqlDbType = SqlDbType.VarChar;
                ParUsuario.Size = 50;
                ParUsuario.Value = Empleado.User;
                SqlCmd.Parameters.Add(ParUsuario);

                SqlParameter ParPasword = new SqlParameter();
                ParPasword.ParameterName = "@PASWORD";
                ParPasword.SqlDbType = SqlDbType.VarChar;
                ParPasword.Size = 50;
                ParPasword.Value = Empleado.Pasword;
                SqlCmd.Parameters.Add(ParPasword);

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
