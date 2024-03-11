using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary._02_Exception_handling
{
    public class Cube
    {
        public static void CubeNumber()
        {
            try
            {
                Console.WriteLine("Enter the number: ");
                int value = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Cube of {value} is {value * value * value}");
            }
            catch (Exception e)
            {
                //catch cannot have both catch and catch(Exception ex)
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Execution finished.............");
            }
        }

        public static void NestedException()
        {
            int d=0;
            try

            {
                try
                {
                    int result = 100 /d;
                }
                catch (Exception e)
                {
                    Console.WriteLine(" Error :" +e);
                }
            }
            catch
            {
                Console.WriteLine("cannot divide by zero");
            }


        }
    }
}
