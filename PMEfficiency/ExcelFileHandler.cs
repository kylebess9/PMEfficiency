using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace PMEfficiency
{
    //The excel file handler class is responsible for handling excel file operations like openning, closing, and reading
    public class ExcelFileHandler
    {
        //The necessary excel application objects
        Excel.Application xlApp;
        Excel.Workbook wb;
        Excel.Worksheet ws;
        //The range is how you access individual cells of the spreadsheet
        Excel.Range range;

        //this is the file path that the excel file is located at
        string path;
        //The headermap holds a string key that denotes the comparator key ('endDate', 'startDate', etc) and the column spot via an int value
        public Dictionary<string, int> headerMap;

        //The constructor just requires the file path and it loads the file
        public ExcelFileHandler(string path)
        {
            xlApp = new Excel.Application();
            this.path = path;
            wb = xlApp.Workbooks.Open(path);
            ws = wb.Worksheets[1];
            range = ws.UsedRange;
            headerMap = grabHeaders();
        }

        //Best practice is to close the file when not used to free up memory
        public void closeFile()
        {
            xlApp.Workbooks.Close();
        }

        //Just used to debug. Leaving for now
        //TODO: Remove eventually
        public void printWorkSheet()
        {
            String test = range.Cells[2, 1].Value2;
            Console.WriteLine(range.ToString());
        }
        //This function looks for key terms in the header and returns the applicable columns
        public Dictionary<string, int> grabHeaders()
        {
            //The return varible
            Dictionary<string, int> returnApplicableHeaders = new Dictionary<string, int>();
            //The header variable holds the value pulled from the spreadsheet cell
            string header = "";
            int columnIterator = 1;
            //While loop moves through each column
            do
            {
                //If the cell is not empty, if not break the loop
                if (range.Cells[1, columnIterator].Value != null)
                {
                    //Pull the cell value into the header variable and force it lowercase
                    header = range.Cells[1, columnIterator].Value.ToString();
                    header = header.ToLower();
                }
                else
                    break;

                //if the header cell contains any of the following words, add the key based on the header contents and mark the column position via the iterator
                if (header.Contains("start") || header.Contains("begin"))
                {
                    returnApplicableHeaders.Add("startDate", columnIterator);
                }
                else if (header.Contains("end") || header.Contains("finish"))
                {
                    returnApplicableHeaders.Add("endDate", columnIterator);
                }

                columnIterator++;
            }
            while (header != string.Empty);
            return returnApplicableHeaders;
        }
    }
}
