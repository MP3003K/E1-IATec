using Ejercicio2.Entities;

namespace Ejercicio2.Business
{
    internal class TablaDePrecioEstandar
    {

        private decimal descuento1 = 0.03m, descuento2 = 0.05m, descuento = 0m;
        public decimal descuentoPara(Compra compra)
        {

            if (compra.Valor > 1000)
            {
                descuento = compra.Valor * descuento1;
            }
            if (compra.Valor > 5000)
            {
                descuento = compra.Valor * descuento2;
            }
            return descuento;
        }
    }
}
