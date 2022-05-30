using Ejercicio3.Data;
using Ejercicio3.Entities;

namespace Ejercicio3.Business
{
    public class CierreDeCaja
    {
        List<IAccionesCompras> _acciones = new()
        {
            new GuardarEnDB(),
            new GenerarReporte(),
            new GuardarComoPDF(),
            new Imprimir(),
        };

        public void ProcesarCompras(List<Compra> compras)
        {
            foreach (IAccionesCompras accion in _acciones)
                accion.Ejecutar(compras);
        }
    }
}
