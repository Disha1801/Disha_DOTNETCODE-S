using Microsoft.VisualBasic;using System;using System.Collections.Generic;using System.Diagnostics.Metrics;using System.Linq;using System.Text;using System.Threading.Tasks;namespace ClassLibrary._00_CSharp_Basics.Loops{
    //Loops are also called repeating statements or iterative statements
    //The process of repeatedly executing a statement or group of statements until the condition is satisfied is called looping.
    public class WhileLoop    {
        //A while loop is used for executing a statement repeatedly until a given condition returns false.
        //Here, statements may be a single statement or a block of statements.
        //The loop iterates while the condition is true. 

        //While we are working with a while loop first, we need to check the condition, if the condition is true then the control will pass within the body
        //and if the condition is false the control will pass outside the body.

        //When we are working with an iteration statement after execution of the body control will be passed back to the condition,
        //and until the condition become false. If the condition is not false then we will get an infinite loop.

        public void FibonacciSeries()        {            int a, b, c;            Console.Write("Enter the number: ");            int n = Convert.ToInt32(Console.ReadLine());            a = 0;            b = 1;            Console.Write($"{a} {b}");            c = a + b;            while (c <= n)            {                Console.Write($" {c}");                a = b;                b = c;                c = a + b;            }        }    }}