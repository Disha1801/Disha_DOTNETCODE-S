using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommanLibrary._01_OOPS
{
    
        //a class directly inside a namespace can not have private/protected/protected internal/private/private protected
        //private class AccessModifier{
        //  not a valid class
        //}

        //public--->can accessed anywhere
        //internal--->can be accessed anywhere inside the same project
        //private--->can only be accessed within the class in which it is declared
        //protected--->can be accessed by the same class and also y the derived class
        //protected internal--->same as above but also only in the same class
        //private protected--->

        //by default a class inside the namespace is internal if no access modifier is written.

        class ClassWithOutAcsessModifier2
        {
            //the default access specifier of this class is internal
        }
        internal class ClassWithInternal
        {

            public class AClassWithPublic
            {
                //not accessible
            }
        }

        public class ClassWithPublic
        {

        }
        public class APublicClassToOtherAccessModifier
        {
            public void Method()
            {
                AClassWithoutAccessModifier obj = new AClassWithoutAccessModifier();
                obj.AClassWithoutPublic();
                obj.AClassWithoutInternal();
                //obj.AClassWithPrivate(); //error
                //obj.MethodWithoutModifier(); //error
            }
            class AClassWithoutAccessModifier
            {
                private void AClassWithPrivate()
                {

                }
                public void AClassWithoutPublic()
                {

                }
                internal void AClassWithoutInternal()
                {
                    MethodWithoutModifier();
                }
                void MethodWithoutModifier()
                {
                    //this will act as a private member
                }

            }
            internal class AnInternalClass
            {

            }
            private class AClassWithPrivate
            {

            }
            public class AClassWithPublic
            {

            }
            protected class AClassWithProtected
            {

            }
            protected internal class AClassWithProtectedInternal
            {

            }
        }
    }


