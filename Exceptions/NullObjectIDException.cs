namespace Gestin.Exceptions
{
    [Serializable]
    internal class NullObjectIdException : Exception
    {
        public NullObjectIdException() { }

        public NullObjectIdException(string message) : base(message) { }

        public NullObjectIdException(string message, Exception innerException) : base(message, innerException) { }
    }
}
