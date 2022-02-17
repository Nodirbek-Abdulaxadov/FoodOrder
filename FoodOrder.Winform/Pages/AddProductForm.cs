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
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            CategoryAPIService service = new CategoryAPIService();
            categorySelect.Items.Clear();
            foreach (var item in service.GetKategoriyalar())
            {
                categorySelect.Items.Add(item.Nomi);
            }

            categorySelect.SelectedIndex = 0;
        }
    }
}
