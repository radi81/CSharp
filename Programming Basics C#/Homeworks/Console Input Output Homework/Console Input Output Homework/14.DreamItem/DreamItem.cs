using System;

    class DreamItem
    {
        static void Main()
        {
            Console.WriteLine("Please enter input data in format " +  
            "Month\\Money por hour\\Hours per day\\Price of the item:");
            string[] inputInfo = Console.ReadLine().Split('\\');
            string month = inputInfo[0];
            decimal moneyPerHour = decimal.Parse(inputInfo[1]);
            decimal hoursPerDay = decimal.Parse(inputInfo[2]);
            decimal priceOfTheItem = decimal.Parse(inputInfo[3]);
            uint days;

            switch (month)
            {
                case "Feb": days = 28; break;
                case "Jan": 
                case "Mar":
                case "May":
                case "July":
                case "Aug":
                case "Oct":
                case "Dec": days = 31; break;
                default: days = 30; break;
            }
            days -= 10;
           decimal income = days * moneyPerHour * hoursPerDay;
            
            if (income > 700) 
            {
                income += income/10;
            }
            if (income >= priceOfTheItem)
            {
                Console.WriteLine("Money left = {0:F2} leva.", income - priceOfTheItem);
            }
            else
            {
                Console.WriteLine("Not enough money. {0:F2} leva needed", priceOfTheItem - income);
            }
        }
    }

