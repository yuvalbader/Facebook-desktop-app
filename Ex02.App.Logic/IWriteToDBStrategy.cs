﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02.App.Logic
{
    public interface IWriteToDBStrategy
    {
         void WriteStatisticToDataBase(string i_ToWrite);
       
    }
}
