using System;
using System.Collections.Generic;
using System.IO;


namespace Ex02.App.Logic
{
    public class TextWrite: IWriteToDBStrategy
    {
        
        void IWriteToDBStrategy.WriteStatisticToDataBase(string i_ToWrite)
        {
            string DirectoryPath;
            string filePath;

            // Append new lines of text to the file
            DirectoryPath = System.IO.Directory.GetCurrentDirectory();
            filePath = Path.Combine(DirectoryPath, "WellBeignAppUse.txt");

            if (!File.Exists(filePath))
            {
                using (StreamWriter outputFile = new StreamWriter(filePath))
                {
                    outputFile.WriteLine(i_ToWrite);
                    outputFile.Close();
                }
            }
            else
            {
                using (StreamWriter outputFile = File.AppendText(filePath))
                {
                    outputFile.WriteLine(i_ToWrite);
                    outputFile.Close();
                }
            }
            
        }

    }
}


