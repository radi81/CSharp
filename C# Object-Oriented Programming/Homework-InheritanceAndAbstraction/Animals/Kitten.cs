using System;

namespace Animals
{
    class Kitten : Cat
    {

        public Kitten(string name, double age)
            : base(name, age, "female")
        {
        }

        public override void ProduceSounds()
        {
            Console.WriteLine("Miiiiau-miiiiiiau");
        }

        public override string ToString()
        {
            string output = string.Format("{0} - {1} - {2}",
                this.Name, this.Age, this.gender);
            return output;
        }
    }
}
