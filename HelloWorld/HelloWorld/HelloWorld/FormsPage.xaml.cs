﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FormsPage : ContentPage
    {
        public FormsPage()
        {
            InitializeComponent();
        }
        public void Tapp(Object sender, EventArgs e)
        {
            var page = new ContactMethodsPage();
            page.ContactMethods.ItemSelected += (source, args) =>
              {
                  contactMethod.Text = args.SelectedItem.ToString();
                  Navigation.PopAsync();
              };
            Navigation.PushAsync(page);
        }
    }
    
}