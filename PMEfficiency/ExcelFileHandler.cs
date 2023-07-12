using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace PMEfficiency
{
    internal class ExcelFileHandler
    {
        List<ProjectHolder> projectObjects;
        Excel.Application xlApp;
        Excel.Workbook wb;
        Excel.Worksheet ws;
        Excel.Range range;
        string path;
        Dictionary<string, int> headerMap;
        public ExcelFileHandler(string path)
        {
            xlApp = new Excel.Application();
            this.path = path;

        }

        public void LoadFile()
        {

            wb = xlApp.Workbooks.Open(path);

            ws = wb.Worksheets[1];
            range = ws.UsedRange;
            projectObjects = new List<ProjectHolder>();
            headerMap = grabHeaders();

        }

        public void closeFile()
        {
            xlApp.Workbooks.Close();
        }

        public void printWorkSheet()
        {
            String test = range.Cells[2, 1].Value2;
            Console.WriteLine(range.ToString());
        }

        public Dictionary<string, int> grabHeaders()
        {
            Dictionary<string, int> returnApplicableHeaders = new Dictionary<string, int>();
            string header = "";
            int iterator = 1;
            do
            {
                if (range.Cells[1, iterator].Value != null)
                {
                    header = range.Cells[1, iterator].Value.ToString();
                    header = header.ToLower();
                }
                else
                    break;


                if (header.Contains("start") || header.Contains("begin"))
                {
                    returnApplicableHeaders.Add("start", iterator);
                }
                else if (header.Contains("end") || header.Contains("finish"))
                {
                    returnApplicableHeaders.Add("end", iterator);
                }

                iterator++;
            }
            while (header != string.Empty);
            return returnApplicableHeaders;
        }

        public void processSpreadSheet(Dictionary<string, int> headers)
        {
            bool flag = true;
            int iterator = 2;
            while (flag)
            {
                ProjectHolder addObj = new ProjectHolder();
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
