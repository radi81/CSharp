using System;

namespace Animals
{
    class Tomcat : Cat
    {
        public Tomcat(string name, double age)
            : base(name, age, "male")
        {
        }

        public override void ProduceSounds()
        {
            Console.WriteLine("Mauuuuuuuu");
        }

        public override string ToString()
        {
            string output = string.Format("{0} - {1} - {2}",
                this.Name, this.Age, this.gender);
            return output;
        }
    }
}
