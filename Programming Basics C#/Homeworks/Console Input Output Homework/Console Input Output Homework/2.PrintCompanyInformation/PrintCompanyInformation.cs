using System;

    class PrintCompanyInformation
    {
        static void Main()
        {
            Console.Write("Company name: ");
            string companyName = Console.ReadLine();
            Console.Write("Company adress: ");
            string companyAdress = Console.ReadLine();
            Console.Write("Phone number: ");
            long phoneNumber = long.Parse(Console.ReadLine());
            Console.WriteLine("Fax number: ");
            int? faxNumber = null; 
            Console.Write("Web site: ");
            string webSite = Console.ReadLine();
            Console.Write("Manager first name: ");
            string managerFirstName = Console.ReadLine();
            Console.Write("Manager last name: ");
            string managerLastName = Console.ReadLine();
            Console.Write("Manager age: ");
            byte managerAge = byte.Parse(Console.ReadLine());
            Console.Write("Manager phone: ");
            long managerPhone= long.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("{0}", companyName);
            Console.WriteLine("Address: {0}", companyAdress);
            Console.WriteLine("Tel. {0:+### ### ## ## ##}", phoneNumber);
            Console.WriteLine("Fax: {0}", faxNumber);
            Console.WriteLine("Web site: {0}", webSite);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3:+### # ### ###})",
                managerFirstName, managerLastName, managerAge, managerPhone);
        }
    }

