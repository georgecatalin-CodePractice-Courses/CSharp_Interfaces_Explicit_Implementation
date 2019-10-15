using System;

namespace OddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Odd Numbers:");
            var myObject = new OddGenerator();
            foreach (var item in myObject)
            {
                if (item>50)
                {
                    break;          
                }
                Console.WriteLine(item);
            }

            Console.Read();
        }
    }
}
