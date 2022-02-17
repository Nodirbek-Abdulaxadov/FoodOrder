using FoodOrder.Models;
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
    public partial class Categories : UserControl
    {
        CategoryAPIService service;
        List<Kategoriya> list;
        string selectedId = "";
        public Categories()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Categories_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCategoryForm add = new AddCategoryForm();
            add.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            service = new CategoryAPIService();
            list = service.GetKategoriyalar();

            dataGridView1.DataSource = list;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedId = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (selectedId != "")
            {
                DialogResult dialog = MessageBox.Show("Rostdan ham o'chirmoqchisiz?", "Xabarnoma", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    service = new CategoryAPIService();
                    bool res = service.DeleteCategory(selectedId);
                    if (res)
                    {
                        MessageBox.Show("Muvoffaqqiyatli o'chirildi!", "Xabarnoma", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xatolik yuz berdi!", "Xabarnoma", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Refresh();
                }                
            }
            else
            {
                MessageBox.Show("O'chirish uchun tanlang!", "Xabarnoma", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditCategoryForm edit = new EditCategoryForm();
            edit.Id = Guid.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            edit.Nomi = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            edit.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FilterByName();
        }

        private void FilterByName()
        {
            var filteredList = new List<Kategoriya>();
            foreach (var item in list)
            {
                if (item.Nomi.ToLower().Contains(textBox1.Text.ToLower()))
                {
                    filteredList.Add(item);
                }
            }
            dataGridView1.DataSource = filteredList;
        }
    }
}
