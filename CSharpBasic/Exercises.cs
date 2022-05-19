using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    public class Exercises
    {
        //1 - Write a method that takes two numbers and returns the multiplying of them. Example: 6*5 = 30

        //2 - Write a method that takes three numbers and returns the maximum number, Example: numbers: 2,8,5 --> returns 8

        //3 - write a method that takes four words and returns the words written backwards. Example: words: ana, are, multe, mere --> mere multe are ana

        //4 - write a method that takes a message and just prints that message to the console. Example: Duhamel --> in the console the word Duhamel will appear

        //Solution for 1)

        public int Multiply(int a, int b)
        {
            return a * b; 

        }
        public int Numbers(int x, int y, int z)
        {
            return Math.Max(Math.Max(x, y), z);
        }
        public string Sir(string c, string d, string e, string f)
        {
            return f + d + e + c;
        }
        public void Print(string txt)
        {
            Console.WriteLine(txt); 
        }
    }

   
}
