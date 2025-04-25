using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestin.Reports.Interfaces
{
    public interface IHeader
    {
        /// <summary>
        /// INTERFACE: Adds headers to excel worksheet
        /// </summary>
        /// <param name="worksheet"></param>
        public void AddHeader(ExcelWorksheet worksheet);
    }
}
