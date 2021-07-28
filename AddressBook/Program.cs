using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            Details details = new Details("Suhas","Shetty","Moodbidri","Karnataka","Mangalore",574227,7892112412,"scshetty07@gamil.com");
            details.Contact();
        }
    }
}
