using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Laboratorio9
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Item1.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Tap());
            };
            Item2.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Pinch());
            };
            Item3.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Swipe());
            };
            Item4.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new PinchDemo());
            };
        }
    }
}
