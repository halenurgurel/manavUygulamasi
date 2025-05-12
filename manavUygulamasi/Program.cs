/*using System;

namespace ManavIfYapisi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hangi meyveyi almak istiyorsunuz? ");
            string fruit = Console.ReadLine().ToLower();
            int price = 0;

            if (fruit == "elma")
            {
                price= 2;
            }
            else if (fruit == "armut")
            {
                price = 3;
            }
            else if (fruit == "çilek")
            {
                price = 2;
            }
            else if (fruit == "muz")
            {
                price = 3;
            }
            else if (fruit != "")
            {
                price = 4;
                Console.WriteLine($"{fruit} diğer meyve kategorisinde.");
            }
            else
            {
                Console.WriteLine("Hiçbir meyve girmediniz.");
            }

            if (fruit != "")
            {
                Console.WriteLine($"Fiyat: {price}₺");
            }
        } if yapısıyla hepsini tek tek kontrol edeceği için efektif olmayacak.
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
            Console.Write("Hangi meyveyi almak istiyorsunuz? ");
            string fruit = Console.ReadLine().ToLower();
            int price = 0;

            switch (fruit)
            {
                case "elma":
                    price = 2;
                    break;
                case "armut":
                    price = 3;
                    break;
                case "çilek":
                    price = 2;
                    break;
                case "muz":
                    price = 3;
                    break;
                default:
                    if (fruit != "")
                    {
                        price = 4;
                        Console.WriteLine($"{fruit} 4 TL.");
                    }
                    else
                    {
                        Console.WriteLine("Hiçbir meyve girmediniz.");
                    }
                    break;
            }

            if (fruit != "")
            {
                Console.WriteLine($"Fiyat: {price}₺");
            }
        }
    }
}
// switch yapısıyla sadece istediğimiz veriyi kontrol edeceği için debuglama kısmında daha efektif çalışacak.