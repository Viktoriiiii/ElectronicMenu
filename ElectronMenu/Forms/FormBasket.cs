using ElectronMenu.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ElectronMenu.Classes;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;	

namespace ElectronMenu
{
    public partial class FormBasket : Form
    {
        List <Order> listOrder;
        Customer cs;
        public double priceOrder = 0;
        double discount = 0;
        string formPay = "Наличный";
        DateTime dt;

        public FormBasket(List<Order> listOrder, Customer cs)
        {
            InitializeComponent();
            this.listOrder = listOrder;
            this.cs = cs;
        }

        private void buttonReturnToMenu_Click(object sender, EventArgs e)
        {
            Application.OpenForms["FormBasket"].Close();
            Application.OpenForms["FormMenu"].Show();
        }

        private void FormBasket_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !(MessageBox.Show("Закрыть данную страницу?", "Закрытие", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            == DialogResult.Yes);
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            //Изменение значения в кошельке
            FormMenu.summaWallet -= priceOrder;
            cs.setWallet(cs.getWallet() - priceOrder);

            MessageBox.Show("Спасибо, Вы полностью оплатили Ваш заказ на сумму " + priceOrder + " рублей\r\n" +
                 "Мы вернули Вам на карту " + discount + " рублей.\r\n" +
                 "У Вас на карте осталось " + cs.getWallet() + " рублей.\r\n" +
                 "Вы можете снова совершить заказ");
            //this.Close();
            Application.OpenForms["FormBasket"].Close();
            //  Application.OpenForms["FormMenu"].Close();
            FormMenu main = this.Owner as FormMenu;
            if (main != null)
            {
                main.buttonClear_Click();
            }
            printExcel();
            printDoc();

            Application.OpenForms["FormMenu"].Show();   //Перейти к меню
        }

        private void FormBasket_Load(object sender, EventArgs e)
        {
            int index = 0;
            foreach (var item in listOrder)	//По всем элементам списка
            {
                this.dataGridViewOrder.Rows.Add();  //Добавить новую строку к таблице
                this.dataGridViewOrder.Rows[index].Cells[0].Value = index + 1;
                this.dataGridViewOrder.Rows[index].Cells[1].Value = item.Category;
              //  MessageBox.Show(item.Category.ToString());
                this.dataGridViewOrder.Rows[index].Cells[2].Value = item.Title;
                this.dataGridViewOrder.Rows[index].Cells[3].Value = item.Price;
                this.dataGridViewOrder.Rows[index].Cells[4].Value = item.Count;
                this.dataGridViewOrder.Rows[index].Cells[5].Value = item.Price * item.Count;
                index++;
            }
            priceOrder = FormMenu.summaOrder;
            textBoxSumOrder.Text = "Сумма за Ваш заказ: " + priceOrder.ToString();
        }

