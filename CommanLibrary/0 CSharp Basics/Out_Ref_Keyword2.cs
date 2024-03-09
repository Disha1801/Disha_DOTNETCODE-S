using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommanLibrary._0_CSharp_Basics
{
   
    
        public class Out_Ref_keyword2
        {
            #region MyRegion
            //inside the class, statement is not allowed
            //statement:- Console.WriteLine('hello');
            //for(int i=0;i<=10;i++){
            //Console.WriteLine(i);
            //}--->not allowed

            //defining another class inside a class is allowed
            //public class Test
            //{
            //}

            //to allow the statement inside the class write the statement inside the method
            //public void show() { Console.WriteLine('hello'); } -->allowed
            //public string Name{get;set;}
            //public Out_Ref_keyword(){}
            //allowed
            //    int a = 1;
            //    int b = 2;

            #endregion



            //Ref keyword:- need to initialize the ref parameter,need initial value
            //Out keyword:- does not require intialization


            public void Demo()
            {
                int a = 1; //"1"
                int b = 2;  //"2"
                int i = 1;
                int total;
                int j = 0;
                Console.WriteLine(a + "-" + b);
                swap(ref a, ref b, out total);
                Console.WriteLine(a + "-" + b + "-" + total);

                Console.WriteLine("-------------------ref keyword-------------------");
                Console.WriteLine(i);
                addRef(ref i);
                Console.WriteLine(i);

                Console.WriteLine("------------------out keyword----------------------");

                Console.WriteLine(j);
                addOut(out j);
                Console.WriteLine(j);

                Console.WriteLine("---------------------------");

                int sum;
                int differ;
                decimal avg;
                int mul;
                calculate(a, b, out sum, out differ, out avg, out mul);

                Console.WriteLine("Sum - " + sum);
                Console.WriteLine("Difference - " + differ);
                Console.WriteLine("Average - " + avg);
                Console.WriteLine("Multiply - " + mul);




                //output:
                //1-2
                //1-2

                //excepted output: 
                //1-2
                //2-1

            }
            public void addRef(ref int id)
            {
                id = id + 1;

            }
            public void addOut(out int id)
            {
                id = 1;
            }
            public void swap(ref int a, ref int b, out int total)
            {
                int c = b;
                b = a;
                a = c;
                total = a + b;

            }

            public void calculate(int a, int b, out int sum, out int differ, out decimal avg, out int mul)
            {
                sum = a + b;
                differ = a - b;
                avg = (a + b) / 2;
                mul = a * b;
            }



        }
    }


