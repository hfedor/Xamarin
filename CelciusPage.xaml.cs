using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PAIN_Xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CelciusPage : ContentPage
    {
        public CelciusPage()
        {
            InitializeComponent();
        }

        void CtoFClicked(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(editor.Text);
            double result = value * 9 / 5 + 32;
            resultlabel.Text = value.ToString() + " °C = " + result.ToString() + " °F";
        }

        void FtoCClicked(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(editor.Text);
            double result = (value -32) * 5 / 9;
            resultlabel.Text = value.ToString() + " °F = " + result.ToString() + " °C";
        }

        async void MINClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        async void KFClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new kgPage());
        }
    }
}