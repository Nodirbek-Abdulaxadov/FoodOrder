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
    public partial class EditCategoryForm : Form
    {
        public EditCategoryForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Guid id { get; set; }
        public Guid Id
        {
            get { return id; }
            set { id = value; }
        }

        private string nomi { get; set; }
        public string Nomi
        {
            get { return nomi; }
            set { nomi = value; name.Text = nomi; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Update();
        }

        private async void Update()
        {
            CategoryAPIService service = new CategoryAPIService();
            bool res = await service.UpdateCategory(id, name.Text);
            if (res)
            {
                MessageBox.Show("Muvoffaqqiyatli yangilandi!", "Xabarnoma", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xatolik yuz berdi!", "Xabarnoma", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
    }
}
