using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App_CV;

namespace App_CV
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnCV1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageCV());
        }
    }
}
