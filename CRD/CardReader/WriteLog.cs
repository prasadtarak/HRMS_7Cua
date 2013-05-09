using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CardReader
{
    class WriteLog
    {
        public static void WriteTimeLog(string cardID, string workingDay, string checkIn)
        {
            // Compose a string that consists of three lines.
            string lines = workingDay + " - " + cardID + " - " + checkIn;

            //Lay ra ngay thang hien tai lam dau vao cho ten file log
            DateTime timeLog = DateTime.Now;
            //Hang ngay tu dong tao file log moi voi ten file theo dinh dang: 20110519_cardreader_log.txt
            string pathFile = "..\\" + timeLog.ToString("yyyyMMdd") + "_cardreader_log.txt";
            // Write the string to a file.
            System.IO.StreamWriter file = new System.IO.StreamWriter(pathFile, true);
            file.WriteLine(lines);

            file.Close();
        }
    }
}
