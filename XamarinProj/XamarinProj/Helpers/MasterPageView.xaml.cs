﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinProj.Helpers
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MasterPageView : ContentPage
	{
        public MasterPageView()
        {
            InitializeComponent();

            masterView.NavigationListView.ItemSelected += NavigationListView_ItemSelected;
        }
    }
}