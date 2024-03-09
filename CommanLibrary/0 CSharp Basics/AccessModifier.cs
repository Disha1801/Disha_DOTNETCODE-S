using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommanLibrary._0_CSharp_Basics
{
    
    
    //public=>within same and outside 
    //private=>within same class only
    //protected=>within class and outside with inheritance
    //internal=>within same project or library
    //protected internal=>in same project and in derived classes
    //private protected=>restricts access to derived class within same assemblyi.e,project or library
   
    //Important note:
    //A class directly  inside a NameSpace can not have private/protected/protected internal
    //private protected
    //
    //private class AccessModifier

    //{

   //a private class can only be a member of other class
   //not a valid class 

    //}

    //public->can accessed anywhere
    //internal=>can be accessed anywhere inside the same  project
    //private=>can be accessed within the class in which it is declared
    //protected=>can be declared by the same class and also by the derived class
    //protected internal=>same as above but also only in the same class
    //<--IMPORTANT-->
    //by default=>a class inside the namesapace is Internal if no access modifier is written
    
    //private protected=>to doooooooooooooo//

    class ClassWithoutAnyAccessSpecifier
    {

//The default access specifier of this class is internal 

    }
    internal class InternalClass
    {

    }
    internal class internalClass
    {
        public class PublicClass
        {
            //itcannot be accessed as it is child of internal
        }
    }
    public class PublicClass
    {

    }
    public class APublicClassToDemoOtherAccessModifier//<--
    {
        public void Method()
        {
            withoutanyaccessmodifier obj= new withoutanyaccessmodifier();
            //obj.APrivateMethod();
            obj.publicmethod();
            obj.internalmethod();
        }
        internal class aninternalclass
        {

        }
        class withoutanyaccessmodifier
        {
            private void APrivateMethod()
            {

            }
            public void publicmethod()
            {

            }
            internal void internalmethod()
            {

            }
        }

        private class APrivateClass
        {

        }
        protected class AProtectedClass
        {

        }
        protected internal class AProtectedInternalClass
        {
           
        }





    }


}
