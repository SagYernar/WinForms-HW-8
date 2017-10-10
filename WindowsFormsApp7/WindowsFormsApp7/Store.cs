using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_WF
{
    public partial class Store : Form
    {
        private Basket basket;
        List<Item> items;

        public Store()
        {
            InitializeComponent();
            basket = new Basket();

            items = new List<Item>
            {
                new Item
                {
                    Name = "Оперативная память DDR-4 DIMM",
                    Characteristic="8Gb/2133MHz PC17066 ",
                    Description = "Kingston HyperX Fury Black, Dual-rank, BOX",
                    Price = 27800
                },
                new Item
                {
                    Name= "Процессор Intel Pentium DualCore G4560",
                    Characteristic = "Тактовая частота, ГГц: 3.5. Количество ядер: 2 ядра",
                    Description = "Популярный процессор от Intel с отличным соотношением цена-качество ",
                    Price = 29400
                },
                new Item
                {
                    Name= "Жесткий диск HDD",
                    Characteristic = "1000 Gb",
                    Description= "Тoshiba (HDWD110UZSVA), 3.5, 64Mb, SATA III",
                    Price = 58100
                },
                new Item
                {
                    Name = "Видеокарта PCI-E",
                    Characteristic = "8192Mb",
                    Description = " Gigabyte RX VEGA 64, Radeon RX VEGA 64",
                    Price = 286200
                },
            };

            itemsListBox.DataSource = items;
            itemsListBox.DisplayMember = "Name";
        }

        private void Upload_Click(object sender, EventArgs e)
        {
            basket.Show();
            basket.Visible = true;
            basket.AddProduct(items[itemsListBox.SelectedIndex]);
        }

        private void ProductsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            priceLabel.Text = items[itemsListBox.SelectedIndex].Price.ToString() + " тг.";
        }
    }
}
