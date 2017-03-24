using System;

namespace Logic.Exceptions
{
    public class MoreColumnsThanHeadersException : Exception
    {
        public MoreColumnsThanHeadersException(string message) : base(message)
        {
        }
    }
}