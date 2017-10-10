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
    public partial class Basket : Form
    {
        private const int countPropertiesInProduct = 4;
        public Basket()
        {
            InitializeComponent();
        }
        public void AddProduct(Item product)
        {
            productsListView.Items.Add(new ListViewItem(new string[countPropertiesInProduct] { product.Name, product.Characteristic, product.Description, product.Price.ToString() }));
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
                productsListView.Items.Remove(productsListView.FocusedItem);
        }

        private void Buy_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Спасибо за покупку!");

            productsListView.Items.Clear();
            this.Visible = false;
        }
    }
}
