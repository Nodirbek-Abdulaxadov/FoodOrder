using FoodOrder.Winform.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodOrder.Winform.Pages
{
    public partial class Products : UserControl
    {
        ProductAPIService service;
        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            service = new ProductAPIService();
            dataGridView1.DataSource = service.GetMahsulotlar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddProductForm add = new AddProductForm();
            add.ShowDialog();
        }
    }
}
