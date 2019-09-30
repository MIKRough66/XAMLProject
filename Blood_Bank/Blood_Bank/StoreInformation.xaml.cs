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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Blood_Bank
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class StoreInformation : Page
    {
        public StoreInformation()
        {
            //ForStorageInfo
            StorageInformationCode si = new StorageInformationCode
            {
                EntryID = 1,
                DonorID = 1,
                BloodGroup = "A+",
                Quantity = 2,
                StoreDate = "12/05/2018",
                ExpireDate = "11/09/2018",
                Remarks = "OK"
            };
            this.DataContext = si;


            //forConfarmButton
            this.InitializeComponent();
            this.comfarm2.Click += Comfarm2_Click1;
        }

        private void Comfarm2_Click1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(FinalPage));
        }

        private void Comfarm2_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
