using Gestin.Controllers;
using Gestin.UI.Custom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestin.LocalFiles
{
    internal class LocalSecurity
    {
        readonly string? directoryPath = LocalDirectory.appDataDirectoryPath();
        readonly string filePath = LocalDirectory.userCredentialsFilePath();

        #region LazySingleton
        private static readonly Lazy<LocalSecurity> lazy = new(() => new LocalSecurity());
        public static LocalSecurity Instance { get { return lazy.Value; } }
        public LocalSecurity() { }
        #endregion

        public bool createUserCredentials(string userType, string email)
        {
            if (Directory.Exists(directoryPath) && !File.Exists(filePath)) { createUserCredentialsFile(); }

            string token = securityController.getInstance().generateSessionToken();
            string dateTime = DateTime.Now.ToString();
            string userData = $"{token}\n{userType}\n{dateTime}";

            bool writeStatus = writeUserDataToFileCredentials(filePath, userData);
            bool tokenStatus = sessionController.getInstance().sessionTokenManager(token, email);

            return writeStatus && tokenStatus;
        }

        private void createUserCredentialsFile()
        {
            try
            {
                using FileStream fs = File.Create(filePath);
                fs.Close();
            }
            catch (DirectoryNotFoundException e) { new MessageBoxDarkMode(e.Message, "Directorio no existe", "Ok", Properties.Resources.BigErrorIcon); }

            catch (UnauthorizedAccessException e) { new MessageBoxDarkMode(e.Message, "Permiso denegado (Windows)", "Ok", Properties.Resources.BigErrorIcon); }
        }

        private bool writeUserDataToFileCredentials(string filePath, string userData)
        {
            bool status = false;
            try
            {
                using (FileStream fs = File.Create(filePath))
                {
                    byte[] userDataBytes = Encoding.UTF8.GetBytes(userData);
                    fs.Write(userDataBytes, 0, userDataBytes.Length);
                    status = true;
                }
            }
            catch (Exception) { throw; }
            return status;
        }

        public List<string> readUserCredentials()
        {
            List<string> userData = new();
            try
            {
                using (FileStream fs = File.OpenRead(filePath))
                {
                    using (StreamReader rdr = new StreamReader(fs, Encoding.Default))
                    {
                        string? line;

                        while ((line = rdr.ReadLine()) != null)
                        {
                            userData.Add(line);
                        }
                    }
                }
            }
            catch (ArgumentOutOfRangeException ex) { MessageBox.Show("Borrar UserCredentials.txt en AppData/Roaming/Gestin " + ex); }
            return userData;
        }

        public bool deleteUserCredentialsFile()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
            }
            catch (DirectoryNotFoundException e) { new MessageBoxDarkMode(e.Message, "Directorio no existe", "Ok", Properties.Resources.BigErrorIcon); }

            catch (FileNotFoundException e) { new MessageBoxDarkMode(e.Message, "Archivo no existe", "Ok", Properties.Resources.BigErrorIcon); }

            catch (UnauthorizedAccessException e) { new MessageBoxDarkMode(e.Message, "Permiso denegado (Windows)", "Ok", Properties.Resources.BigErrorIcon); }

            return !File.Exists(filePath);
        }
    }
}
