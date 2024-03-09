using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommanLibrary._0_CSharp_Basics
{
    
        public class Readonly_Constant
        {
            public Readonly_Constant()
            {
                //we can set/update the value of readonly
                time = 5;
                salary = 456;
                msg = "hii";
            }
            //constant-->compile time,run time
            //compile time-->value assigned at the 

            public const decimal gravity = (decimal)9.8;
            public const decimal pi = (decimal)3.14;
            public const string str = "hello";

            public void UpdateConstant()
            {
                //gravity = (decimal)6.8; //gives error cause value can't be assigned to a constant
                //pi = (decimal)8.76;
                //str = "hii";

            }

            //runtime constant

            public readonly int time = 10;
            public readonly decimal salary;
            public readonly string msg = "hello";

            public void UpldateReadonly()
            {
                //time = 5; //error,cause value can be assigned or reassigned  to the constructor of the class

                //salary = 34000; //error
                //msg = "hii";//error


            }
            public class Teacher
            {
               //public int Id { get; init; }

                //public string Name { get; set; }

                //public int MyProperty { get; set; }
            }

        }
    }


