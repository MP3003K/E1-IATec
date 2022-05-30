namespace Ejercicio2.Entities
{
    public class Compra
    {
        public int Id { get; set; }
        public Ciudad CiudadEnum { get; set; }
        public decimal Valor { get; set; }

        public Compra(int id, Ciudad ciudadEnum, decimal valor)
        {
            Id = id;
            CiudadEnum = ciudadEnum;
            Valor = valor;
        }
    }
}
