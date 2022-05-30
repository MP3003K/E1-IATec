using Ejercicio3.Data;
using Ejercicio3.Entities;

namespace Ejercicio3.Business
{
    internal class GenerarReporte : IAccionesCompras
    {
        public void Ejecutar(List<Compra> compras)
        {
            Console.WriteLine("Generando reporte de compras");
        }
    }
}

