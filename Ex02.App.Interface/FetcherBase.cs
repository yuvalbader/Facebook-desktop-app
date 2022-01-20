using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ex02.App.Logic;

namespace Ex02.App.Interface
{
    abstract class FetcherBase
    {
        public void Fetch(ListBox i_ToInsert, LoggedUesr i_LoggedUesr)
        {
            i_ToInsert.Invoke(new Action((() =>
                                                 {
                                                     List<string> listToInsert = getList(i_LoggedUesr);
                                                     i_ToInsert.DataSource = listToInsert;
                                                 })));
                                                
        }

        protected abstract List<string> getList(LoggedUesr i_LoggedUesr);
    }
}
