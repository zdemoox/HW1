using ДЗ1.BaseClasses;
using ДЗ1.Clinic;

namespace ДЗ1
{
    public class Zoo
    {
        private readonly List<Animal> _animals = new();
        private readonly List<Thing> _things = new();
        private readonly VeterinaryClinic _clinic;

        public Zoo(VeterinaryClinic clinic)
        {
            _clinic = clinic;
        }

        public void AddAnimal(Animal animal)
        {
            if (_clinic.CheckHealth(animal))
            {
                _animals.Add(animal);
                Console.WriteLine($"{animal.Name} добавлен в зоопарк.");
            }
            else
            {
                Console.WriteLine($"{animal.Name} не принят в зоопарк.");
            }
        }

        public void AddThing(Thing thing)
        {
            _things.Add(thing);
            Console.WriteLine($"{thing.Name} добавлен в инвентарь.");
        }

        public void PrintFoodReport()
        {
            int totalFood = _animals.Sum(a => a.Food);
            Console.WriteLine($"Общее количество еды: {totalFood} кг/день.");
        }

        public void PrintContactZooAnimals()
        {
            var contactAnimals = _animals.OfType<Herbo>().Where(a => a.KindnessLevel > 5);
            Console.WriteLine("Животные для контактного зоопарка:");
            foreach (var animal in contactAnimals)
            {
                Console.WriteLine($"{animal.Name} (Доброта: {animal.KindnessLevel})");
            }
        }

        public void PrintInventory()
        {
            Console.WriteLine("Инвентарь зоопарка:");
            foreach (var animal in _animals)
            {
                Console.WriteLine($"Животное: {animal.Name}, Номер: {animal.Number}");
            }
            foreach (var thing in _things)
            {
                Console.WriteLine($"Вещь: {thing.Name}, Номер: {thing.Number}");
            }
        }
    }
}
