using FoodOrder.Models;
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
    public partial class EditProduct : Form
    {
        public EditProduct()
        {
            InitializeComponent();
        }

        public List<Kategoriya> kategorias { get; set; }

        private Mahsulot mahsulot { get; set; }
        public Mahsulot Mahsulot
        {
            get { return mahsulot; }
            set 
            { 
                mahsulot = value;
                name.Text = mahsulot.Nomi;
                price.Text = mahsulot.Narxi.ToString();
                description.Text = mahsulot.Batafsil;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductAPIService service = new ProductAPIService();
            Mahsulot p = new Mahsulot()
            {
                Id = mahsulot.Id,
                Nomi = name.Text,
                Narxi = double.Parse(price.Text),
                Batafsil= description.Text,
                KategoriyaId = mahsulot.KategoriyaId
            };

            var res = service.UpdateProduct(p);
            if (res.IsSuccessStatusCode)
            {
                MessageBox.Show("Muvoffaqqiyatli yangilandi!", "Xabarnoma", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xatolik yuz berdi!", "Xabarnoma", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {
            CategoryAPIService service = new CategoryAPIService();
            categorySelect.Items.Clear();
            kategorias = service.GetKategoriyalar();
            foreach (var item in kategorias)
            {
                categorySelect.Items.Add(item.Nomi);
            }
            var currentProductCategory = kategorias.FirstOrDefault(c => c.Id == mahsulot.KategoriyaId);
            categorySelect.SelectedIndex = kategorias.IndexOf(currentProductCategory);
        }
    }
}
