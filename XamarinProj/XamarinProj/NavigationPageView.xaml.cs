using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinProj
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NavigationPageView : ContentPage
	{
		public NavigationPageView ()
		{
			InitializeComponent ();
		}

        private async void HomePageButton_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new Helpers.HomePageView());
        }

        private async void OverviewButton_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new Helpers.ItemOverview());
        }

        private async void BasketButton_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new Helpers.Page1());
        }

        private async void ContactButton_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new Helpers.ContactView());
        }
    }
}