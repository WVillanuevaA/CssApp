using System;
using System.Collections.Generic;
using System.ComponentModel;
using CssApp.Models;
using CssApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CssApp.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}