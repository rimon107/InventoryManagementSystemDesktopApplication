using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Common.Library
{
    public class DataGridViewCommon
    {
        public DataGridViewCommon()
        {

        }

        public DataGridViewRow GetSelectedRow(DataGridView gv)
        {
            DataGridViewRow row;
            try
            {
                Int32 selectedRowCount = gv.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (selectedRowCount == 1)
                {
                    row = gv.SelectedRows[0];
                }
                else
                {
                    if (selectedRowCount > 1)
                    {
                        row = null;
                    }
                    else
                    {
                        try
                        {
                            var RowIndex = gv.SelectedCells[0].RowIndex;
                            row = gv.Rows[RowIndex];
                        }
                        catch
                        {
                            row = null;
                        }
                    }
                }


            }
            catch
            {


                row = null;

            }

            return row;
        }
    }
}
