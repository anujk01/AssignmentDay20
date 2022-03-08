using System;
using System.Runtime.Serialization;

namespace AssignmentDay20
{
    public class UC6_InvokedMethod
    {
        string message;
        public UC6_InvokedMethod()
        {
            Console.WriteLine("Default constructor");
        }
        public UC6_InvokedMethod(string message)
        {
            this.message = message;
        }

        public string AnalyzeMood()
        {
            try
            {
                if (message.Equals(string.Empty))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_EXCEPTION, "Mood should not be empty");
                }
                else if (message.ToLower().Contains("happy"))
                {
                    return "happy";
                }
                else
                {
                    return "sad";
                }
            }
            catch (NullReferenceException)
            {
                throw new CustomException(CustomException.ExceptionType.Null_Exception, "Mood should not be null");
            }
        }
    }
}