using Gestin.Interfaces;
using Gestin.Model;
using Gestin.UI.Custom;
using System.Reflection;

namespace Gestin.Validators
{
    internal static class UserTypeValidator
    {
        private static readonly Dictionary<string, IUserType> userTypeInterface = new()
        {
            { "Estudiante", new Student() },
            { "Docente", new Teacher() }
        };


        private static readonly Dictionary<string, string> userTypeAsType = new()
        {
            { "Estudiante", "Gestin.Model.Student" },
            { "Docente", "Gestin.Model.Teacher" }
        };

        public static Type? getTypeConcrete(string userType)
        {
            try
            {
                if (userTypeAsType.ContainsKey(userType))
                {
                    return Type.GetType(userTypeAsType[userType]);
                }
            }
            catch (ArgumentException) { new MessageBoxDarkMode($"Tipo de usuario desconocido {nameof(userType)}", "ArgumentException", "Ok", Properties.Resources.Error); }
            catch (TargetInvocationException) { new MessageBoxDarkMode($"Object reflection error {nameof(userType)}", "TargetInvocationException", "Ok", Properties.Resources.Error); }
            return null;
        }

        public static IUserType getTypeAbstract(string userType)
        {
            if (userTypeInterface.ContainsKey(userType))
            {
                return userTypeInterface[userType];
            }
            throw new ArgumentException("Tipo de usuario desconocido", nameof(userType));
        }
    }
}
