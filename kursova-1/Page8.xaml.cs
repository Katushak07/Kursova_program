using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using kursova_1;

namespace kursova1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page8 : ContentPage
    {
        public Page8()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

        }
           

        private async void Back8_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private  void Convert8_Clicked(object sender, EventArgs e)
        {

            try
            {
                int num = int.Parse(userInput10.Text);
                int baseNumber = 8;
                string binary = ConvertToBase(num, baseNumber);
                ConvertLable1.Text = binary;
            }
            catch (Exception) { ConvertLable1.Text = "We need to enter a number"; }
        }
        bool IsOctalNumber(string number)
        {
            foreach (char digit in number)
            {
                if (digit < '0' || digit > '7')
                {
                    return false;
                }
            }
            return true;
        }


        private  void Convert10_Clicked(object sender, EventArgs e)
        {
            try
            {
            string octalNumber = userInput8.Text;
            bool isValidOctal = IsOctalNumber(octalNumber);

            if (isValidOctal)
            {
               
                int decimalNumberOctal = Convert.ToInt32(octalNumber, 8);
                ConvertLabel2.Text = Convert.ToString(decimalNumberOctal);
            }
            else
            {
                
               ConvertLabel2.Text = "Enter ONLY octal number system";
                    
            }

            }
            catch (Exception)
            {
                ConvertLabel2.Text = "We need to enter a number";

            }
            
            


        }
    }
}
