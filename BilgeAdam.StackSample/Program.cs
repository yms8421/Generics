using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.StackSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //LIFO : Last In First Out
            var stack = new Stack<string>();
            stack.Push("Patates");
            stack.Push("Soğan");
            stack.Push("Elma");
            stack.Push("Armut");
            stack.Push("Domates");
            stack.Push("Mantar");

            var get1 = stack.Pop();
            var get2 = stack.Pop();

            stack.Push("Çilek");

            foreach (var s in stack)
            {

            }

            Console.ReadKey();
        }
    }
}
