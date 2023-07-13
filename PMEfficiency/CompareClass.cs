using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace PMEfficiency
{
    public static class CompareClass
    {
        public static ExcelFileHandler sharePointSheet;
        public static List<ProjectHolder> projectObjects = new List<ProjectHolder>();
        public static void openSharePointSheet(string path)
        {
            sharePointSheet = new ExcelFileHandler(path);
        }

        public static void setProjectObjects(ExcelFileHandler sheet)
        {
            bool flag = true;
            int iterator = 2;
            Excel.Range range = sheet.getRange();
            while (flag)
            {
                ProjectHolder addObj = new ProjectHolder();
                Dictionary<string, int> headers = sheet.headerMap;
                
                foreach (string key in headers.Keys)
                {

                    if (range.Cells[iterator, headers[key]].Value == null)
                    {
                        flag = false;
                        break;
                    }

                    if (key == "start")
                    {
                        addObj.projectStart = range.Cells[iterator, headers[key]].Value;
                    }
                    else if (key == "end")
                    {
                        addObj.projectFinish = range.Cells[iterator, headers[key]].Value;
                    }
                    if (flag)
                    {
                        projectObjects.Add(addObj);
                    }
                }
                iterator++;
            }
        }
    }
}
