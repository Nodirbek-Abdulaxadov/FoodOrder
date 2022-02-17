using FoodOrder.Winform.Services;

namespace FoodOrder.Winform.Pages
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        public void Refresh()
        {
            CategoryAPIService service = new CategoryAPIService();
            categoriyaCount.Text = service.GetKategoriyalar().Count.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
