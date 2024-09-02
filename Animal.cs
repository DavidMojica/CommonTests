using System;

namespace test
{
    public abstract class Animal
    {
        private string name;
        private string description;
        private int age;
        private int Modifier;
        public string[] Razas;

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public int Age { get => age; set => age = value; }
        public int Modifier1 { get => Modifier; set => Modifier = value; }

        public Animal(string name, string description, int age, int modifier)
        {
            Name = name;
            Description = description;
            Age = age;
            Modifier1 = modifier;
            Razas = new string[4];
        }

        public virtual string Action()
        {
            return "Default action";
        }
    }

    public class Dog : Animal
    {
        public Dog(string name, string description, int age, int modifier) : base(name, description, age, modifier)
        {
            for (int i = 0; i < 4; i++)
            {
                this.Razas[i] = "Home crancy";
            }
        }
        public override string Action()
        {
            return "Ladrar";
        }
    }
}
