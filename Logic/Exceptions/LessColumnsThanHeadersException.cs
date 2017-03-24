using System;

namespace Logic.Exceptions
{
    public class LessColumnsThanHeadersException : Exception
    {
        public LessColumnsThanHeadersException(string message) : base(message)
        {
        }
    }
}