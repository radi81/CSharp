using System;

namespace Animals
{
    abstract class Animal : ISoundProdusible
    {
        protected string name;
        protected double age;
        protected string gender;

        public Animal(string name, double age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public double Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        public string Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                this.gender = value;
            }
        }

        public abstract void ProduceSounds();

        public override string ToString()
        {
            string output = string.Format("{0} - {1} - {2}",
                this.Name, this.Age, this.gender);
            return output;
        }
    }
}
