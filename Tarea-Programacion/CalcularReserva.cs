using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Programacion
{
    public static class CalcularReserva
    {
        public static double CalcularCostoTotal(Vehiculo vehiculo,int dias, double porcentajedescuento)
        {
            double precioConDescuento = Vehiculo.Descuento.AplicarDescuento(vehiculo.PrecioPorDia, porcentajedescuento);
            return precioConDescuento * dias;
        }
    }
}
