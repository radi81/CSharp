using System;
using System.Linq;

namespace Animals
{
    class Program
    {
        static void Main()
        {
            Dog dog = new Dog("Bendji", 5, "male");
            Frog frog1 = new Frog("Jaba", 1, "female");
            Frog frog2 = new Frog("Jabo", 2, "male");
            Frog frog3 = new Frog("Jabcho", 1, "male");
            Cat cat1 = new Cat("Pisi", 2, "female");
            Cat cat2 = new Cat("Lyki", 1, "male");
            Kitten kitten1 = new Kitten("Maca", 1);
            Kitten kitten2 = new Kitten("Kitty", 2);
            Kitten kitten3 = new Kitten("Pisa", 2);
            Tomcat tomcat = new Tomcat("Tom", 5);

            Animal[] animals = { dog, frog1, frog2, frog3, cat1, cat2,
                kitten1, kitten2, kitten3, tomcat };

            animals[2].ProduceSounds();
            
            var animalGroups =
                (from animal in animals
                 group animal by animal.GetType().Name into groups
                 select new
                 {
                     groupName = groups.Key,
                     averageSum =
                         (from a in groups
                          select a.Age).Average(),
                     groupList = groups.ToList()
                 });

            foreach (var group in animalGroups)
            {              
                Console.WriteLine("Average age of {0} is {1}",
                    group.groupName + "s", Math.Round(group.averageSum, 1));
            }
        }
    }
}
