using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinProj.Models;

namespace BethanysPieShopMobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PieDetailView : ContentPage
    {
        public PieDetailView(Pie pie)
        {
            InitializeComponent();

            BindData(pie);
        }

        private void BindData(Pie pie)
        {
            PieNameLabel.Text = pie.PieName;
            PieImage.Source = pie.ImageUrl;
            DescriptionLabel.Text = pie.Description;
            PriceLabel.Text = pie.Price.ToString("c");
            InStockLabel.Text = pie.InStock ? "In stock" : "Not in stock";
        }

        private async void AddToBasketButton_OnClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Success", "Pie added to baskey!", "Done");
        }
    }
}