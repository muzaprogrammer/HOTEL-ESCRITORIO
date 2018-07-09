using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NCliente
    {
        public static string Insertar(string nombre, string apellido, string tipodoc, string ndoc,
            DateTime fechanac, string genero, string telefono, string pais, string email)
        {
            DCliente Obj = new DCliente();
            Obj.CLI_NOMBRES1 = nombre;
            Obj.CLI_APELLIDOS1 = apellido;
            Obj.CLI_TIPO_DOCUMENTO1 = tipodoc;
            Obj.CLI_N_DOCUMENTO1 = ndoc;
            Obj.CLI_FECHA_NAC1 = fechanac;
            Obj.CLI_GENERO1 = genero;
            Obj.CLI_TELEFONO1 = telefono;
            Obj.CLI_PAIS1 = pais;
            Obj.CLI_EMAIL1 = email;            
            return Obj.InsertarCliente(Obj);
        }
        public static string Editar(int id, string nombre, string apellido, string tipodoc, string ndoc, 
            DateTime fechanac, string genero, string telefono, string pais, string email)
        {
            DCliente Obj = new DCliente();
            Obj.CLI_ID1 = id;
            Obj.CLI_NOMBRES1 = nombre;
            Obj.CLI_APELLIDOS1 = apellido;
            Obj.CLI_TIPO_DOCUMENTO1 = tipodoc;
            Obj.CLI_N_DOCUMENTO1 = ndoc;
            Obj.CLI_FECHA_NAC1 = fechanac;
            Obj.CLI_GENERO1 = genero;
            Obj.CLI_TELEFONO1 = telefono;
            Obj.CLI_PAIS1 = pais;
            Obj.CLI_EMAIL1 = email;

            return Obj.EditarCliente(Obj);
        }
        public static string Eliminar(int id)
        {
            DCliente Obj = new DCliente();
            Obj.CLI_ID1 = id;

            return Obj.EliminaCliente(Obj);
        }
        public static DataTable Mostrar()
        {
            return new DCliente().MostrarCliente();
        }       
        public static DataTable BuscarId(string textobuscar)
        {
            DCliente Obj = new DCliente();
            Obj.CLI_TEXTOBUSCAR1 = textobuscar;
            return Obj.BuscarClienteId(Obj);
        }
        public static DataTable BuscarNombre(string textobuscar)
        {
            DCliente Obj = new DCliente();
            Obj.CLI_TEXTOBUSCAR1 = textobuscar;
            return Obj.BuscarClienteNombre(Obj);
        }
        public static DataTable BuscarNombreApellido(string textobuscar, string textobuscarr)
        {
            DCliente Obj = new DCliente();
            Obj.CLI_TEXTOBUSCAR1 = textobuscar;
            Obj.CLI_TEXTOBUSCARR1 = textobuscarr;
            return Obj.BuscarClienteNombreApellido(Obj);
        }
        public static DataTable BuscarApellido(string textobuscar)
        {
            DCliente Obj = new DCliente();
            Obj.CLI_TEXTOBUSCAR1 = textobuscar;
            return Obj.BuscarClienteApellido(Obj);
        }
        public static DataTable BuscarNumDocumento(string textobuscar)
        {
            DCliente Obj = new DCliente();
            Obj.CLI_TEXTOBUSCAR1 = textobuscar;
            return Obj.BuscarClienteNUmDocumento(Obj);
        }
        public static DataTable BuscarFechaNac(string textobuscar)
        {
            DCliente Obj = new DCliente();
            Obj.CLI_TEXTOBUSCAR1 = textobuscar;
            return Obj.BuscarClienteFechaNac(Obj);
        }
        public static DataTable BuscarGenero(string textobuscar)
        {
            DCliente Obj = new DCliente();
            Obj.CLI_TEXTOBUSCAR1 = textobuscar;
            return Obj.BuscarClienteGenero(Obj);
        }
        public static DataTable BuscarTelefono(string textobuscar)
        {
            DCliente Obj = new DCliente();
            Obj.CLI_TEXTOBUSCAR1 = textobuscar;
            return Obj.BuscarClienteTelefono(Obj);
        }
        public static DataTable BuscarPais(string textobuscar, string textobuscar2)
        {
            DCliente Obj = new DCliente();
            Obj.CLI_TEXTOBUSCAR1 = textobuscar;
            Obj.CLI_TEXTOBUSCARR1 = textobuscar2;
            return Obj.BuscarClientePais(Obj);
        }
        public static DataTable BuscarEmail(string textobuscar)
        {
            DCliente Obj = new DCliente();
            Obj.CLI_TEXTOBUSCAR1 = textobuscar;
            return Obj.BuscarClienteEmail(Obj);
        }


    }
}
