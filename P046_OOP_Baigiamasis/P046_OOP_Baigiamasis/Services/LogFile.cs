using P046_OOP_Baigiamasis.Interfaces;
using P046_OOP_Baigiamasis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P046_OOP_Baigiamasis.Services
{
    public abstract class LogFile : IFileLog
    {
        List<LogItem> _logItems = new List<LogItem>();

        readonly string _filePath;
        internal readonly string datePattern = "yyyy-MM-dd HH:mm";

        public LogFile(string filePath)
        {
            _filePath = filePath;
        }

        public virtual void AddToLog(LogItem logItem)
        {
            _logItems.Add(logItem);
        }

        public virtual void ResetLog()
        {
            _logItems.Clear();
        }

        public virtual List<LogItem> GetLogs()
        {
            return _logItems;
        }
        public void WriteFileData(string[] data) => File.WriteAllLines(_filePath, data);
        public string[]? ReadFileLines()
        {

            if (File.Exists(_filePath))
                return File.ReadAllLines(_filePath);
            else return null;
        }
        
        public abstract void ReadData();
        public abstract void SaveData();

    }
}
