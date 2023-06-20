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
    public partial class Swipe : ContentPage
    {
        bool isVisible = false;
        public Swipe()
        {
            InitializeComponent();
            var swipe1 = new SwipeGestureRecognizer();
            swipe1.Swiped += EventSwipe;
            swipe1.Direction = SwipeDirection.Right;
            image1.GestureRecognizers.Add(swipe1);

            var swipe2 = new SwipeGestureRecognizer();
            swipe2.Swiped += EventSwipeImage;
            swipe2.Direction = SwipeDirection.Right;
            image2.GestureRecognizers.Add(swipe2);
        }
        void EventSwipe(object sender, EventArgs e)
        {
            isVisible = !isVisible;

            if (isVisible)
                lblswipe.BackgroundColor = Color.Black;
            else
                lblswipe.BackgroundColor = Color.White;
        }

        void EventSwipeImage(object sender, EventArgs e)
        {
            isVisible = !isVisible;

            if (isVisible)
                image2.Source = "c2.png";
            else
                image2.Source = "c.png";
        }
    }
}