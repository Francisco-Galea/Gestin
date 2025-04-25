using Gestin.UI.Custom;
using System.Globalization;
using System.Text;

namespace Gestin.LocalFiles
{
    public sealed class LocalGestinSettings : IFileSystem
    {
        public static CultureInfo LocalLanguage = CultureInfo.GetCultureInfo("es-ES");
        readonly string? directoryPath = LocalDirectory.appDataDirectoryPath();
        readonly string filePath = LocalDirectory.settingsFilePath();

        #region LazySingleton

        private static readonly Lazy<LocalGestinSettings> lazy = new Lazy<LocalGestinSettings>(() => new LocalGestinSettings());
        public static LocalGestinSettings Instance { get { return lazy.Value; } }
        public LocalGestinSettings() { }

        #endregion


        public bool checkFileSettignExists()
        {
            return File.Exists(filePath);
        }

        public static Dictionary<string, Dictionary<string, string>> getGeneralSettingsPreset()
        {
            Dictionary<string, Dictionary<string, string>> defaultIniData = new();

            defaultIniData["ConnectionString"] = new Dictionary<string, string>
            {
                {"Connection", ""}
            };

            defaultIniData["SavedLogin"] = new Dictionary<string, string>
            {
                {"Email", ""},
                {"UserType", ""}
            };

            return defaultIniData;
        }

        public void createSettingsFilePreset()
        {
            try
            {
                if (Directory.Exists(directoryPath) && !File.Exists(filePath))
                {
                    using FileStream fs = File.Create(filePath);

                    fs.Close();

                    createIniFileSettingSections(filePath);
                }
            }
            catch (DirectoryNotFoundException e) { new MessageBoxDarkMode(e.Message, "Directorio no existe", "Ok", Properties.Resources.BigErrorIcon); }

            catch (UnauthorizedAccessException e) { new MessageBoxDarkMode(e.Message, "Permiso denegado (Windows)", "Ok", Properties.Resources.BigErrorIcon); }
        }

        private void createIniFileSettingSections(string filePath)
        {
            Dictionary<string, Dictionary<string, string>> defaultIniData = getGeneralSettingsPreset();

            List<string> lines = new();

            foreach (var section in defaultIniData)
            {
                lines.Add('[' + section.Key + ']');
                foreach (var pair in section.Value)
                {
                    lines.Add(pair.Key + ':' + pair.Value);
                }
                lines.Add("");
            }
            File.WriteAllLines(filePath, lines);
        }

        public bool editFileSection(string sectionToUpdate, string[] inputData)
        {
            Dictionary<string, Dictionary<string, string>> iniData = getGeneralSettingsPreset();
            Dictionary<string, string> sectionSelected = iniData[sectionToUpdate];
            
            int index = 0;
            try
            {
                //if (iniData.ContainsKey(section))
                foreach (string key in sectionSelected.Keys)
                {
                    string value = inputData[index].Trim();
                    iniData[sectionToUpdate][key] = value;
                    index++;
                }
                
                return writeIniFile(filePath, sectionToUpdate, sectionSelected);
            }
            catch (FileNotFoundException) { throw; }
        }

        private bool writeIniFile(string filePath, string sectionToUpdate, Dictionary<string, string> updatedKeys)
        {
            List<string> existingLines = new();
            if (File.Exists(filePath))
            {
                existingLines = File.ReadAllLines(filePath).ToList();
            }

            bool sectionFound = false;
            for (int i = 0; i < existingLines.Count; i++)
            {
                if (existingLines[i].StartsWith('[' + sectionToUpdate + ']'))
                {
                    sectionFound = true;

                    foreach (var pair in updatedKeys)
                    {
                        string keyValuePair = pair.Key + ':' + pair.Value;
                        int index = existingLines.FindIndex(line => line.StartsWith(pair.Key + ':'));
                        if (index != -1)
                        {
                            existingLines[index] = keyValuePair;
                        }
                        else
                        {
                            existingLines.Insert(i + 1, keyValuePair);
                            i++;
                        }
                    }
                    break;
                }
            }
            if (!sectionFound)
            {
                existingLines.Add('[' + sectionToUpdate + ']');
                foreach (var pair in updatedKeys)
                {
                    existingLines.Add(pair.Key + ':' + pair.Value);
                }
                existingLines.Add("");
            }

            if(existingLines.Count > 0) { File.WriteAllLines(filePath, existingLines); return true; }
            else { return false; }
        }


        public List<string> readFileDataBySection(string section)
        {
            try
            {
                List<string> sectionData = new();
                bool insideSection = false;

                foreach (string line in File.ReadLines(filePath))
                {
                    if(!string.IsNullOrWhiteSpace(line))
                    {
                        if (line.Trim() == $"[{section}]")
                        {
                            insideSection = true;
                            continue;
                        }
                        else if (insideSection && line.StartsWith('['))
                        {
                            break;
                        }
                        else if (insideSection)
                        {
                            string[] parts = line.Split(':', 2); // part 1 is Key, part 2 is Value

                            if (parts.Length >= 2 && !string.IsNullOrWhiteSpace(parts[1]))
                            {
                                sectionData.Add(parts[1].Trim());
                            }
                        }
                    }
                }

                if(sectionData.Count == 0) { sectionData.Add(""); }

                return sectionData;
            }
            catch (ArgumentOutOfRangeException) { throw; }
            catch (FileNotFoundException) { throw; }
        }

        public void deleteByFileSection(string section)
        {
            try
            {
                bool insideSection = false;
                List<string> newLines = new();

                foreach (string line in File.ReadLines(filePath))
                {
                    if (line.Trim() == $"[{section}]")
                    {
                        insideSection = true;
                        continue;
                    }
                    else if (insideSection && line.StartsWith('['))
                    {
                        insideSection = false;
                    }

                    if (!insideSection)
                    {
                        newLines.Add(line);
                    }
                }
                File.WriteAllLines(filePath, newLines);
            }
            catch (FileNotFoundException) { throw; }
        }

        public bool deleteSettingsFile()
        {
            try
            {
                if (Directory.Exists(directoryPath) && File.Exists(filePath))
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
