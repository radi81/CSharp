using System;

namespace Animals
{
    class Dog : Animal
    {
        public Dog(string name, double age, string gender)
            :base(name, age, gender)
        {
        }

        public override void ProduceSounds()
        {
            Console.WriteLine("Bau-bau");
        }

        public override string ToString()
        {
            string output = string.Format("{0} - {1} - {2}",
                this.Name, this.Age, this.gender);
            return output;
        }
    }    
}
