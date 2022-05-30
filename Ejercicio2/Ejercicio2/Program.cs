

using Ejercicio2.Business;
using Ejercicio2.Entities;

List<Compra> listaDeCompras = new()
{
  new Compra(1,Ciudad.Santiago,1000m),
  new Compra(2,Ciudad.Cusco,9000m),
  new Compra(1,Ciudad.RioDeJaneiro,4000m),

};

CalculadoraDePrecio calculadora = new CalculadoraDePrecio();
Console.WriteLine(calculadora.CalcularPrecio(listaDeCompras));
