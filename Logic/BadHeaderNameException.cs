using System;

namespace Logic.Exceptions
{
    internal class BadHeaderNameException : Exception
    {
        public BadHeaderNameException(string message) : base(message)
        {
        }
    }
}