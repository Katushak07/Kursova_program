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
    public partial class Page16 : ContentPage
    {
        public Page16()
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

        private async void Back16_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        bool IsHexadecimalNumber(string number)
        {
            foreach (char digit in number)
            {
                if (!IsHexadecimalDigit(digit))
                {
                    return false;
                }
            }
            return true;
        }

        
        bool IsHexadecimalDigit(char digit)
        {
            return (digit >= '0' && digit <= '9') || (digit >= 'A' && digit <= 'F') || (digit >= 'a' && digit <= 'f');
        }

        private void Convert16_Clicked(object sender, EventArgs e)
        {
            try 
            {
                int num = int.Parse(userInput10.Text);
                int baseNumber = 16;
                string binary = ConvertToBase(num, baseNumber);
                ConvertLable1.Text = binary;
            }
            catch (Exception) 
            {
                ConvertLable1.Text = "We need to enter a number";
            }

           
        }

        private void Convert10_Clicked(object sender, EventArgs e)
        {
            try 
            {
                string hexadecimalNumber = userInput2.Text;
                bool isValidHexadecimal = IsHexadecimalNumber(hexadecimalNumber);

                if (isValidHexadecimal)
                {
                    int decimalNumberOctal = Convert.ToInt32(hexadecimalNumber, 16);
                    ConvertLabel2.Text = Convert.ToString(decimalNumberOctal);
                }
                else
                {
                    ConvertLabel2.Text = "Enter ONLY hexadecimal number system";

                }
            }
            catch(Exception )
            {
                ConvertLable1.Text = "We need to enter a number";
            }


            
        }
    }
}