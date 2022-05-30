using Ejercicio3.Entities;
List<Animal> animales = new() {
 new Gato(),
 new Leon(),
 new Perro(),
 new Lobo()
};

foreach (Animal animal in animales)
{
    Console.WriteLine(animal.ConocerAnimal());
}
