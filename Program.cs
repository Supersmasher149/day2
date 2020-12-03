using System;
using System.Linq;

namespace day2
{
    class Program
    {
        static void Main()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\walte\source\repos\day2\TextFile1.txt");
            //Console.WriteLine(lines[0]);
            
             for (int i = 0; i < lines.Length; i++)
            {
                //splits the min string
                string[] min = lines[0].Split("-");
                //splits the max string
                string[] max = min[1].Split(" ");
                //splits the character
                string[] character = max[1].Split(":");
                //splits the password
                string password = max[2];

                //convertes max string[] into int
                int intMax = Int32.Parse(max[0]);
                //converts min string[] into int
                int intMin = Int32.Parse(min[0]);
                //converts character into a string
                string stringCharacter = character[0];
                //converts string character into a char
                char charCharacter = char.Parse(stringCharacter);
                //password already 

                //checks the frequency of the char
                int freq = password.Count(f => (f == charCharacter));

                if (freq <= intMax && freq >= intMin)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                Console.WriteLine(freq);
            }
        }
    }
}
