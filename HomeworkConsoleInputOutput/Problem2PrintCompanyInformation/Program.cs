namespace Problem2PrintCompanyInformation
{
    using System;
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Company name: ");
            string companyName = Console.ReadLine();
            Console.WriteLine("Company address: ");
            string companyAddress = Console.ReadLine();
            Console.WriteLine("Phone number: ");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Fax number: ");
            string faxNumber = Console.ReadLine();
            Console.WriteLine("Web site: ");
            string webSite = Console.ReadLine();
            Console.WriteLine("Manager first name: ");
            string managerFirstName = Console.ReadLine();
            Console.WriteLine("Manager last name: ");
            string managerLastName = Console.ReadLine();
            Console.WriteLine("Manager age: ");
            string managersAge = Console.ReadLine();
            Console.WriteLine("Manager phone: ");
            string managersPhone = Console.ReadLine();

            Console.WriteLine("\n \n \n {0}\n Address: {1}\n Tel. {2}\n Fax: {3}\n Web site: {4}\n Manager: {5} {6} (age: {7}, tel. {8})", 
                companyName, companyAddress, phoneNumber, faxNumber, webSite, managerFirstName, managerLastName, managersAge, managersPhone);

        }
    }
}
