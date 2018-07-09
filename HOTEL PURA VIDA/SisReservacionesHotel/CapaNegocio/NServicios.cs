using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NServicios
    {
        public static string Insertar(string nombre, string descripcion, double precio)
        {
            DServicios Obj = new DServicios();
            Obj.SER_NOMBRE = nombre;
            Obj.SER_DESCRIPCION = descripcion;
            Obj.SER_PRECIO = precio;
            return Obj.InsertarServicio(Obj);
        }
        public static string Eliminar(int id)
        {
            DServicios Obj = new DServicios();
            Obj.SER_ID = id;
            return Obj.EliminarServicio(Obj);
        }
        public static DataTable Mostrar()
        {
            return new DServicios().MostrarServicios();
        }
        public static DataTable Buscar(string textobuscar1)
        {
            DServicios Obj = new DServicios();
            Obj.SER_NOMBRE = textobuscar1;            
            return Obj.BuscarServicios(Obj);
        }
    }
}
