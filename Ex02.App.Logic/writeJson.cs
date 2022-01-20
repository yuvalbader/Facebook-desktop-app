using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Ex02.App.Logic
{
    public class writeJson : IWriteToDBStrategy
    {
        public void WriteStatisticToDataBase(string i_ToWrite)
        {
            string DirectoryPath;
            string filePath;

            // Append new lines of text to the file
            DirectoryPath = System.IO.Directory.GetCurrentDirectory();
            filePath = Path.Combine(DirectoryPath, "WellBeignAppUse.json");
            string json = JsonConvert.SerializeObject(i_ToWrite, Formatting.Indented);
           
            File.WriteAllText(filePath, json);
           
        }

    }
}
