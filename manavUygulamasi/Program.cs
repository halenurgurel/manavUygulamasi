/*
using System;

namespace ManavIfYapisi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elma 2 TL");
            Console.WriteLine("Armut 3 TL");
            Console.WriteLine("Çilek 2 TL");
            Console.WriteLine("Muz 3 TL");
            Console.WriteLine("Diğer meyveler 4 TL");
            Console.Write("Hangi meyveyi almak istiyorsunuz? ");


            string fruit = Console.ReadLine().ToLower();
            int price = 0;

            if (fruit == "elma" || fruit == "çilek")
            {
                price = 2;
            }
            else if (fruit == "armut" || fruit == "muz")
            {
                price = 3;
            }
            else
            {
                price = 4;
            }

                Console.WriteLine($"Seçtiğiniz meyvenin fiyatı: {price}");
        } //if yapısıyla hepsini tek tek kontrol edeceği için efektif olmayacak.
    }
}
*/




using System;

namespace ManavSwitchYapisi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elma 2 TL");
            Console.WriteLine("Armut 3 TL");
            Console.WriteLine("Çilek 2 TL");
            Console.WriteLine("Muz 3 TL");
            Console.Write("Hangi meyveyi almak istiyorsunuz? ");
            Console.WriteLine("Diğer meyveler 4 TL");
            string fruit = Console.ReadLine().ToLower();
            int price = 0;

            switch (fruit)
            {
                case "elma":
                case "çilek":
                    price = 2;
                    break;
                case "armut":
                case "muz":
                    price = 3;
                    break;
                default:
                    price = 4;
                    break;
            }
            Console.WriteLine($"Seçtiğiniz meyvenin fiyatı: {price} TL");
        }
    }
}

// switch yapısıyla sadece istediğimiz veriyi kontrol edeceği için debuglama kısmında daha efektif çalışacak.