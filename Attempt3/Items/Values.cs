using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace Attempt3
{
    class Values
    {
        private static string thePathToTheFolder;

        public string ThePathToTheFolder
        {
            get { return thePathToTheFolder; }

            set
            {
                if (value != null)
                {
                    thePathToTheFolder = value;
                }
                else
                {
                    Console.WriteLine("Error! File is empty");
                }
            }
        }

        public string[,] list = new string[30, 30];

        
    }

    class DataFromExcel
    {
       

        public static void DataExcel()
        {
            Values aaaa = new Values();


            Values thePathToTheFolder = new Values();

            Excel.Application ObjWorkExcel = new Excel.Application(); //открыть эксель
            Excel.Workbook ObjWorkBook = ObjWorkExcel.Workbooks.Open(@thePathToTheFolder.ThePathToTheFolder, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing); //открыть файл
            Excel.Worksheet ObjWorkSheet = (Excel.Worksheet)ObjWorkBook.Sheets[1]; //получить 1 лист
            var lastCell = ObjWorkSheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell);//1 ячейку
            string[,] list = new string[lastCell.Column, lastCell.Row]; // массив значений с листа равен по размеру листу
            for (int i = 0; i < 9; i++) //по всем колонкам
                for (int j = 0; j < 19; j++) // по всем строкам
                    list[i, j] = ObjWorkSheet.Cells[j + 1, i + 1].Text.ToString();//считываем текст в строку
            ObjWorkBook.Close(false, Type.Missing, Type.Missing); //закрыть не сохраняя
            ObjWorkExcel.Quit(); // выйти из экселя
            GC.Collect(); // убрать за собой
            for (int i = 1; i < 9; i++) //по всем колонкам
                for (int j = 1; j < 19; j++) // по всем строкам 
                {
                    aaaa.list[i, j] = list[i, j];
                   // Console.Write(list[i, j]);//выводим строку
                }
            Console.ReadLine();
        }
    }
}
  
