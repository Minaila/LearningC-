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

        //5 - write a method called OpenCarWindow that takes the speed of the car as an INT Parameter and returns true or false whether it can open the window:
            // speed < 10 --> it can open the window
            // speed = 10 ---> it can open the window but in adition to that it show you the message "If you go faster I wont be able to open it"
            // speed > 10 --> it cant open the window 

        //6 -  write a program in C# Sharp to create a function to input a string and count number of spaces are in the string
            //ex: This is a test string. --> will return value 4 (because there are 4 spaces)

        //7 - write a method called TellMeIfItsSunnyOutsiode that will take an int parameter as the temperature and:
            // if the temperature is greater than 30 it will show the message "Yes, it's hot outside" to the console
            // if is between 15 and 30 it will show the message "It is sunny but take a coat with you"
            // below 15 - "It's not sunny today outside"




        // PRIMA APLICATIE
        // Name: PCCleaner
        // Features: 
            //1) Sa ii poti da ca input un folder de pe calculator unde sa faca curat si o data (daca nu ii dai data atunci by default va lua data de azi)
            //2) Programul va sterge automat orice fisier e in folder care a fost adaugat / modificat inainte de data pe care ai bagat-o la pasul 1)
            //3) Inainte sa stearga tot sa te intrebe daca vrei sa faca un backup la fisiere - in caz ca zici ca vrei backup el va copia fisierele in alt folder iar 
            //apoi va curata folderul respectiv. Daca nu vrei backup va executa efectiv pasul 2)


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
        public bool OpenCarWindow(int speed)
        {
            if(speed < 10)
            {
                Console.WriteLine("the window can be opened");
                return true;
            }
            if(speed == 10)
            {
                Console.WriteLine("the window can be opened, but if you go faster it won't open");
                return true;
            } 
            else             
            {
                Console.WriteLine("window can not be opened");
                return false;
            }
        }
    }

   
}
