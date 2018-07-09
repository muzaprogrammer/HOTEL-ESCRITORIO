using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NHoteles
    {
        public static string Insertar(string nombre, string pais)
        {
            DHoteles Obj = new DHoteles();            
            Obj.HOT_NOMBRE = nombre;
            Obj.PAIS = pais;            
            return Obj.InsertarHotel(Obj);
        }
        public static string Eliminar(int id)
        {
            DHoteles Obj = new DHoteles();
            Obj.HOT_ID = id;
            return Obj.EliminarHotel(Obj);
        }
        public static DataTable Mostrar()
        {
            return new DHoteles().MostrarHoteles();
        }
        public static DataTable Buscar(string textobuscar1, string textobuscar2)
        {
            DHoteles Obj = new DHoteles();
            Obj.TEXTO_BUSCAR1 = textobuscar1;
            Obj.TEXTO_BUSCAR2 = textobuscar2;
            return Obj.BuscarHotel(Obj);
        }
    }
}