        private void radioButtonNal_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNal.Checked)
            {
                formPay = "Наличный";
                priceOrder = FormMenu.summaOrder;
            }
            if (radioButtonCard.Checked)
            {
                formPay = "По карте";
                discount = FormMenu.summaOrder * 0.1;
                priceOrder = FormMenu.summaOrder - discount;
            }
            textBoxSumOrder.Text = "Сумма за Ваш заказ: " + priceOrder.ToString();

        }
        private void printExcel()
        {
            Excel.Application excelAppLocal = new Excel.Application();   //Создать локальный объект Excel
            excelAppLocal.SheetsInNewWorkbook = 1;          //В новой книге будет один лист
            Excel.Workbook excelBookLocal = excelAppLocal.Workbooks.Add(Type.Missing);   //Добавить книгу
            excelAppLocal.DisplayAlerts = false;            //Не выдавать сообщений пользователю
                                                            //Обратиться к первому листу
            Excel.Worksheet excelSheetLocal = excelBookLocal.Worksheets[1];
            excelSheetLocal.Name = "Чек на заказ";          //Дать имя листу
            Excel.Range excelCellsLocal;             //Ячейки
            int currentRow = 1;                 //Номер текущей строки листа
            dt = DateTime.Now;
            excelCellsLocal = (Excel.Range)excelSheetLocal.Cells[1][currentRow];    //Ссылка на ячейку [A1]
            excelCellsLocal.Value2 = "Дата заказа: " + dt.ToLongDateString() +
             " Время заказа: " + dt.ToLongTimeString();




            //Оформление даты и времени
            excelCellsLocal = (Excel.Range)excelSheetLocal.get_Range("A1", "F1");
            excelCellsLocal.Merge(Type.Missing);
            excelCellsLocal.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            excelCellsLocal.Font.Size = 13;
            excelCellsLocal.Font.Italic = true;
            excelCellsLocal.Font.Bold = true;
            excelCellsLocal.Font.Color = Color.Red;
            excelCellsLocal.Borders.ColorIndex = 3;             //Устанавливаем цвет обводки
            currentRow++;                                       //Перейти к следующей строке
            
            //Перенести заголовки из таблицы на форме в ячейки Excel
            for (int j = 1; j <= 6; j++)					//В таблице шесть столбцов
            {
                excelSheetLocal.Cells[j][currentRow].Value2 = dataGridViewOrder.Columns[j - 1].HeaderText;
                excelCellsLocal = (Excel.Range)excelSheetLocal.Cells[j][currentRow];    //Ссылка на ячейку [A1]
                //Оформление заголовков таблиц
                excelCellsLocal.Merge(Type.Missing);
                excelCellsLocal.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                excelCellsLocal.Font.Size = 12;
                excelCellsLocal.Font.Bold = true;
                excelCellsLocal.Font.Color = Color.DarkBlue;
                excelCellsLocal.Borders.ColorIndex = 1;
                excelCellsLocal.Interior.ColorIndex = 34;
            }           

            for (int i = 0; i < dataGridViewOrder.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewOrder.ColumnCount; j++)
                {
                    excelSheetLocal.Cells[i + 3, j + 1] = dataGridViewOrder.Rows[i].Cells[j].Value;
                    excelCellsLocal = (Excel.Range)excelSheetLocal.Cells[j+1][currentRow+1];    //Ссылка на ячейку
                    excelCellsLocal.Merge(Type.Missing);
                    excelCellsLocal.Font.Bold = true;
                    excelCellsLocal.Font.Color = Color.DarkGreen;
                    excelCellsLocal.Borders.ColorIndex = 1;             //Устанавливаем цвет обводки
                }
                currentRow++;
            }

            for (int j = 2; j <= 7; j++)					
            {
                excelCellsLocal = (Excel.Range)excelSheetLocal.Cells[2][currentRow+j];    //Ссылка на ячейку 

                excelCellsLocal.Merge(Type.Missing);
                excelCellsLocal.Font.Size = 12;
                excelCellsLocal.Font.Bold = true;
                excelCellsLocal.Font.Color = Color.DarkViolet;

                excelCellsLocal = (Excel.Range)excelSheetLocal.Cells[3][currentRow + j];    //Ссылка на ячейку 
                excelCellsLocal.Merge(Type.Missing);
                excelCellsLocal.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
                excelCellsLocal.Font.Size = 12;
                excelCellsLocal.Font.Bold = true;
                excelCellsLocal.Font.Color = Color.DarkViolet;
            }

            excelSheetLocal.Cells[2][currentRow + 2].Value2 = "Количество наименований";
            excelSheetLocal.Cells[3][currentRow + 2].Value2 = dataGridViewOrder.RowCount.ToString();
            excelSheetLocal.Cells[2][currentRow + 3].Value2 = "Общая сумма";
            excelSheetLocal.Cells[3][currentRow + 3].Value2 = (discount+priceOrder).ToString();
            excelSheetLocal.Cells[2][currentRow + 4].Value2 = "Скидка";
            excelSheetLocal.Cells[3][currentRow + 4].Value2 = discount.ToString();
            excelSheetLocal.Cells[2][currentRow + 5].Value2 = "Итого";
            excelSheetLocal.Cells[3][currentRow + 5].Value2 = priceOrder.ToString();
            excelSheetLocal.Cells[2][currentRow + 6].Value2 = "Форма оплаты";
            excelSheetLocal.Cells[3][currentRow + 6].Value2 = formPay.ToString();
            excelSheetLocal.Cells[2][currentRow + 7].Value2 = "Сумма заказа прописью";
            excelSheetLocal.Cells[3][currentRow + 7].Value2 = priceOrder.ToString();

            //Ширина колонки
            excelCellsLocal = (Excel.Range)excelSheetLocal.get_Range("B1", "B" + currentRow);
            excelCellsLocal.ColumnWidth = 30;

            excelCellsLocal = (Excel.Range)excelSheetLocal.get_Range("C1", "C" + currentRow);
            excelCellsLocal.ColumnWidth = 20;

            excelCellsLocal = (Excel.Range)excelSheetLocal.get_Range("F1", "F" + currentRow);
            excelCellsLocal.ColumnWidth = 15;

            //Сохранить книгу в текущей папке проекта. Имя файла совпадает с текущей датой
            excelBookLocal.Saved = true;
            string path = Application.StartupPath;           //Путь к папке запущенного приложения
                                                            //Полный путь к документу
            string pathBook = path + @"\" +
            dt.Year + "_" + dt.Month + "_" + dt.Day + "_" +
            dt.Hour + "_" + dt.Minute + "_" + dt.Second + ".xls";
            excelBookLocal.SaveAs(pathBook, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
            Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            excelBookLocal.Close(true, null, null);
            excelAppLocal.Quit();           //Выйтииз Excel
                                            //Уничтожить COM-объекты
            System.Runtime.InteropServices.Marshal.FinalReleaseComObject(excelAppLocal);

        }

        private void printDoc()
        {
            //Необходимыевеличины
            Word.Application wordApp;        //Сервер Word
            Word.Document wordDoc;       //Документ Word
            Word.Paragraph wordPar;      //Абзац документа
            Word.Range wordRange;            //Тест абзаца
            Word.Table wordTable;            //Таблица
            Word.InlineShape wordShape;      //Рисунок
            string path = Application.StartupPath;

            dt = DateTime.Now;
            wordApp = new Word.Application();   //Сервер
            wordDoc = wordApp.Documents.Add();  //Добавить новый пустой документ
            wordDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientPortrait;    // Книжная ориентация
                                                                                    //Логотип в первый абзац
            wordPar = wordDoc.Paragraphs.Add();
            wordRange = wordPar.Range;
            wordShape = wordDoc.InlineShapes.AddPicture(path + @"\icon.png",
            Type.Missing, Type.Missing, wordRange);
            wordShape.Width = 100;          //Размерылоготипа
            wordShape.Height = 100;
            //Заголовок - дата и время в новый абзац
            wordPar = wordDoc.Paragraphs.Add();
            wordPar.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            wordPar.set_Style("Заголовок 1");
            wordRange = wordPar.Range;      //Текст абзаца
            wordRange.Text = "Дата заказа: " + dt.ToLongDateString() + "\t" + "Время заказа: " + dt.ToLongTimeString();
            //Таблица
            wordRange.InsertParagraphAfter();
            wordPar = wordDoc.Paragraphs.Add();
            wordRange = wordPar.Range;
            //Размер таблицы связан с таблицей заказа
            wordTable = wordDoc.Tables.Add(wordRange, dataGridViewOrder.RowCount + 1, 6);
            wordTable.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleDouble;
            wordTable.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleDouble;
            Word.Range cellRange;            //Ячейки таблицы
            for (int i = 1; i <= 6; i++)            //Заголовочные ячейки таблицы
            {
                cellRange = wordTable.Cell(1, i).Range;
                cellRange.Text = this.dataGridViewOrder.Columns[i - 1].HeaderText;
            }
            //Незаголовочные ячейки таблицы переносятся из сетки формы
            for (int row = 2; row <= dataGridViewOrder.RowCount + 1; row++)
            {
                for (int col = 1; col <= 6; col++)
                {
                    cellRange = wordTable.Cell(row, col).Range;
                    cellRange.Text = this.dataGridViewOrder.Rows[row - 2].Cells[col - 1].Value.ToString();
                }
            }
            //Можно выполнить заливку заголовка таблицы:
            wordTable.Rows[1].Shading.ForegroundPatternColor = Word.WdColor.wdColorDarkYellow;
            wordTable.Rows[1].Shading.BackgroundPatternColorIndex = Word.WdColorIndex.wdBlue;
            wordTable.Rows[1].Range.Bold = 1;
            wordTable.Rows[1].Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            wordRange.Font.Size = 12;
            wordRange.Font.Color = Word.WdColor.wdColorBlue;
            wordRange.Font.Name = "Time New Roman";
            wordRange.Font.Italic = 1;

            //Итоговые расчеты

            wordRange.InsertParagraphAfter();
            wordPar = wordDoc.Paragraphs.Add();
            wordRange = wordPar.Range;
            wordRange.Font.Color = Word.WdColor.wdColorRed;
            wordRange.Font.Size = 20;
            wordRange.Text = "Количество наименований: " + dataGridViewOrder.RowCount;

            wordRange.InsertParagraphAfter();
            wordPar = wordDoc.Paragraphs.Add();
            wordRange = wordPar.Range;
            wordRange.Font.Color = Word.WdColor.wdColorRed;
            wordRange.Font.Size = 20;
            wordRange.Text = "Общая сумма: " + (priceOrder + discount).ToString();

            wordRange.InsertParagraphAfter();
            wordPar = wordDoc.Paragraphs.Add();
            wordRange = wordPar.Range;
            wordRange.Font.Color = Word.WdColor.wdColorRed;
            wordRange.Font.Size = 20;
            wordRange.Text = "Скидка: " + discount;

            wordRange.InsertParagraphAfter();
            wordPar = wordDoc.Paragraphs.Add();
            wordRange = wordPar.Range;
            wordRange.Font.Color = Word.WdColor.wdColorRed;
            wordRange.Font.Size = 20;
            wordRange.Text = "Итого: " + priceOrder;

            wordRange.InsertParagraphAfter();
            wordPar = wordDoc.Paragraphs.Add();
            wordRange = wordPar.Range;
            wordRange.Font.Color = Word.WdColor.wdColorRed;
            wordRange.Font.Size = 20;
            wordRange.Text = "Форма оплаты: " + formPay;

            wordRange.InsertParagraphAfter();
            wordPar = wordDoc.Paragraphs.Add();
            wordRange = wordPar.Range;
            wordRange.Font.Color = Word.WdColor.wdColorRed;
            wordRange.Font.Size = 20;
            wordRange.Text = "Сумма заказа прописью: " + priceOrder;

            //Сохранить документ в текущей папке проекта. Имя файла совпадает с текущей датой
            wordDoc.Saved = true;
            //Полный путь к документу
            string pathDoc = path + @"\" + dt.Year + "_" + dt.Month + "_" + dt.Day + "_" +
                                dt.Hour + "_" + dt.Minute + "_" + dt.Second;
            wordDoc.SaveAs(pathDoc + ".docx");

            // wordDoc.SaveAs(pathDoc + ".pdf", Word.WdExportFormat.wdExportFormatPDF);
            wordDoc.Close(true, null, null);
            wordApp.Quit();             //Выйтииз Word
                                        //Уничтожить COM-объекты
            System.Runtime.InteropServices.Marshal.FinalReleaseComObject(wordApp);

        }
    }
}
