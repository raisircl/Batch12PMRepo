using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// namespace it is a logical name which is given to set of classes it is just like as folder in os.
namespace ConsoleApp1
{
     class Table
    {
        static void Main()
        {
            int i, num;
            Console.WriteLine("Enter the number ");
            num = Convert.ToInt32(Console.ReadLine());
            for(i=1;i<=10;i++)
            {
                Console.WriteLine($"{num}x{i}={num*i}");
            }

        }
    }
}
