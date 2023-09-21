using System;
using System.Linq.Expressions;
using System.Xml.Schema;

namespace ifElseStatement;

class Program
{
    static void Main(string[] args)
    {

        // Karar Mekanizmaları - Switch Case

        try
        {

            // manav | elma = 1 , armut = 1 , çilek = 2 , muz = 3 | 4
            Console.WriteLine("Hangi meyveyi almak istiyorsunuz?");
            string fruit = Console.ReadLine();
            Console.WriteLine("Kaç adet istiyorsunuz?");
            int number = Convert.ToInt32(Console.ReadLine());
            int totalPrice = 0;

            switch (fruit)
            {
                case "elma":
                case "armut":
                    //Console.WriteLine("1 Lira");
                    totalPrice = number * 1;
                    break;
                case "çilek":
                    //  Console.WriteLine("2 Lira");
                    totalPrice = number * 2;
                    break;
                case "muz":
                    // Console.WriteLine("3 Lira");
                    totalPrice = number * 3;
                    break;
                default:
                    //  Console.WriteLine("4 Lira");
                    totalPrice = number * 4;
                    break;

            }
            if (number >= 3)
            {
                Console.WriteLine(totalPrice + "Lira");
            }
            else
            {
                Console.WriteLine((totalPrice + 1) + "Lira");
            }
        }
        catch (Exception)
        {

        }
    }

    

}


// switch  genel olarak daha karmaşık yapılarda kullanılır.