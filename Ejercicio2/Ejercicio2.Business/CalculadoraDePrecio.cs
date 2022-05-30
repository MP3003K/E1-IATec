using Ejercicio2.Entities;

namespace Ejercicio2.Business
{
    public class CalculadoraDePrecio
    {
        private decimal total = 0m, fleteValor = 0m, descuento = 0m;
        TablaDePrecioEstandar precioestandar = new();
        Flete Claseflete = new();

        public decimal CalcularPrecio(List<Compra> compras)
        {
            foreach (Compra compra in compras)
            {
                descuento = precioestandar.descuentoPara(compra);
                fleteValor = Claseflete.CalcularParaCiudad(compra);
                total = total + compra.Valor + fleteValor - descuento;
                Console.WriteLine(total);
            }
            return total;
        }
    }
}
