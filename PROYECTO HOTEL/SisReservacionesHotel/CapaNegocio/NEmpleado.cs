using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NEmpleado
    {
        public static string Insertar(string nombres, string apelldios, string tipodoc, string numdoc, 
            string direccion, DateTime fechanacimiento, DateTime fechaingreso, double sueldo, string genero,
            string telefono, string turno, string user, string pasword, string acceso)
        {
            DEmpleado Obj = new DEmpleado();
            Obj.Nombres = nombres;
            Obj.Apellidos = apelldios;
            Obj.TipoDoc = tipodoc;
            Obj.NumeroDoc = numdoc;
            Obj.Direccion = direccion;
            Obj.FechaNacimiento = fechanacimiento;
            Obj.FechaIngreso = fechaingreso;
            Obj.Sueldo = sueldo;
            Obj.Genero = genero;
            Obj.Telefono = telefono;
            Obj.Turno = turno;
            Obj.User = user;
            Obj.Pasword = pasword;
            Obj.Acceso = acceso;
            return Obj.InsertarEmpleado(Obj);
        }
        public static string Editar(int id, string nombres, string apelldios, string tipodoc, string numdoc,
            string direccion, DateTime fechanacimiento, DateTime fechaingreso, double sueldo, string genero,
            string telefono, string turno, string user, string pasword, string acceso)
        {
            DEmpleado Obj = new DEmpleado();
            Obj.Id = id;
            Obj.Nombres = nombres;
            Obj.Apellidos = apelldios;
            Obj.TipoDoc = tipodoc;
            Obj.NumeroDoc = numdoc;
            Obj.Direccion = direccion;
            Obj.FechaNacimiento = fechanacimiento;
            Obj.FechaIngreso = fechaingreso;
            Obj.Sueldo = sueldo;
            Obj.Genero = genero;
            Obj.Telefono = telefono;
            Obj.Turno = turno;
            Obj.User = user;
            Obj.Pasword = pasword;
            Obj.Acceso = acceso;
            return Obj.EditarEmpleado(Obj);
        }
        public static string Eliminar(int id)
        {
            DEmpleado Obj = new DEmpleado();
            Obj.Id = id;
            return Obj.EliminarEmpleado(Obj);
        }
        public static DataTable Mostrar()
        {
            return new DEmpleado().MostrarEmpleado();
        }
        public static DataTable BuscarId(string textobuscar)
        {
            DEmpleado Obj = new DEmpleado();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarEmpleadoId(Obj);
        }
        public static DataTable BuscarNombresApellidos(string textobuscar, string textobuscarr)
        {
            DEmpleado Obj = new DEmpleado();
            Obj.TextoBuscar = textobuscar;
            Obj.TextoBuscarr = textobuscarr;
            return Obj.BuscarEmpleadoNombreApellidos(Obj);
        }
        public static DataTable BuscarNumeroDocumento(string textobuscar)
        {
            DEmpleado Obj = new DEmpleado();
            Obj.TextoBuscar = textobuscar;            
            return Obj.BuscarEmpleadoNDocumento(Obj);
        }
        public static DataTable BuscarGenero(string textobuscar)
        {
            DEmpleado Obj = new DEmpleado();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarEmpleadoGenero(Obj);
        }
        public static DataTable BuscarTelefono(string textobuscar)
        {
            DEmpleado Obj = new DEmpleado();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarEmpleadoTelefono(Obj);
        }
        public static DataTable BuscarTurno(string textobuscar)
        {
            DEmpleado Obj = new DEmpleado();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarEmpleadoTurno(Obj);
        }
        public static DataTable BuscarUser(string textobuscar)
        {
            DEmpleado Obj = new DEmpleado();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarEmpleadoUser(Obj);
        }
        public static DataTable Login(string usuario, string pasword)
        {
            DEmpleado Obj = new DEmpleado();
            Obj.User = usuario;
            Obj.Pasword = pasword;
            return Obj.Login(Obj);
        }
    }
}
