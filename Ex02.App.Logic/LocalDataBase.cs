using System;
using System.Collections.Generic;
using System.IO;


namespace Ex02.App.Logic
{
    public class LocalDataBase:IDataBaseStrategy
    {
        
        void IDataBaseStrategy.WriteStatisticToDataBase(string i_ToWrite)
        {
            string DirectoryPath;
            string filePath;

         
            // Append new lines of text to the file
            DirectoryPath = System.IO.Directory.GetCurrentDirectory();
            filePath = Path.Combine(DirectoryPath, "WellBeignAppUse.txt");

            if (!File.Exists(filePath))
            {
                using (StreamWriter outputFile = new StreamWriter(filePath))
                    outputFile.WriteLine(i_ToWrite);
            }
            else
            {
                using (StreamWriter outputFile = File.AppendText(filePath))
                {
                    outputFile.WriteLine(i_ToWrite);
                }
            }
        }

        object IDataBaseStrategy.GetStatisticFromDataBase()
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
