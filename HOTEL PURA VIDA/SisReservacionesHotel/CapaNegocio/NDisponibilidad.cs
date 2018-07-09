using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NDisponibilidad
    {
        public static DataTable MostrarDisponibles(DateTime textobuscar1, DateTime textobuscar2)
        {
            DReserva Obj = new DReserva();
            Obj.CHECKIN = textobuscar1;
            Obj.CHECKOUT = textobuscar2;
            return Obj.MostrarHabsDisponible(Obj);
        }
        
        public static DataTable MostrarNoDisponibles(DateTime textobuscar1, DateTime textobuscar2)
        {
            DReserva Obj = new DReserva();
            Obj.CHECKIN = textobuscar1;
            Obj.CHECKOUT = textobuscar2;
            return Obj.MostrarNoHabsDisponible(Obj);
        }
        
    }
}
