﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ExpediaXamApp.Views;
using Xamarin.Forms;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExpediaXamApp.ViewModels
{
    class IntroductionPageViewModel : BaseViewModel
    {
        private string _pageTitle = "Introduction Page";

        public string PageTitle
        {
            get { return _pageTitle; }
            set
            {
                _pageTitle = value;
                OnPropertyChanged();
            }
        }

        public IntroductionPageViewModel()
        {
            ShowFlightsCommand = new Command(() => ShowFlights());
        }

        public object ShowFlightsCommand { get; set; }

        public async Task ShowFlights()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new FlightsPage());
        }


    }
}