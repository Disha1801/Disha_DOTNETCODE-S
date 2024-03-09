using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CommanLibrary._0_CSharp_Basics
{
    //anything marked as static is basically 
    //invoked and controllled by CLR

    //STATIC CAN BE USED WITH METHOD/PROPERTIES AND CLASS ETC...
    #region Static class

    public class StaticKeyword
    {

        //cant create object for static class
        //CLR will create and keep instance of static class
        //Then how will we access members of static classs
        //all members of static class should also be static 
        
        //Memberfunction
        public static void MyFunction()
        {
            //call=>classname.methodname;
        }

    }

    #endregion


    #region Static Method

    public class nonstaticclass
    {
        public static void methodinnonstaticclass()
        {
            
            //Static method is called using name of the nonstatic class
            //we cant access it with object reference of non static method 
            //nonstaticclass.methodinnonstaticclass();
        }
    }
    #endregion

    //Variables


    public class VariableClass
    {
        public static int ID { get; set; }
           
    
    
    
    static VariableClass()
        {
            int id = 10000;

        }
            
            
            
            
            }
}
