using System;

namespace Animals
{
    class Frog : Animal
    {
        public Frog(string name, double age, string gender)
            : base(name, age, gender)
        {
        }

        public override void ProduceSounds()
        {
            Console.WriteLine("Kria-kria");
        }

        public override string ToString()
        {
            string output = string.Format("{0} - {1} - {2}",
                this.Name, this.Age, this.gender);
            return output;
        }
    }
}
