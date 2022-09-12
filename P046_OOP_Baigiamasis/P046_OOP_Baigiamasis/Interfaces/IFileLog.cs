using P046_OOP_Baigiamasis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P046_OOP_Baigiamasis.Interfaces
{
    internal interface IFileLog
    {
        void AddToLog(LogItem logItem);
        List<LogItem> GetLogs();
    }
}
