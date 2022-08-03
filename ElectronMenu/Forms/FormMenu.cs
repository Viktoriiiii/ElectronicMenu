using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.IO;
using ElectronMenu.Forms;
using ElectronMenu.Classes;
using System.Windows.Forms.DataVisualization.Charting;

namespace ElectronMenu
{
    public partial class FormMenu : Form
    {
        Customer cs = new Customer();

        int countCategory;
        string stringCategory;
        string fileName;
        string path;
        int countFood;
        string stringCatego;

        public static double summaWallet;		//Сумма в кошельке
        public static double summaOrder;		//Сумма заказа
        public static double summaBalance;	//Сумма остатка
        string selectCategory;		//Название выбранной категории
        List<Order> listOrder;	//Список информации о выбранных блюдах для покупателя

        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonReturnToMain_Click(object sender, EventArgs e)
        {
            Application.OpenForms["FormMenu"].Close();
            Application.OpenForms[0].Show();
        }

        private void buttonBasket_Click(object sender, EventArgs e)
        {
            FormBasket fb = new FormBasket(listOrder, cs);
            fb.Owner = this;
            this.Hide();
            fb.ShowDialog();
            this.Show();
        }

        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !(MessageBox.Show("Закрыть данную страницу?", "Закрытие", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            == DialogResult.Yes);
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            
            cs.setWallet();
            MessageBox.Show("В вашем кошельке находится сумма " + cs.getWallet() + " рублей. Номер вашего заказа " + cs.Nomer);


            MessageBox.Show("Для промотра полной информации о блюде, наведите на него курсор");
            path = Application.StartupPath;      //Путь к exe-файлу приложения
            fileName = path + @"\Menu.xlsx"; //Абсолютный путь к файлу Excel
            if (File.Exists(fileName))          //Проверить наличие документа
            {
                //Открыть книгу Excel
                ClassTotal.excelBook = ClassTotal.excelApp.Workbooks.Open(fileName);

                //Связаться с нужным листом-категорией блюд
                ClassTotal.excelSheet =
                (Excel.Worksheet)ClassTotal.excelBook.Worksheets.get_Item("Категории");
                //Ссылка на заполненныеячеки в листе
                ClassTotal.excelCells =
                ClassTotal.excelSheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell);
                //Номер последней заполненной строки – это число строк (названий блюд)
                countCategory = ClassTotal.excelCells.Row;

                for (int i = 1; i <= countCategory; i++)        //По всем категориям
                {
                    ClassTotal.excelCells = ClassTotal.excelSheet.Cells[i, 1];      //Ссылка на ячейку
                    string nameFood = ClassTotal.excelCells.Value2;        //Название блюда

                    ListViewItem listViewCat = new ListViewItem();       //Элемент списка
                    listViewCat.Text = nameFood;  //Текст элемента 
                    listViewCategory.Items.Add(listViewCat);
                }
            }
            else
            {
                MessageBox.Show("Файл с меню отсутствует");
                this.Close();
            }

            listOrder = new List<Order>();

            this.chartMoney.Legends[0].Enabled = false;
            this.chartMoney.Series[0].ChartType = SeriesChartType.Pie;

