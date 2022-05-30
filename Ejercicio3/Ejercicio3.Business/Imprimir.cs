using Ejercicio3.Data;
using Ejercicio3.Entities;

namespace Ejercicio3.Business
{
    internal class Imprimir : IAccionesCompras
    {
        public void Ejecutar(List<Compra> compras)
        {
            Console.WriteLine("Imprimiendo reporte de compras...");
        }
    }
}
