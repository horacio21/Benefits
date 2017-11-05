namespace Benefits.Views
{
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            SalaryType.Items.Add("Semanal");
            SalaryType.Items.Add("Quincenal");
            SalaryType.Items.Add("Mensual");

            //SalaryLabel.Text += SalaryType.ToString();
        }
    }
}