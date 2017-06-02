using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infragistics.Windows.DataPresenter;
using System.Windows.Controls;
using System.Windows.Data;

namespace ManageStudent.Utils
{
    public class Service
    {
       public DataGrid  InitDataGrid(String colNames, DataGrid dgr)
        {
            char[] delimiterChars = { '|' };
            String[] m_List = colNames.Split(delimiterChars);
            foreach (var colName in m_List)
            {
                DataGridTextColumn textColumn = new DataGridTextColumn();
                textColumn.Header = colName;
                textColumn.Binding = new Binding(colName);
                dgr.Columns.Add(textColumn);
            }
            return dgr;
         }
    }
}
