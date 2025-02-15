using ДЗ1.BaseClasses;
namespace ДЗ1.Animals
{
    public class Wolf : Predator
    {
        public Wolf(string name, int food)
        {
            Name = name;
            Food = food;
            IsHealthy = true;
        }
    }
}
