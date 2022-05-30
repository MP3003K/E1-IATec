using Ejercicio3.Data;
using Ejercicio3.Entities;

namespace Ejercicio3.Business
{
    internal class GuardarComoPDF : IAccionesCompras
    {
        public void Ejecutar(List<Compra> compras)
        {
            Guardar(compras);
        }
        private void Guardar(List<Compra> compras)
        {
            Console.WriteLine("Se esta guardando como PDF");
        }
    }
}
