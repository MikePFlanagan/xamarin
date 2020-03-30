using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


using Xamarin.Forms;

namespace MusicAcademyCRM
{
    public partial class RegisterPage : ContentPage
    {
        private object passwordEntry;

        public RegisterPage()
        {
            InitializeComponent();
        }




        private void RegisterButton_Clicked(object sender, EventArgs e)
        {
            

            if (PasswordEntry.Text == confirmPasswordEntry.Text)
            {
                //we can register this user
            }
            else
            {
                DisplayAlert("Error", "Passwords don't match", "Ok");
            }
        }

    }
}
