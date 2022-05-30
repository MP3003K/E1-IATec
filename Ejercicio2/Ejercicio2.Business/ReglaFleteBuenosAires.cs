using Ejercicio2.Entities;

namespace Ejercicio2.Business
{
    internal class ReglaFleteBuenosAires : IReglaFlete
    {
        public decimal CalcularFlete(Compra compra)
        {
            return 20m;
        }
    }
}
