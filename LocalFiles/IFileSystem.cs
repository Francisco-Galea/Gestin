using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestin.LocalFiles
{
    internal interface IFileSystem
    {
        bool editFileSection(string sectionToUpdate, string[] dataLines);
        List<string> readFileDataBySection(string section);
        void deleteByFileSection(string sectionToUpdate);
    }
}
