using System;

namespace day2
{
    class Program
    {
        static void Main()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\walte\source\repos\day2\TextFile1.txt");
            Console.WriteLine(lines[0]);
            
            //splits the min string
            string[] min = lines[0].Split("-");
            //splits the max string
            string[] max = min[1].Split(" ");
            //splits the character
            string[] character = max[1].Split(":");
            //splits the password
             
            
            //convertes max string[] into int
            int intMax = Int32.Parse(max[0]);
            //converts min string[] into int
            int intMin = Int32.Parse(min[0]);
            //convert character into a string
            string stringCharacter = character[0];

            
            Console.WriteLine(max[2]);
        }
    }
}
