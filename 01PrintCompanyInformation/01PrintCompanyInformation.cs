using System;

namespace PrintCompanyInformation

    //Problem 2. Print Company Information
    //A company has name, address, phone number, fax number, web site and manager. The manager has first name, 
    //last name, age and a phone number.
    //Write a program that reads the information about a company and its manager and prints it back on the console.

{
    class PrintCompanyInformation
    {
        static void Main()
        {
            Console.Write("Enter Company name: ");
            string company = (Console.ReadLine());

            Console.Write("Enter Company adress: ");
            string adress = (Console.ReadLine());

            Console.Write("Enter Company tel. Number: ");
            long telNumber = long.Parse(Console.ReadLine());

            Console.Write("Enter Company Fax Number: ");
            long faxNumber = long.Parse(Console.ReadLine());

            Console.Write("Enter Company Web Site: ");
            string webSite = (Console.ReadLine());

            Console.Write("Enter your manager First name: ");
            string firstName = (Console.ReadLine());

            Console.Write("Enter your manager Last name: ");
            string lastName = (Console.ReadLine());

            Console.Write("Enter your manager Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter your manager Tel. Number: ");
            long managerTelNumber = long.Parse(Console.ReadLine());


            Console.Title = "Your Company information";
            Console.WriteLine("\n Company Name: {0}\n Adress: {1}\n Tel:  {2}\n Fax: {3}\n Web Site: {4}\n", company, adress, telNumber, faxNumber, webSite);
            Console.WriteLine(" Your Manager info: {0} {1} ( Age: {2}, Tel. Number: {3} )", firstName, lastName, age, managerTelNumber );

        }
    }
}
