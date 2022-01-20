using System;
using System.Collections.Generic;
using System.IO;

namespace Ex02.App.Logic
{
    public class TimeUseApp 
    {
        private DateTime m_StartTimeAppUse;

        private DateTime m_EndTimeAppUse;

        public IDataBaseStrategy m_DataBase { get; set; }

        public TimeUseApp(IDataBaseStrategy i_DataBase)
        {
            m_StartTimeAppUse = DateTime.Now;
            m_DataBase = i_DataBase;

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
        private string CalcTimeUse()
        {
            m_EndTimeAppUse = DateTime.Now;
            string data;
            string timeUseText;
    
            data = DateTime.Now.DayOfWeek.ToString() + ' ' + DateTime.UtcNow.Date.ToString("dd/MM/yyyy");
            timeUseText = string.Format("{0},{1},{2},{3},{4}", data, Days, Hours, Minutes, Seconds);

            return timeUseText;
        }


        public void WriteStatisticToDataBase()
        {
            m_DataBase.WriteStatisticToDataBase(CalcTimeUse());
        }

        public object GetStatisticFromDataBase()
        {
            return m_DataBase.GetStatisticFromDataBase();
        }
    }
}
