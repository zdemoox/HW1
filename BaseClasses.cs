using ДЗ1.Interfaces;

namespace ДЗ1.BaseClasses
{
    public abstract class Animal : IAlive, IInventory
    {
        public int Food { get; set; } 
        public int Number { get; set; }
        public string Name { get; set; }
        public bool IsHealthy { get; set; }
    }

    public abstract class Thing : IInventory
    {
        public int Number { get; set; }
        public string Name { get; set; }
    }

    public abstract class Predator : Animal
    {
    }
    public class Herbo : Animal
    {
        public int KindnessLevel { get; set; }
    }
}
