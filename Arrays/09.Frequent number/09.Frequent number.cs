//Problem 9. Frequent number
//Write a program that finds the most frequent number in an array.

using System;


namespace _09.Frequent_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array elements separated by space : ");
            string[] arrStr = Console.ReadLine().Split(' ');

            
            int count = 0, maxCount = 0, resultMember = 0;
            for (int index = 0; index < arrStr.Length - 1; index++)  
            {
                for (int nextIndx = index; nextIndx < arrStr.Length; nextIndx++) 
                {
                    if (arrStr[index] == arrStr[nextIndx]) count++;  
                }

                if (count > maxCount) { maxCount = count; resultMember = int.Parse(arrStr[index]); } 
                count = 0;  
            }

            Console.WriteLine("{0} ({1} times)", resultMember, maxCount);
        }
    }
}
