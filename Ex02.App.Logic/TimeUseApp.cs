using System;
using System.Collections.Generic;
using System.IO;

namespace Ex02.App.Logic
{
    public class TimeUseApp : ITimeUseApp
    {
        private DateTime m_StartTimeAppUse;

        private DateTime m_EndTimeAppUse;

        public TimeUseApp(DateTime i_StartTimeAppUse)
        {
            m_StartTimeAppUse = DateTime.Now;
        }

        internal DateTime StartTime { get; set; }

        internal DateTime EndTime { get; set; }

        internal TimeSpan TotelTimeAppUse => m_EndTimeAppUse - m_StartTimeAppUse;

        internal string Days => string.Format("{0:%d}", TotelTimeAppUse);

        internal string Hours => string.Format("{0:%h}", TotelTimeAppUse);

        internal string Minutes => string.Format("{0:%m}", TotelTimeAppUse);

        internal string Seconds => string.Format("{0:%s}", TotelTimeAppUse);

        internal Dictionary<string, string> DicitionaryDate()
        {
            m_EndTimeAppUse = DateTime.Now;
            var totleUseToDay = new Dictionary<string, string>();

            totleUseToDay.Add("DayInTheWeek", DateTime.Now.Day.ToString());
            totleUseToDay.Add("Date", DateTime.UtcNow.Date.ToString("dd/MM/yyyy"));
            totleUseToDay.Add("Days", Days);
            totleUseToDay.Add("Hours", Hours);
            totleUseToDay.Add("Minutes", Minutes);
            totleUseToDay.Add("Seconds", Seconds);

            return totleUseToDay;
        }

        public void WriteStatisticToFile()
        {
            m_EndTimeAppUse = DateTime.Now;
            string data;
            string outText;
            string DirectoryPath;
            string filePath;

                data = DateTime.Now.DayOfWeek.ToString() + ' ' + DateTime.UtcNow.Date.ToString("dd/MM/yyyy");
                outText = string.Format("{0},{1},{2},{3},{4}", data, Days, Hours, Minutes, Seconds);

                // Append new lines of text to the file
                DirectoryPath = System.IO.Directory.GetCurrentDirectory();
                filePath = Path.Combine(DirectoryPath, "WellBeignAppUse.txt");

                if (!File.Exists(filePath))
                {
                    using (StreamWriter outputFile = new StreamWriter(filePath))
                    outputFile.WriteLine(outText);
                }
                else
                {
                    using (StreamWriter outputFile = File.AppendText(filePath))
                    {
                        outputFile.WriteLine(outText);
                    }
                }
        }

        public object GetStatisticFromFile()
        {
            string filePath = System.IO.Directory.GetCurrentDirectory();
            List<string> data = new List<string>();
            string line;

            System.IO.StreamReader file = new System.IO.StreamReader("WellBeignAppUse.txt");
            while ((line = file.ReadLine()) != null)
            {
              data.Add(line);
            }
            
            return data;
        }
    }
}
