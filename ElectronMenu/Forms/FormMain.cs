using ElectronMenu.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ElectronMenu
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonControlMenu_Click(object sender, EventArgs e)
        {
            FormControl fc = new FormControl();
            this.Hide();
            fc.ShowDialog();
            this.Show();
        }

        private void buttonMakeOrder_Click(object sender, EventArgs e)
        {          
            FormMenu fm = new FormMenu();
            this.Hide();
            fm.ShowDialog();     
            this.Show();            
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !(MessageBox.Show("Закрыть приложение?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            == DialogResult.Yes);
        }

        private void buttonMakeOrder_MouseMove(object sender, MouseEventArgs e)
        {
            

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                ClassTotal.excelApp = new Excel.Application();  //Создать объект Excel
                ClassTotal.excelApp.Visible = false;         //Не отображать приложение Excel
            }
            catch
            {
                MessageBox.Show("Скачай MS Excel");
                this.Close();
            }           

        }

        private void buttonPriceList_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath;      //Путь к exe-файлу приложения
            string fileName = path + @"\Menu.xlsx"; //Абсолютный путь к файлу Excel
            if (File.Exists(fileName))          //Проверить наличие документа
            {
                //Открыть книгу Excel
                ClassTotal.excelBook = ClassTotal.excelApp.Workbooks.Open(fileName);
                ClassTotal.excelApp.Visible = true;
            }
            else
            {
                MessageBox.Show("Файл с меню отсутствует");
                this.Close();
            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClassTotal.excelApp.Quit();      //Выйти из Excel
                //Уничтожить все COM-объекты
            System.Runtime.InteropServices.Marshal.FinalReleaseComObject(ClassTotal.excelApp);
                //Заставляет сборщик мусора провести сборку мусора
            GC.Collect();
        }
    }
}
