using FoodOrder.DataLayer;
using FoodOrder.Services.Interface;
using FoodOrder.Services.Repository;
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
    public partial class AddCategoryForm : Form
    {
        public AddCategoryForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void Add()
        {
            CategoryAPIService service = new CategoryAPIService();
            bool res = await service.AddCategory(name.Text);
            if (res)
            {
                MessageBox.Show("Muvoffaqqiyatli qo'shildi!", "Xabarnoma", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("Xatolik yuz berdi!", "Xabarnoma", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
