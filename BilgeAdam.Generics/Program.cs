using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BilgeAdam.Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Bir Sayı Giriniz.....: ");
            //var j = int.Parse(Console.ReadLine());

            //Console.Write("Bir Sayı Giriniz.....: ");
            //var k = int.Parse(Console.ReadLine());
            var mh = new MathHelper();
            var s = mh.Sum(5, 12);
            var c = mh.Sum("Can", "Perk");
            //var t1 = mh.Sum<int>(5, 12);
            //var t2 = mh.Sum<string>("Can", "Perk");

            

            //var rnd1 = new Random();
            //var rnd2 = new Random();
            //aşağıdaki işlem kullanılabilir değil
            //var r2 = mh.Sum<Random>(rnd1, rnd2);
            //Console.WriteLine(s);
            //Console.WriteLine(c);


            var f1 = new Field { Edge1 = 4, Edge2 = 4 };
            var f2 = new Field { Edge1 = 2, Edge2 = 5 };
            var area1 = mh.Sum<Field>(f1, f2);
            var area2 = f1 + f2;


            var m1 = new Monster { Attack = 10 };
            var m2 = new Monster { Attack = 60 };
            var attack = mh.Sum<Monster>(m1, m2);

            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }

    //interface ISummable
    //{
    //    decimal Sum(int left, int right);
    //    decimal Sum(decimal left, decimal right);
    //}
}
/*
 string bir değer ile toplanan tüm değerler .ToString() ile öncelikle string'e çevrilir ve sonra toplanır
     */