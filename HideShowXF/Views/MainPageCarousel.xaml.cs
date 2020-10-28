using Xamarin.Forms;

namespace HideShowXF.Views
{
    public partial class MainPageCarousel : ContentPage
    {
        public MainPageCarousel()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }
    }
}
