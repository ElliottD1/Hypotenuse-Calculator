using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is side A");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is side B");
            double b = Convert.ToDouble(Console.ReadLine());
            double c= (Math.Sqrt(a*a + b*b));
            Console.WriteLine("The hypotenus of A and B is "+c);
            
            Console.ReadKey();

        }
    }
}
// Convert to int for input
//int i = 0;
//while (i <10 )
//{
//    Console.WriteLine("Give me your age:");
//    int name = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine(name);

//    Console.ReadKey();
//}


//random num
//Random random = new Random();
//  Console.WriteLine(random.Next(1,11));