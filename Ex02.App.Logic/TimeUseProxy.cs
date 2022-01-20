using System;

namespace Ex02.App.Logic
{
    public class TimeUseProxy : ITimeUseApp
    {
        private TimeUseApp m_RealDatabase;

        private readonly DateTime r_StartTimeAppUse;

         public TimeUseProxy()
        {
            m_RealDatabase = null;
            r_StartTimeAppUse = DateTime.Now;
        }

        public object GetStatisticFromFile()
        {
            if(m_RealDatabase == null)
              {
               m_RealDatabase = new TimeUseApp(r_StartTimeAppUse);
              }

            return m_RealDatabase.GetStatisticFromFile();
        }

        public void WriteStatisticToFile()
        {
              if(m_RealDatabase == null)
              {
               m_RealDatabase = new TimeUseApp(r_StartTimeAppUse);
              }

            m_RealDatabase.WriteStatisticToFile();
        }
    }
}
