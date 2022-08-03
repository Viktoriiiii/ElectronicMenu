using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace ElectronMenu.Forms
{
    class ClassTotal
    {
        public static Excel.Application excelApp;	//Сервер Excel
        public static Excel.Workbook excelBook;	//Отдельная книга
        public static Excel.Worksheet excelSheet;	//Один лист
        public static Excel.Range excelCells;	//Ячейки
    }
}
