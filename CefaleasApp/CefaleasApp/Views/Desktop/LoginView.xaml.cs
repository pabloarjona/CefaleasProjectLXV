﻿using Pitasoft.Shell;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CefaleasApp.Views.Desktop
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginView : ContentPage, IView, ILoginView
    {
        public IViewModel ViewModel { get; set; }
        public LoginView()
        {
            InitializeComponent();
        }
    }
}