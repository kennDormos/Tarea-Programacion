using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Programacion
{
    public class Vehiculo
    {
        public string Modelo { get; set; }
        public double PrecioPorDia { get; set; }

        public class Descuento
        {
            public static double AplicarDescuento(double precio,double porcentajedescuento)
            {
                return precio - (precio * (porcentajedescuento / 100));
            }
        }
    }
}
