using Ejercicio3.Entities;

namespace Ejercicio3.Data
{
    public class GuardarEnDB : IAccionesCompras
    {
        public void Ejecutar(List<Compra> compras)
        {
            Guardar(compras);
        }
        private void Guardar(List<Compra> compras)
        {
            Console.WriteLine("Las compras se estan guardando en la BD");
        }
    }
}
