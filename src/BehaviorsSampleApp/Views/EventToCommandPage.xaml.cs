﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BehaviorsSampleApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BehaviorsSampleApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EventToCommandPage : ContentPage
	{
		public EventToCommandPage()
		{
			InitializeComponent();
		}

		private void OnNavigateNextPageReceived(object sender, EventArgs e)
		{
			var nextPage = new SelectionResultPage();
			var nextPageViewModel = nextPage.BindingContext as SelectionResultPageViewModel;
			nextPageViewModel.Fruit = ((SelectedFruitEventArgs) e).SelectedFruit;
			Navigation.PushAsync(nextPage);
		}
	}
}