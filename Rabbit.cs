using ДЗ1.BaseClasses;

namespace ДЗ1.Animals
{
    public class Rabbit : Herbo
    {
        public Rabbit(string name, int food, int kindnessLevel)
        {
            Name = name;
            Food = food;
            KindnessLevel = kindnessLevel;
            IsHealthy = true;
        }
    }
}
