using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronMenu.Forms
{
    public class Order
    {
        //Категория
        public string Category { get; set; }

        //Название
        public string Title { get; set; }

        //Цена
        public double Price { get; set; }

        //Количество в заказе
        public int Count { get; set; }
    }
}
