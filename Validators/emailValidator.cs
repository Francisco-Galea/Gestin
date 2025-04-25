using Gestin.Controllers;
using Gestin.Model;
using Gestin.Properties;
using Gestin.UI.Custom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Gestin.Validators
{
    public static class emailValidator
    {
        public static bool isNull(string email)
        {
            return string.IsNullOrWhiteSpace(email);
        }

        public static bool IsValidEmail(string email)
        {
            return MailAddress.TryCreate(email, out _);
        }
    }
}
