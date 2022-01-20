using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex02.App.Interface
{
    internal class Observer
    {
        internal Dictionary<string, int> activityStatistics = new Dictionary<string, int>();

        internal void WriteActivityToFile(object i_Sender, EventArgs i_)
        {
            string DirectoryPath = System.IO.Directory.GetCurrentDirectory();
            string filePath = Path.Combine(DirectoryPath, "ActivityFile.txt");
            string buttomName = (i_Sender as Button).Name;
            string outText = string.Format("button \"{0}\" clicked at {1}", buttomName, DateTime.Now);

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

            int currentCount;

            if (activityStatistics.TryGetValue(buttomName, out currentCount))
            {
                activityStatistics[buttomName] = currentCount + 1;
            }
            else
            {
                activityStatistics[buttomName] = 1;
            }
        }
    }
}
