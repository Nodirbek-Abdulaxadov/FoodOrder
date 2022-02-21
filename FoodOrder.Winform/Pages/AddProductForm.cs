using FoodOrder.Models;
using FoodOrder.ViewModels;
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
        List<Kategoriya> list = new List<Kategoriya>();
        private void AddProductForm_Load(object sender, EventArgs e)
        {
            CategoryAPIService service = new CategoryAPIService();
            categorySelect.Items.Clear();
            list = service.GetKategoriyalar();
            foreach (var item in list)
            {
                categorySelect.Items.Add(item.Nomi);
            }

            categorySelect.SelectedIndex = 0;
        }

        OpenFileDialog dialog = new OpenFileDialog();
        private void button3_Click(object sender, EventArgs e)
        {
            dialog.Filter = "Rasmlar |*.jpg;*jpeg;*png;*bmg;*gif|All files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                button3.Text = dialog.FileName;
                pictureBox1.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add();
        }

        private async void Add()
        {
            try
            {
                MahsulotViewModel mahsulot = new MahsulotViewModel()
                {
                    Id = Guid.NewGuid(),
                    Nomi = name.Text,
                    Narxi = double.Parse(price.Text),
                    Batafsil = description.Text,
                    KategoriyaId = list.FirstOrDefault(c => c.Nomi == categorySelect.Text).Id
                };
                ProductAPIService service = new ProductAPIService();
                _ = await service.AddProduct(mahsulot);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
