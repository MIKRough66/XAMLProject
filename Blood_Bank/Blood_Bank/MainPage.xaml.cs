using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Blood_Bank
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            //forMainPageCode

            MainPageCode a = new MainPageCode
            {
                StaffID = 1,
                Title = "Mr",
                FirstName = "Akram",
                LastName = "Khan",
                Gender = "Male",
                Phone = "01701521257",
                Address = "CTG",
                Designation = "Doctor",
                BloodGroup = "A+"
            };
            this.DataContext = a;

            //forButton
            this.confirm.Click += Confirm_Click;
            this.login.Click += Login_Click;
        }

        private async void Login_Click(object sender, RoutedEventArgs e)
        {
            if (username.Text == "Bloodbank" && password.Text == "12345")
            {
                this.Frame.Navigate(typeof(StoreInformation));
            }
            else
            {
                ContentDialog dialog = new ContentDialog()
                {
                    Title = "Error!!!",
                    MaxWidth = this.ActualWidth,
                    Height = this.ActualHeight,
                    PrimaryButtonText = "OK",
                    Content = new TextBlock
                    {
                        Text = "Incorrect Username OR Password!!!",
                        FontSize = 25
                    },
                };
                await dialog.ShowAsync();
            }
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(orInformation));
        }
    }
}
