using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = 0;
            while (counter <= 5)
            {
                ForLoop((counter + 1) * 5);
                counter++;
            }
            Console.ReadLine();
        }

        static void ForLoop(int count)
        {
            for (int i = 0; i <= count; i++)
            {
                Console.WriteLine(String.Format("I would like {0} doob(s) pls.", i));
            }
        }
    }
}
