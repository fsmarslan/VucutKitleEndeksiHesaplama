using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VucutKitleEndeksiHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kilonuzu kg cinsinden giriniz: ");
            double kilo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Boyunuzu metre cinsinden giriniz: ");
            double boy = Convert.ToDouble(Console.ReadLine());

            double vke = kilo / (boy * boy);

            if (vke < 18.49)
            {
                Console.WriteLine("İdeal kilonuzun altındasınız");
                Console.WriteLine("Vücut kitle endeksiniz: {0}",vke);
            }
            else if (vke>=18.5 && vke<=24.99)
            {
                Console.WriteLine("İdeal kilonuzdasınız");
                Console.WriteLine("Vücut kitle endeksiniz: {0}", vke);
            }
            else if (vke>=25 && vke<=29.99)
            {
                Console.WriteLine("İdeal kilonuzun üstündesiniz");
                Console.WriteLine("Vücut kitle endeksiniz: {0}", vke);
            }
            else
            {
                Console.WriteLine("İdeal kilonuzun çok üstündesiniz");
                Console.WriteLine("Vücut kitle endeksiniz: {0}", vke);
            }
            Console.ReadKey();
        }
    }
}
