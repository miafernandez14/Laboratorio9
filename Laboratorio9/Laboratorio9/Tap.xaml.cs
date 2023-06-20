using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Laboratorio9
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tap : ContentPage
    {
        bool isTap = false;

        bool isVisible = false;
        public Tap()
        {
            InitializeComponent();
            var tap1 = new TapGestureRecognizer();
            tap1.Tapped += EventTap;
            lblTap1.GestureRecognizers.Add(tap1);

            var tap2 = new TapGestureRecognizer();
            tap2.Tapped += EventTapImage;
            lblTap2.GestureRecognizers.Add(tap2);
        }
        void EventTap(object sender, EventArgs e)
        {
            isTap = !isTap;

            if (isTap)
                btnTap1.BackgroundColor = Color.Purple;
            else
                btnTap1.BackgroundColor = Color.Black;
        }

        void EventTapImage(object sender, EventArgs e)
        {
            isVisible = !isVisible;

            if (isVisible)
                image1.Source = "c.png";
            else
                image1.Source = "c2.png";
        }
    }
}