using FoodOrder.Winform.Services;

namespace FoodOrder.Winform.Pages
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        public void Refresh()
        {
            CategoryAPIService service = new CategoryAPIService();
            categoriyaCount.Text = service.GetKategoriyalar().Count.ToString();

            ProductAPIService productAPIService = new ProductAPIService();
            label3.Text = productAPIService.GetMahsulotlar().Count.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
