using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Programacion
{
    public static class ExtensionesVehiculo
    {
        public static void MostrarInfo(this Vehiculo vehiculo)
        {
            Console.WriteLine($"Modelo: {vehiculo.Modelo}, Precio por día: {vehiculo.PrecioPorDia:C}");
        }
    }
}
