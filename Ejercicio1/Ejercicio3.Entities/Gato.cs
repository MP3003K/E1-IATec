namespace Ejercicio3.Entities
{
    public class Gato : Felino
    {
        string _sonido = "maullido", _alimento = "ratones", _nombreCientifico = "Felis silvestris catus";

        public override string Sonido { get { return _sonido; } set { _sonido = value; } }
        public override string Alimento { get { return _alimento; } set { _alimento = value; } }
        public override string NombreCientifico { get { return _nombreCientifico; } set { _nombreCientifico = value; } }
    }
}
