namespace Ejercicio3.Entities
{
    public abstract class Animal
    {
        public abstract string Sonido { get; set; }
        public abstract string Alimento { get; set; }
        public abstract string NombreCientifico { get; set; }
        public string ConocerAnimal()
        {
            return "El animal " + $"{base.ToString().Remove(0, 20)}" + " de nombre Científico " + NombreCientifico + ", su alimentacion es " + Alimento + " y el ruido que hace es " + Sonido;
        }

    }
}
