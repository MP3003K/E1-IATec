namespace Ejercicio3.Entities
{
    public class Lobo : Canido
    {
        string _sonido = "aullido", _alimento = "carnívora", _nombreCientifico = "Canis lupus";
        public override string Sonido { get { return _sonido; } set { _sonido = value; } }
        public override string Alimento { get { return _alimento; } set { _alimento = value; } }
        public override string NombreCientifico { get { return _nombreCientifico; } set { _nombreCientifico = value; } }

    }
}
