using Ejercicio2.Entities;

namespace Ejercicio2.Business
{
    internal class ReglaFleteSaoPaulo : IReglaFlete
    {
        public decimal CalcularFlete(Compra compra)
        {
            return 30m;
        }
    }
}
