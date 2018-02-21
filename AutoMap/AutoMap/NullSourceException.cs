using System;
using System.Runtime.Serialization;

namespace AutoMap
{
    [Serializable]
   public class NullSourceException : Exception
    {
        public NullSourceException()
        {
        }

        public NullSourceException(string message) : base(message)
        {
        }

        public NullSourceException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NullSourceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}