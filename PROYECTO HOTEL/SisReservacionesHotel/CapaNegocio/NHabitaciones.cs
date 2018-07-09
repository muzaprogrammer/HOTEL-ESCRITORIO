using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NHabitaciones
    {
        public static string Insertar(int numHab, int piso, string tipo, int numCamas, double precio, string estado, int hotelId)
        {
            DHabitaciones Obj = new DHabitaciones();
            Obj.NumHab = numHab;
            Obj.Piso = piso;
            Obj.Tipo = tipo;
            Obj.NumCamas = numCamas;
            Obj.Precio = precio;
            Obj.Estado = estado;
            Obj.HotelId = hotelId;
            return Obj.InsertarHabitacion(Obj);
        }
        public static string Editar(int id, int numHab, int piso, string tipo, int numCamas, double precio, string estado, int hotelId)
        {
            DHabitaciones Obj = new DHabitaciones();
            Obj.Id = id;
            Obj.NumHab = numHab;
            Obj.Piso = piso;
            Obj.Tipo = tipo;
            Obj.NumCamas = numCamas;
            Obj.Precio = precio;
            Obj.Estado = estado;
            Obj.HotelId = hotelId;
            return Obj.EditarHabitacion(Obj);
        }
        public static string Eliminar(int id)
        {
            DHabitaciones Obj = new DHabitaciones();
            Obj.Id = id;
            return Obj.EliminarHabitacion(Obj);
        }
        public static DataTable MostrarTodas()
        {
            return new DHabitaciones().MostrarTodasLasHabitaciones();
        }
        public static DataTable MostrarPrecioMax()
        {
            return new DHabitaciones().MostrarHabitacionesPrecioMax();
        }
        public static DataTable MostrarPrecioMin()
        {
            return new DHabitaciones().MostrarHabitacionesPrecioMin();
        }
        public static DataTable BuscarTipo(string textobuscar)
        {
            DHabitaciones Obj = new DHabitaciones();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarHabTipo(Obj);
        }
        public static DataTable BuscarNum(string textobuscar)
        {
            DHabitaciones Obj = new DHabitaciones();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarHabNUm(Obj);
        }
    }
}
