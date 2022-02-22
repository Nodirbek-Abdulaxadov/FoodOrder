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
    public partial class Products : UserControl
    {
        ProductAPIService service;
        private string? selectedId;

        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddProductForm add = new AddProductForm();
            add.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        List<Mahsulot> mahsulotList;
        void LoadData()
        {
            service = new ProductAPIService();
            mahsulotList = service.GetMahsulotlar();
            dataGridView1.DataSource = mahsulotList;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (selectedId != "")
            {
                DialogResult dialog = MessageBox.Show("Rostdan ham o'chirmoqchisiz?", "Xabarnoma", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    service = new ProductAPIService();
                    var res = service.DeleteProduct(selectedId);
                    if (res.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Muvoffaqqiyatli o'chirildi!", "Xabarnoma", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xatolik yuz berdi!", "Xabarnoma", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("O'chirish uchun tanlang!", "Xabarnoma", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedId = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EditProduct edit = new EditProduct();
            Mahsulot mahsulot = service.GetById(selectedId);
            edit.Mahsulot = mahsulot;
            edit.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            FilterByName();
        }
        private void FilterByName()
        {
            var filteredList = new List<Mahsulot>();
            foreach (var item in mahsulotList)
            {
                if (item.Nomi.ToLower().Contains(textBox2.Text.ToLower()))
                {
                    filteredList.Add(item);
                }
            }
            dataGridView1.DataSource = filteredList;
        }
    }
}
