using polimorfismo1;

Animal[] animal = new Animal[2];

animal[0] = new Mamiferos(" Leao ");
animal[1] = new Repteis(" cobra ");

caracteristicasAnimal(animal[0]);
caracteristicasAnimal(animal[1]);

Console.ReadKey();

static void caracteristicasAnimal(Animal animal)
{
    Console.Write(animal.getTipo());
    animal.caracteristicas();
}