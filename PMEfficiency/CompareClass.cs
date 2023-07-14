using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace PMEfficiency
{
    //The compare class holds the ExcelFileHandlers and handle logic comparing data between data sheets
    public static class CompareClass
    {
        public static ExcelFileHandler sharePointSheet;
        public static List<ProjectHolder> projectObjects = new List<ProjectHolder>();
        //We need to hard code the sharepoint sheet since it's data will be the one used to compare to all other sheets
        public static void openSharePointSheet(string path)
        {
            sharePointSheet = new ExcelFileHandler(path);
        }

        
    }
}
