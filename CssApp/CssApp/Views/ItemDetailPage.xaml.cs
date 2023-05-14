using System.ComponentModel;
using CssApp.ViewModels;
using Xamarin.Forms;

namespace CssApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}