            ShowOrder();
        }
        private void listViewCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (File.Exists(fileName))          //Проверить наличие документа
            {
                foreach (var list in listViewCategory.SelectedItems)
                {
                    int i = 0;
                    stringCatego = listViewCategory.SelectedItems[i].Text;
                    i++;
                }

                //Связаться с нужным листом-категорией блюд
                ClassTotal.excelSheet =
                (Excel.Worksheet)ClassTotal.excelBook.Worksheets.get_Item(stringCatego);
                //Ссылка на заполненные ячеки в листе
                ClassTotal.excelCells =
                ClassTotal.excelSheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell);
                //Номер последней заполненной строки – это число строк (названий блюд)
                countFood = ClassTotal.excelCells.Row;
                //Настройки ListView для отображения картинок блюд
                this.listViewD.Items.Clear();        //Сначала список надо очистить
                this.listViewD.CheckBoxes = true;    //Разрешить флажки возле картинок
                this.listViewD.LabelWrap = true;    //Разрешить перенос на новую строку
                this.listViewD.MultiSelect = true;   //Разрешить выделять несколько
                this.listViewD.FullRowSelect = true;
                this.listViewD.RightToLeftLayout = false;
                this.listViewD.Scrollable = true;    //Обеспечитьналичиеполоспрокрутки
                this.listViewD.View = View.LargeIcon;    //Видкомпонента – большиекартинки
                                                         //Созданиеспискакартинок
                ImageList il = new ImageList();       //Динамический элемент – массив изображений
                il.ImageSize = new Size(100, 100);   //Размеры всех изображений одинаковы
                this.listViewD.LargeImageList = il;  //Связать два списка между собой
                il.Images.Clear();              //Очистить список картинок
                string nameFood;             //Название блюда
                double costFood;             //Цена блюда
                double caloriFood;          // Калории
                double weight;              // Вес
                string fileFood;             //Файл картинки
                Bitmap bitmap;
                for (int i = 1; i <= countFood; i++)        //По всем блюдам
                {
                    ClassTotal.excelCells = ClassTotal.excelSheet.Cells[i, 1];      //Ссылка на ячейку
                    nameFood = ClassTotal.excelCells.Value2;        //Название блюда
                    ClassTotal.excelCells = ClassTotal.excelSheet.Cells[i, 2];      //Ссылка на ячейку
                    costFood = ClassTotal.excelCells.Value2;        //Цена блюда
                    ClassTotal.excelCells = ClassTotal.excelSheet.Cells[i, 3];      //Ссылка на ячейку
                    caloriFood = ClassTotal.excelCells.Value2;        //калории
                    ClassTotal.excelCells = ClassTotal.excelSheet.Cells[i, 4];      //Ссылка на ячейку
                    weight = ClassTotal.excelCells.Value2;        //вес

                    ListViewItem lvi = new ListViewItem();       //Элемент списка
                    lvi.Text = nameFood + " - " + costFood.ToString();
                    lvi.ToolTipText = nameFood + ". Стоимость - " + costFood.ToString() + " руб., \r\nкалории - " 
                        + caloriFood.ToString() + ", \r\nграмм/мл - " + weight;  //Текст посказки
                    //Абсолютный путь к файлу с изображением блюда
                    fileFood = path + @"\" + stringCatego + @"\" + nameFood + ".jpg";

                    if (File.Exists(fileFood))              //Проверка существования картинки
                    {
                        bitmap = new Bitmap(fileFood);      //Есть – загрузить
                    }
                    else
                    {
                        bitmap = Properties.Resources.icon1;        //Нет – изресурсов
                    }
                    il.Images.Add(bitmap);      //Добавить картинку в массив картинок
                    lvi.ImageIndex = (i - 1);       //Для элемента списка задать индекс картинки
                    listViewD.Items.Add(lvi);        // добавляем элемент в ListView
                }
            }
            else
            {
                MessageBox.Show("Файл с меню не найден");
                this.Close();
            }
        }

        /// Метод текущих расчетов и их отображения
        public void ShowOrder()
        {
            //Отображать список с учетом списка из информации о блюдах
            this.listViewChoice.Items.Clear();
            summaOrder = 0;
            //Просмотр списка информации о блюдах
            foreach (var itemList in listOrder)
            {
                //Вывести название и цену
                this.listViewChoice.Items.Add(itemList.Title + " - " + itemList.Count);
                //Учет в стоимости заказа выбранного блюда и его количества
                summaOrder += (itemList.Price * itemList.Count);
            }
            summaBalance = cs.getWallet() - summaOrder;    //Расчет остатка
                                                        //Отображение
            this.labelOutput.Text = "Было в кошельке = " + cs.getWallet() + Environment.NewLine +
                            "Сумма заказа = " + summaOrder + Environment.NewLine +
            "Осталось средств = " + summaBalance;

            chartMoney.Series[0].Points.Clear();
           // this.chartMoney.Visible = false;
            
            this.chartMoney.Legends[0].Enabled = false;
            this.chartMoney.Series[0].Points.AddY(summaBalance);
            this.chartMoney.Series[0].Points.AddY(summaOrder);
            this.chartMoney.Series[0].Points[0].LegendText = "Осталось";
            this.chartMoney.Series[0].Points[1].LegendText = "Затрачено";
            this.chartMoney.Visible = true;
            this.chartMoney.Legends[0].Enabled = true;
        }

        /// Перенести выбранные блюда в заказ
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string titleDish = "";
            string tempCat;
            // выделить название категории
            foreach (ListViewItem item in listViewCategory.SelectedItems)
            {
                tempCat = item.Text;
                selectCategory = tempCat.Split()[0];
            }

            Order order;
            string temp;
            bool search = false;
            double summaSelect = 0;
            //Проверка наличия выбранных блюд
            int countSelect = this.listViewD.CheckedItems.Count;

            if (countSelect == 0)
            {
                MessageBox.Show("Вы не выбрали ни одно блюдо");
                return;
            }
            //Расчет стоимости выбранных блюд
            foreach (ListViewItem item in this.listViewD.SelectedItems)
            {
                summaSelect += double.Parse(item.Text.Split('-')[1]);
            }
            //Проверка достаточного количества денег на выбранные блюда
            if (summaSelect > summaBalance)
            {
                MessageBox.Show("У Вас не хватает денег на этот заказ");
                return;
            }
            //Перенос выбранных блюд в заказ
            foreach (ListViewItem item in this.listViewD.CheckedItems)
            {
                temp = item.Text;
                search = false;
                titleDish = temp.Split('-')[0];         //Название
                                                        //Поиск выбранного блюда среди заказанных
                foreach (var itemList in listOrder)	//Просмотр всех заказанных блюд
                {
                    if (titleDish == itemList.Title)		//Такое уже выбирали
                    {
                        itemList.Count++;           //Увеличиваем количество этого блюда
                        search = true;
                        break;
                    }
                }
                if (!search)		//Если это блюдо выбрали первый раз, то добавляем его список
                {
                    order = new Order();      //Создать объект с информацией о блюде
                    order.Category = selectCategory; //Заполнить поля объекта класса "название категории"
                    order.Title = titleDish;
                    order.Price = int.Parse(temp.Split('-')[1]);
                    order.Count = 1;             //Первый раз
                    listOrder.Add(order);           //Добавить новый объект в список
                }
            }
            ShowOrder();					//Пересчитать и отобразить
        }

        public void buttonClear_Click()
        {
            summaOrder = 0;
            summaBalance = 0;
            listOrder.Clear();
            listViewD.Clear();
            ShowOrder();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string titleDish = "";
            double summaSelect = 0;
            string temp;
            bool search = false;

            int countSelect = this.listViewD.CheckedItems.Count;
            if (countSelect == 0)
            {
                MessageBox.Show("Вы не выбрали ни одно блюдо");
                return;
            }
            //Расчет стоимости выбранных блюд
            foreach (ListViewItem item in this.listViewD.CheckedItems)
            {
                summaSelect += double.Parse(item.Text.Split('-')[1]);
            }

            // Удаление выбранных блюд из заказа
            foreach (ListViewItem item in this.listViewD.CheckedItems)
            {
                temp = item.Text;
                search = false;
                titleDish = temp.Split('-')[0];         //Название
                                                        //Поиск выбранного блюда среди заказанных
                foreach (var itemList in listOrder)	//Просмотр всех заказанных блюд
                {
                    if (titleDish == itemList.Title)		//Такое уже выбирали
                    {                        
                        itemList.Count--;           //Уменьшаем количество этого блюда
                        if (itemList.Count == 0) listOrder.Remove(itemList);
                        search = true;
                        break;
                    }
                }
                if (!search)
                {
                    MessageBox.Show("Данного блюда уже нет в заказе");
                }
            }
            ShowOrder();
        }

        private void FormMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClassTotal.excelApp.Quit();      //Выйти из Excel

            //Заставляет сборщик мусора провести сборку мусора
            GC.Collect();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            summaOrder = 0;
            summaBalance = 0;
            listOrder.Clear();
            ShowOrder();
        }
    }
}
