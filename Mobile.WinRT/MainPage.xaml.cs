﻿using Windows.UI.Xaml.Navigation;


namespace Mobile.WinRT
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;

            LoadApplication(new Mobile.App());
        }

      
    }
}
