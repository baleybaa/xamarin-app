﻿using masterpagep1.MenuItems;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace masterpagep1
{
    public partial class MainPage : MasterDetailPage
    {
        public List<MasterPageItem> menuList
        {
            get;
            set;
        }
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            //((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.Black;
            //((NavigationPage)Application.Current.MainPage).BarTextColor = Color.OrangeRed;

            menuList = new List<MasterPageItem>();
            // Adding menu items to menuList and you can define title ,page and icon  
            menuList.Add(new MasterPageItem()
            {
                Title = "Home",
                Icon = "hom.png",

                TargetType = typeof(Home)
               
            });
            menuList.Add(new MasterPageItem()
            {
                Title = "Saved",
                Icon = "saved.png",
                TargetType = typeof(Saved)
                
            });
            menuList.Add(new MasterPageItem()
            {
                Title = "Messenger",
                Icon = "messg.png",
                TargetType = typeof(Messenger)
            });
            menuList.Add(new MasterPageItem()
            {
                Title = "My Account",
                Icon = "acco.png",
                TargetType = typeof(MyAccount)

            });
            menuList.Add(new MasterPageItem()
            {
                Title = "Help Center",
                Icon = "help.png",
                TargetType = typeof(help)
            });
            menuList.Add(new MasterPageItem()
            {
                Title = "Setting",
                Icon = "sett.png",
                TargetType = typeof(Setting)
            });
            // Setting our list to be ItemSource for ListView in MainPage.xaml  
            navigationDrawerList.ItemsSource = menuList;
            // Initial navigation, this can be used for our home page  
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Home)));
        }
        // Event for Menu Item selection, here we are going to handle navigation based  
        // on user selection in menu ListView  
        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;
            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
          
            IsPresented = false;
        }
        //protected override void OnElementChanged(ElementChangedEventArgs e)
        //{
        //    base.OnElementChanged(e);

        //    if (e.NewElement == null)
        //        return;

        //    if (Control != null)
        //    {
        //        Control.ScrollEnabled = false;
        //    }
        }
    }
    

