using System.Configuration;

namespace Gestin.Controllers
{
    internal class ImageSelectionController
    {
        #region Singleton
        private static ImageSelectionController settingController;

        private ImageSelectionController() { }
        public static ImageSelectionController getInstance() 
        {
            if (settingController == null)
            {
                settingController = new ImageSelectionController();
            }
            return settingController; 
        }
        #endregion

        #region ImageSelectionController

        /// <summary>
        /// Seteo una ruta de imagen en la configuracion
        /// </summary>
        public void SaveSelectedImagePathToConfig(string selectedImagePath)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // Verifica si selectedImagePath no es nulo o vacío antes de actualizar la configuración
            if (!string.IsNullOrEmpty(selectedImagePath))
            {
                // Verifica si la clave "SelectedImagePath" existe en la sección appSettings
                if (config.AppSettings.Settings["SelectedImagePath"] != null)
                {
                    if (selectedImagePath.Length > 0)
                    {
                        config.AppSettings.Settings["SelectedImagePath"].Value = selectedImagePath;
                        config.Save(ConfigurationSaveMode.Modified);
                        ConfigurationManager.RefreshSection("appSettings");
                    }
                }
                else
                {
                    // La clave no existe, agrégala
                    config.AppSettings.Settings.Add("SelectedImagePath", selectedImagePath);
                }
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }

        }

        /// <summary>
        /// Devuelvo la ruta de la imagen 
        /// </summary>
        public string ReadSelectedImagePathFromConfig()
        {
            return ConfigurationManager.AppSettings["SelectedImagePath"];
        }

        #endregion
    }
}
