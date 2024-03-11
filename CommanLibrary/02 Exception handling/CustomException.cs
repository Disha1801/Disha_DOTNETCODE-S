using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary._02_Exception_handling
{
    public class CustomException: Exception
    {
        public CustomException()
        { }

        public CustomException(string str):base(str)
        {
           
        }
    }

    public class CustomException2 {
        public static void MobileNumber(string mobile)
        {
            try
            {
                if (mobile.Length != 10)
                    throw new CustomException("Please enter 10 digit number");
                if (mobile.Contains("+"))
                    throw new CustomException("Please don't include +");
                if (!mobile.StartsWith("91"))
                    throw new CustomException("Please start your number with 91");
                {
                    
                }
                Console.WriteLine(mobile);
            }
            catch(Exception e)
            {
                Console.WriteLine("Error Occured: " + e.Message);
            }
        }
    }
}
