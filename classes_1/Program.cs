using System;

namespace classes_1
{
    class Program
    {
        class Addres
        {
            public int index { get; set; }
            public string country { get; set; }
            public string street { get; set; }
            public int house { get; set; }
            public int apartment { get; set; }
            public void GetInfo()
            {
                Console.WriteLine($"index {index},country {country}, street {street}, house {house}, apartment {apartment}");
            }
        }
        static void Main(string[] args)
        {
            Addres addres = new Addres();
            addres.index = 000000;
            addres.country = "Country";
            addres.street = "Street";
            addres.house = 1;
            addres.apartment = 1;
            addres.GetInfo();
            Console.ReadKey();
        }
    }
}
