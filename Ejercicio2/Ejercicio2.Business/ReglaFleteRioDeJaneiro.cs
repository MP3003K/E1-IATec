using Ejercicio2.Entities;

namespace Ejercicio2.Business
{
    internal class ReglaFleteRioDeJaneiro : IReglaFlete
    {
        public decimal CalcularFlete(Compra compra)
        {
            return 30m;
        }
    }
}
