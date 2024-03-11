using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary._02_Exception_handling
{
    public class ExceptionHandling
    {
        //always us throw keyword when you want to have adetailed stack trace for an error
        public static void Normal_Method()
        {
            try
            {
                AdvancedSolution();//execute noramally without try and catch
                ThrowSolution(); //without  try catch throw an error and stop the executuin
            }
            catch
            {
                throw; //we can do this also
            }
        }
        public static void Error()
        {
            int a = 0;
            //a = "abcabc"; //compile time error, cause we are getting the error when we are writing it,No solution of compile time errkr apart from solving them before execution
            int b = 100;
            int c = b / a; //runtime error, cannot divide by 0

        }

        public static void Solution()
        {
            try
            {
                int a = 0;
                int b = 100;
                int c = b / a;
            }
            catch
            {
                Console.WriteLine("sorry! cannot divide by zero");
            }
        }

        public static void AdvancedSolution()
        {
            try
            {
                int a = 0;
                int b = 100;
                int c = b / a;
            }
            catch (Exception e)  //e is of type Exception
            {
                Console.WriteLine("Error: " + e.Message);
                Console.WriteLine("Error: " + e.StackTrace);

            }
        }

        public static void ThrowSolution()
        {
            try
            {
                int a = 0;
                int b = 100;
                int c = b / a;
            }
            catch (Exception e)  //e is of type Exception
            {
                Console.WriteLine("Error: " + e.Message);
                //throw e; //throw an exception and display full informatio and stop the execution

            }
        }

        #region MultipleCatch

        public static void MultipleException(string str)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(str))
                    throw new ArgumentNullException();
                int[] arr = new int[2];
                arr[0] = 1;
                arr[1] = 0;
                Console.WriteLine(arr[0]);
                Console.WriteLine(arr[1]);
               

                Console.WriteLine(arr[2]);  //runtime error

                int c = arr[0] / arr[1];  //division error
            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("Index Out of range");
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("cannot divide by zero");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally //it will execute whether is an error/exception or not
            {
                //finally block isnalways executed even if there are errors/exceptions in the respective method
                //finally block can exist without a catch block, it does not exist only there should be a try block whereas catch block is not necessaryfor finaaly 

                Console.WriteLine("Execution Finished");
            }
            #endregion

       
        }
    }
}