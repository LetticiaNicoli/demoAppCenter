﻿using System;
using Microsoft.AppCenter.Analytics;
using Xamarin.Forms;

namespace demoAppCenter
{
    public class MainPage : TabbedPage
    {
        public MainPage()
        {
            Page itemsPage, aboutPage = null;

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    itemsPage = new NavigationPage(new ItemsPage())
                    {
                        Title = "Beer"
                    };

                    aboutPage = new NavigationPage(new AboutPage())
                    {
                        Title = "Cerveja do dia"
                    };
                    itemsPage.Icon = "tab_feed.png";
                    aboutPage.Icon = "tab_about.png";
                    break;
                default:
                    itemsPage = new ItemsPage()
                    {
                        Title = "Beer"
                    };

                    aboutPage = new AboutPage()
                    {
                        Title = "Cerveja do dia"
                    };
                    break;
            }

            Children.Add(itemsPage);
            Children.Add(aboutPage);

            Title = Children[0].Title;
        }

        protected override void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();
            Title = CurrentPage?.Title ?? string.Empty;
            Analytics.TrackEvent($"Clicou na tela {Title}");
        }
    }
}
