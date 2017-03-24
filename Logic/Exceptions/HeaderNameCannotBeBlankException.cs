using System;

namespace Logic.Exceptions
{
    public class HeaderNameCannotBeBlankException : Exception
    {
        public HeaderNameCannotBeBlankException()
        {
        }

        public HeaderNameCannotBeBlankException(string message) : base(message)
        {
        }
    }
}