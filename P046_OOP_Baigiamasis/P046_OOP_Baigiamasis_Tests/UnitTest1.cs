using P046_OOP_Baigiamasis;
using P046_OOP_Baigiamasis.Models;
using P046_OOP_Baigiamasis.Interfaces;
using P046_OOP_Baigiamasis.Services;

namespace P046_OOP_Baigiamasis_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TxtLogFileDataReading()
        {
            LogFile logFile = new TxtLogFile(); 
            Assert.AreNotEqual(0, logFile.GetLogs().Count);

        }

        [TestMethod]
        public void CsvLogFileDataReading()
        {
            LogFile logFile = new CsvLogFile();
            Assert.AreNotEqual(0, logFile.GetLogs().Count);

        }

        [TestMethod]
        public void HTMLLogFileDataReading()
        {
            LogFile logFile = new HtmlLogFile();
            Assert.AreNotEqual(0, logFile.GetLogs().Count);

        }

        [TestMethod]
        public void HTMLLogFileDataSave()
        {
            
            LogFile logFile = new HtmlLogFile();

            logFile.ResetLog();
            logFile.AddToLog(new LogItem { Date = DateTime.Parse("2022-01-01"), Move = 1, Disk1=1, Disk2=1, Disk3=1, Disk4 = 1 });

            logFile.SaveData();

            var temp = logFile.ReadFileLines();

            string actual = String.Join(string.Empty, temp);
            string expected = "<table border><tr><th>ŽAIDIMO PRADŽIOS DATA</td><th>ĖJIMO NR</td><th>DISKO 1 VIETA</td><th>DISKO 2 VIETA</td><th>DISKO 3 VIETA</td><th>DISKO 4 VIETA</td></tr><tr><td>2022-01-01 00:00</td><td>1</td><td>1</td><td>1</td><td>1</td><td>1</td></tr></table>";

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void CsvLogFileDataSave()
        {

            LogFile logFile = new CsvLogFile();

            logFile.ResetLog();
            logFile.AddToLog(new LogItem { Date = DateTime.Parse("2022-01-01"), Move = 1, Disk1 = 1, Disk2 = 1, Disk3 = 1, Disk4 = 1 });

            logFile.SaveData();

            var temp = logFile.ReadFileLines();

            string actual = String.Join(string.Empty, temp);
            string expected = "zaidimo_pradzios_data, ejimo_nr, disko_1_vieta, disko_2_vieta, disko_3_vieta, disko_4_vieta2022-01-01 00:00,1,1,1,1,1";

            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        public void TxtLogFileDataSave()
        {

            LogFile logFile = new TxtLogFile();

            logFile.ResetLog();
            logFile.AddToLog(new LogItem { Date = DateTime.Parse("2022-01-01"), Move = 1, Disk1 = 2, Disk2 = 1, Disk3 = 1, Disk4 = 1 });

            logFile.SaveData();

            var temp = logFile.ReadFileLines();

            string actual = String.Join(string.Empty, temp);
            string expected = "žaidime kuris pradėtas 2022-01-01 00:00, ėjimu nr 1 1 dalių diskas buvo paimtas iš pirmo sulpelio ir padėtas į antrą";

            Assert.AreEqual(expected, actual);

        }


    }
}