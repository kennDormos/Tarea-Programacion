using System;

namespace Tarea_Programacion
{
    class Program
    {
        public static void Main(string[] args)
        {
            Vehiculo vehiculo = new Vehiculo { Modelo = "Toyota Corolla", PrecioPorDia = 99.9 };
            
            double porcentajeDescuento = 10.0;
            
            vehiculo.MostrarInfo();

            double costoTotal = CalcularReserva.CalcularCostoTotal(vehiculo, 5, porcentajeDescuento);

            Console.WriteLine($"El costo total de reserva de 5 dias con un descuento del {porcentajeDescuento}% es de:{costoTotal}");
        }
    }
}