using System;
using System.Runtime.Serialization;

namespace AutoMap
{
    [Serializable]
    public class ObjectHasNoDataException : Exception
    {
        public ObjectHasNoDataException()
        {
        }

        public ObjectHasNoDataException(string message) : base(message)
        {
        }

        public ObjectHasNoDataException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ObjectHasNoDataException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}