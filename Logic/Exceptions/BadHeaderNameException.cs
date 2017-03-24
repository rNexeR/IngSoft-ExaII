using System;

namespace Logic.Exceptions
{
    public class BadHeaderNameException : Exception
    {
        public BadHeaderNameException(string message) : base(message)
        {
        }
    }
}