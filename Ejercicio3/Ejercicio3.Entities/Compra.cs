namespace Ejercicio3.Entities
{
    public class Compra
    {
        public string _nombre = "";
        public decimal _valor = 0m;

        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public decimal Valor { get { return _valor; } set { _valor = value; } }
        public Compra(string nombre, decimal valor)
        {
            _valor = valor;
            _nombre = nombre;
        }
    }
}
