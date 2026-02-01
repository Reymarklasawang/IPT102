using IPT102LasawangMauiApp.Models;
using IPT102LasawangMauiApp.PageModels;

namespace IPT102LasawangMauiApp.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}