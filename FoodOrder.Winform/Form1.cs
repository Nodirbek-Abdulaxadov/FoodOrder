namespace FoodOrder.Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HideAll();
            dashboard1.Visible = true;
        }

        void HideAll()
        {
            dashboard1.Visible = false;
            categories1.Visible = false;
            products1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HideAll();
            categories1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HideAll();
            products1.Visible = true;
        }
    }
}