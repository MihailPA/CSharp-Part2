//Problem 11. Prefix "test"
//Write a program that deletes from a text file all words that start with the prefix test.
//Words contain only the symbols 0…9, a…z, A…Z, _.

using System;
using System.Text;
using System.IO;


namespace _11.PrefixTest
{
    class PrefixTest
    {
        static void Main()
        {
            using (StreamReader reader = new StreamReader("../../text.txt"))
            {
                using (StreamWriter output = new StreamWriter("../../fixed.txt"))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        if ((line[0] != 't') || (line[1] != 'e') || (line[2] != 's') || (line[3] != 't'))
                        {
                            output.WriteLine(line);
                        }
                        line = reader.ReadLine();
                    }
                }
            }
            Console.WriteLine("All words starting with \"test\" removed.");
        }
    }
}
