using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace kursova1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

        }
        public static string ConvertToBase(int number, int baseNumber)
        {
            string result = "";

            while (number > 0)
            {
                int remainder = number % baseNumber;

                if (remainder < 10)
                {
                    result = remainder.ToString() + result;
                }
                else
                {
                    char digit = (char)('A' + (remainder - 10));
                    result = digit + result;
                }

                number /= baseNumber;
            }

            return result;
        }

        private async void Back2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        bool IsBinaryNumber(string number)
        {
            foreach (char digit in number)
            {
                if (digit != '0' && digit != '1')
                {
                    return false;
                }
            }
            return true;
        }

        private void Convert10_Clicked(object sender, EventArgs e)
        {
            try
            {
                string binaryNumber = userInput2.Text;
                bool isValidBinary = IsBinaryNumber(binaryNumber);

                if (isValidBinary)
                {
                    int decimalNumberbinary = Convert.ToInt32(binaryNumber, 2);
                    ConvertLabel2.Text = Convert.ToString(decimalNumberbinary);
                }
                else
                {
                    ConvertLabel2.Text = "Enter ONLY binary number system";
                }
            }
            catch (Exception)
            {
               
                ConvertLabel2.Text = "We need to enter a number";
            } 
            

            


        }

        private void Convert2_Clicked(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(userInput10.Text);
                int baseNumber = 2;
                string binary = ConvertToBase(num, baseNumber);
                ConvertLable1.Text = binary;
            } 
            catch(Exception) { ConvertLable1.Text = "We need to enter a number"; }
            
        }
    }
}