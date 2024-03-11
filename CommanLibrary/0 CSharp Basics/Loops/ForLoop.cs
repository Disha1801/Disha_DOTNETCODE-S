using System;using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;namespace ClassLibrary._00_CSharp_Basics.Loops{    public class ForLoop    {
        //If we know the number of times, we want to execute some set of statements or instructions, then we should use for loop.
        //For loop is known as a Counter loop.
        //Whenever counting is involved for repetition, then we need to use for loop.
        public void Number()        {            for (int i = 0; i <= 100; i++)            {                Console.WriteLine(i);            }        }        public void ReverseNumber()        {            for (int i = 100; i > 0; i--)            {                Console.WriteLine(i);            }        }    }}