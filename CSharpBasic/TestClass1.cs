using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    internal class TestClass1
    {


        private int i = 0;

        public void SetValue(int value)
        {
            i = value;
        }
        public void GetValue()
        {
            Console.WriteLine(" the value of I : " + i);
        }
        // Members 
        public void TestCase1(string result)   //asta e o metoda 
        {
            Console.WriteLine("Executing test case 1 " + result);
        }

        public void TestCase2(string result)
        {
            Console.WriteLine("Execute test case 2 " + result);
        }

    }
}
