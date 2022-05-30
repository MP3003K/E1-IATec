using Ejercicio3.Business;
using Ejercicio3.Entities;

List<Compra> listaDeCompras = new()
{
  new Compra("Compra1",7.5m),
  new Compra("Compra2",9.3m)
};
var cierreCaja = new CierreDeCaja();
cierreCaja.ProcesarCompras(listaDeCompras);
