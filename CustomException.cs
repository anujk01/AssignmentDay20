using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentDay20
{
    public class CustomException : Exception
    {
        public enum ExceptionType
        {
            NULL_Exception,
            EMPTY_Exception,
            Empty_Exception,
            Null_Exception,
            EMPTY_EXCEPTION
        }

        public readonly ExceptionType type;

        public CustomException(ExceptionType Type, String message) : base(message)
        {
            this.type = Type;
        }
    }
}