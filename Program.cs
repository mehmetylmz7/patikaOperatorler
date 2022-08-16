using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patikaOperatorler
{
    class Program
    {
        static void Main(string[] args)
        {

            // atama ve işlemli atama 

            int x = 2;
            int y = 3;

            y = y + 2;
            Console.WriteLine(y);

            y += 2;
            Console.WriteLine(y);

            x *= 5;
            Console.WriteLine(x);


            // mantiksal operatorler

            //         &&(ve),||(veya),!(degil)

            bool isSuccess = true;
            bool isCompleted = false;
             
            if(isSuccess && isCompleted)
                Console.WriteLine("perfect"); // iki deger de true olmadigindan perfect yazisi ekrana yazılamaz

            if (isSuccess || isCompleted)
                Console.WriteLine("great");   // herhangi bir degerin true olmasi nedeniyle great yazisi ekrana yazilir

            if (isSuccess && ! isCompleted)
                Console.WriteLine("fine");   // iki deger de true oldugundan fine yazisi ekrana yazilir


            //ilişkisel operatorler

            int a = 3;
            int b = 4;
            bool sonuc = a < b;

            Console.WriteLine(sonuc);

            sonuc = a > b;
            Console.WriteLine(sonuc);
            sonuc = a >= b;
            Console.WriteLine(sonuc);
            sonuc = a <= b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);
            sonuc = a != b;
            Console.WriteLine(sonuc);




            // aritmetik operatorler
            // /,*,-,+

            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1 / sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 * sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 + sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 ++;
            Console.WriteLine(sonuc1);

            // % mod alma operatoru
            int sonuc2 = 100 % 3; // 100un 3e boulumunden kalan 1 oldugu icin sonuc 1 dir
            Console.WriteLine(sonuc2);



            Console.ReadLine();






        }
    }
}
