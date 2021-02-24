using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oyun
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 15;

            Console.WriteLine("sayı tahmin etme oyununa hoş geldiniiiiiz.");
            

            for (int i = 1; i < sayi; i++)
            {
                int tahmin = Convert.ToInt32(Console.ReadLine());

                if (tahmin == 25)
                {
                    Console.WriteLine("sıcak");

                }
                else if (tahmin == 20)
                {
                    Console.WriteLine("çok sıcaaaak");
                }
                else if (tahmin == 30)
                {
                    Console.WriteLine("eh işte");
                }
                else if (tahmin == 35)
                {
                    Console.WriteLine("soğuk");
                }
                else if (tahmin > 40) 
                {
                    Console.WriteLine("çok soğuk");
                }
                else if (tahmin >50)
                {
                    Console.WriteLine("çok soğuuuuk");
                }
                else if (tahmin == sayi)
                {
                    Console.WriteLine("sayıyı buldunuz tebrikler");
                    break;
                }
                
            }
            Console.ReadLine();


        }
    }
}
