using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NReserva
    {
        public static string InsertarReserva(int hAB_ID, int cLI_ID, int eMP_ID, string eSTADO_HAB, DateTime fECHA_RESERVACION, DateTime cHECKIN, DateTime cHECKOUT, int n_NOCHES, double cOSTO_NOCHES, double cOSTO_TOTAL, string eSTADO_PAGO, string oBSERVACIONES)
        {
            DReserva Obj = new DReserva();
            Obj.HAB_ID = hAB_ID;
            Obj.CLI_ID = cLI_ID;
            Obj.EMP_ID = eMP_ID;
            Obj.ESTADO_HAB = eSTADO_HAB;
            Obj.FECHA_RESERVACION = fECHA_RESERVACION;
            Obj.CHECKIN = cHECKIN;
            Obj.CHECKOUT = cHECKOUT;
            Obj.N_NOCHES = n_NOCHES;
            Obj.COSTO_NOCHES = cOSTO_NOCHES;
            Obj.COSTO_TOTAL = cOSTO_TOTAL;
            Obj.ESTADO_PAGO = eSTADO_PAGO;
            Obj.OBSERVACIONES = oBSERVACIONES;

            return Obj.Insertarreserva(Obj);
        }
        public static string EditarReserva(int rES_ID, int hAB_ID, int cLI_ID, int eMP_ID, string eSTADO_HAB, DateTime fECHA_RESERVACION, DateTime cHECKIN, DateTime cHECKOUT, int n_NOCHES, double cOSTO_NOCHES, double cOSTO_TOTAL, string eSTADO_PAGO, string oBSERVACIONES)
        {
            DReserva Obj = new DReserva();
            Obj.RES_ID = rES_ID;
            Obj.HAB_ID = hAB_ID;
            Obj.CLI_ID = cLI_ID;
            Obj.EMP_ID = eMP_ID;
            Obj.ESTADO_HAB = eSTADO_HAB;
            Obj.FECHA_RESERVACION = fECHA_RESERVACION;
            Obj.CHECKIN = cHECKIN;
            Obj.CHECKOUT = cHECKOUT;
            Obj.N_NOCHES = n_NOCHES;
            Obj.COSTO_NOCHES = cOSTO_NOCHES;
            Obj.COSTO_TOTAL = cOSTO_TOTAL;
            Obj.ESTADO_PAGO = eSTADO_PAGO;
            Obj.OBSERVACIONES = oBSERVACIONES;

            return Obj.Editarreserva(Obj);
        }
        public static string EliminarReserva(int rES_ID)
        {
            DReserva Obj = new DReserva();
            Obj.RES_ID = rES_ID;
            
            return Obj.Eliminarreserva(Obj);
        }
    }
}
