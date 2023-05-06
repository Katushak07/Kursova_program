

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific.AppCompat;

namespace kursova_1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Xamarin.Forms.NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void BinaryButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new kursova1.Page2());
            
        }

        private async void OctalButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new kursova1.Page8());


        }

        private async void HexadecimalButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync (new kursova1.Page16());

        }
    }
}
