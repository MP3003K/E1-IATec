using Ejercicio2.Entities;

namespace Ejercicio2.Business
{
    internal class ReglaFleteLima : IReglaFlete
    {
        public decimal CalcularFlete(Compra compra)
        {
            return 30m;
        }
    }
}
