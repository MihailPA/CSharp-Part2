//

using System;

namespace _08.BinaryShort
{
    class BinaryShort
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter a 16-bit signed integer (short): ");
            short number = short.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));
        }
    }
}
