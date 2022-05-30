using Ejercicio2.Entities;

namespace Ejercicio2.Business
{
    internal class ReglaFleteSantiago : IReglaFlete
    {
        public decimal CalcularFlete(Compra compra)
        {
            return 40m;
        }
    }
}
