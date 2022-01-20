using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace Ex02.App.Logic
{
    public class XMLWrite : IWriteToDBStrategy
    {

        void IWriteToDBStrategy.WriteStatisticToDataBase(string i_ToWrite)
        {
            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(string));

            string DirectoryPath = System.IO.Directory.GetCurrentDirectory();
            string path = Path.Combine(DirectoryPath, "WellBeignAppUse.xml");
            System.IO.FileStream file = System.IO.File.Create(path);

            writer.Serialize(file, i_ToWrite);
            file.Close();

        }


    }
}
