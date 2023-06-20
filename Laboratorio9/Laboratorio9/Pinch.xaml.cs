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
    public partial class Pinch : ContentPage
    {
        bool isVisible = false;
        public Pinch()
        {
            InitializeComponent();
            var pinch1 = new PinchGestureRecognizer();
            pinch1.PinchUpdated += EventPinch;
            image1.GestureRecognizers.Add(pinch1);
        }
        void EventPinch(object sender, EventArgs e)
        {
            isVisible = !isVisible;

            if (isVisible)
                lblPinch.BackgroundColor = Color.Black;
            else
                lblPinch.BackgroundColor = Color.Red;
        }
    }
}