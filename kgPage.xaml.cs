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
    public partial class kgPage : ContentPage
    {
        public kgPage()
        {
            InitializeComponent();
        }

        void KtoFClicked(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(editor.Text);
            double result = value * 9 / 5 + 32;
            resultlabel.Text = value.ToString() + " kg. = " + result.ToString() + " lb.";
        }

        void FtoKClicked(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(editor.Text);
            double result = (value - 32) * 5 / 9;
            resultlabel.Text = value.ToString() + " lb. = " + result.ToString() + " kg.";
        }

        async void CFClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CelciusPage());
        }

        async void MINClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}