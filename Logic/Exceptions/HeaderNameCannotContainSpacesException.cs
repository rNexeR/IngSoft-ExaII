using System;

namespace Logic.Exceptions
{
    public class HeaderNameCannotContainSpacesException : Exception
    {
        public HeaderNameCannotContainSpacesException()
        {
        }

        public HeaderNameCannotContainSpacesException(string message) : base(message)
        {
        }
    }
}