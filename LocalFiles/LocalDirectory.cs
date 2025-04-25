using DocumentFormat.OpenXml.Presentation;
using Gestin.UI.Custom;

namespace Gestin.LocalFiles
{
    public class LocalDirectory
    {
        public static void requiredDependencies()
        {
            createAppDataDirectory();
            LocalGestinSettings.Instance.createSettingsFilePreset();
            deleteOldFiles();
        }

        private static void createAppDataDirectory()
        {
            string? directoryPath = appDataDirectoryPath();

            try
            {
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);

                    if (!Directory.Exists(directoryPath)) { throw new DirectoryNotFoundException(); }
                }
            }
            catch (DirectoryNotFoundException) { new MessageBoxDarkMode("Atención, no se pudo crear el directorio", "Error creando directorio", "Ok", Properties.Resources.BigErrorIcon); }
            
            catch (UnauthorizedAccessException e) { new MessageBoxDarkMode(e.Message, "Permiso denegado (Windows)", "Ok", Properties.Resources.BigErrorIcon); }
        }

        //---------------------------------------------

        public static string appDataDirectoryPath()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Gestin");
        }

        public static string userCredentialsFilePath()
        {
            return Path.Combine(appDataDirectoryPath(), "UserCredentials.ini");
        }

        public static string settingsFilePath()
        {
            return Path.Combine(appDataDirectoryPath(), "Settings.ini");
        }

        private static void deleteOldFiles()
        {
            if (Directory.Exists(appDataDirectoryPath()))
            {
                string[] txtFiles = Directory.GetFiles(appDataDirectoryPath(), "*.txt");

                if(txtFiles.Length > 0)
                {
                    foreach (string txtFile in txtFiles)
                    {
                        try { File.Delete(txtFile); }
                        catch (Exception) { throw; }
                    }
                }
            }
        }
    }
}
