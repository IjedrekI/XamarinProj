using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Android.Telecom.Call;

namespace XamarinProj
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPageViewDetail : MasterDetailPage
    {
        //MasterNavigationItem
        //
        public MasterDetailPageViewDetail()
        {
            InitializeComponent();

            masterView.NavigationListView.ItemSelected += NavigationListView_ItemSelected;
        }


        private void NavigationListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is MasterNavigationItem item)
            {
                Details = new NavigationPage((Page)Activator.CreateInstance(item.Target));
                masterView.NavigationListView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}