using Ejercicio2.Entities;

namespace Ejercicio2.Business
{
    internal class ReglaFleteCusco : IReglaFlete
    {
        public decimal CalcularFlete(Compra compra)
        {
            return 10m;
        }
    }
}
