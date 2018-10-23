using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicalDemo
{
    public class Program
    {
         static void Main(string[] args)
        {
           int value = SummationValue(4, 3);
           
            Console.WriteLine("Summed up value is : " + value);
        }

        public static int SummationValue(int a, int b)
        {
            return (a + b);
        }

        public int Multiply(int a, int b)
        {
            return (a * b);
        }

		 public int Divide(int a, int b)
        {
            return (a / b);
        }
    }
}
