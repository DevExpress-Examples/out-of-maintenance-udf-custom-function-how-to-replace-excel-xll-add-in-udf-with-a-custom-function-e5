using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDF_Discount
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            #region #AddFunction
            DiscountFunction udfFunction = new DiscountFunction();
            if (!spreadsheetControl1.Document.CustomFunctions.Contains(udfFunction.Name))
                spreadsheetControl1.Document.CustomFunctions.Add(udfFunction);
            #endregion #AddFunction

            spreadsheetControl1.DocumentLoaded+=spreadsheetControl1_DocumentLoaded;
            spreadsheetControl1.LoadDocument("Discount.xlsx");
            
        }

        private void spreadsheetControl1_DocumentLoaded(object sender, EventArgs e)
        {
            #region #GetExistingCells
            IEnumerable<DevExpress.Spreadsheet.Cell> existingCells = spreadsheetControl1.ActiveWorksheet.GetExistingCells();
            spreadsheetControl1.Document.BeginUpdate();
            foreach (DevExpress.Spreadsheet.Cell cell in existingCells)
            {
                if (cell.HasFormula)
                    // The worksheet references functions from the DiscountXLL.MyFunctions xll Add-in. 
                    // The name prefix is removed leaving only the function name.
                    cell.Formula = cell.Formula.Replace("_xll.DiscountXLL.MyFunctions.", string.Empty);
            }
            spreadsheetControl1.Document.EndUpdate();
            #endregion #GetExistingCells 
            spreadsheetControl1.ActiveWorksheet.ScrollToRow(0);           
        }
    }
}
