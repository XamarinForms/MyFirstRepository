﻿using CourseNaviService.NaviServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CustNaviService.ViewModels
{
    public class HomePageViewModel : ViewModelBase
    {
        public ICommand AboutCommand { get; set; }
        public HomePageViewModel():base((Application.Current as App).NavigationService)
        {
            AboutCommand = new Command(() =>
            {
                NavigationService.NavigateToAsync<AboutPageViewModel>();
            });
        }
    }
}
