using Microsoft.Extensions.DependencyInjection;
using ДЗ1.Animals;
using ДЗ1.Clinic;
using ДЗ1.Things;
using ДЗ1;

class Program
{
    static void Main(string[] args)
    {
        var serviceProvider = new ServiceCollection()
            .AddSingleton<VeterinaryClinic>()
            .AddSingleton<Zoo>()
            .BuildServiceProvider();

        var clinic = serviceProvider.GetService<VeterinaryClinic>();
        var zoo = serviceProvider.GetService<Zoo>();

        zoo.AddAnimal(new Monkey("Мартышка", 2, 7));
        zoo.AddAnimal(new Rabbit("Кролик", 1, 6));
        zoo.AddAnimal(new Tiger("Тигр", 10));
        zoo.AddAnimal(new Wolf("Волк", 8));

        zoo.AddThing(new Table("Стол для кормления", 101));
        zoo.AddThing(new Computer("Компьютер для учета", 102));

        zoo.PrintFoodReport();
        zoo.PrintContactZooAnimals();
        zoo.PrintInventory();
    }
}