﻿namespace Ejercicio3.Entities
{
    public class Perro : Canido
    {
        string _sonido = "ladrido", _alimento = "carnívora", _nombreCientifico = "Canis lupus familiaris";
        public override string Sonido { get { return _sonido; } set { _sonido = value; } }
        public override string Alimento { get { return _alimento; } set { _alimento = value; } }
        public override string NombreCientifico { get { return _nombreCientifico; } set { _nombreCientifico = value; } }

    }
}
