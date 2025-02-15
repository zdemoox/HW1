using ДЗ1.BaseClasses;

namespace ДЗ1.Animals
{
    public class Tiger : Predator
    {
        public Tiger(string name, int food)
        {
            Name = name;
            Food = food;
            IsHealthy = true;
        }
    }

}
