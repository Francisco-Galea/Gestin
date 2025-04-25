using Gestin.Properties;
using Gestin.UI.Custom;

namespace Gestin.Exceptions
{
    [Serializable]
    internal class ExistingTeacherChargeException : Exception
    { 
        public ExistingTeacherChargeException() { }

        public ExistingTeacherChargeException(string message) : base(message) { }

        public ExistingTeacherChargeException(string message, Exception innerException) : base(message, innerException) { }
    }
}
