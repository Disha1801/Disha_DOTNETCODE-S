using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommanLibrary._01_OOPS
{
    
        //anything marked as static is basically invoked and controlled by CLR
        //static can be used with method/properties/class etc..

        public class StaticKeyword
        {

            #region StaticClass

            public static class MyStaticClass
            {
                //can;t create an instance of the static class
                //CLR will create and keep the instance of the static class

                //Then how will we access the memeber of a static class?
                //All the members of static class should also be static


                //member function

                public static void MyFunction()
                {
                    //it is mandatory to mark this function as static as the class itself is static.
                }
            }
            #endregion

            #region StaticMethod

            public class NonStaticClass
            {
                public static void StaticMethod()
                {

                }
            }
            #endregion

            #region StaticVariable

            public class NonStaticClassVar
            {
                //public NonStaticClassVar()
                //{
                //    Id = 1000;
                //}

                static NonStaticClassVar()
                {
                    Id = 1000;
                }
                public static int Id { get; set; }
            }

            #endregion
        }
    }

