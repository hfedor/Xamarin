using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PAIN_Xamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void MtoINClicked(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(editor.Text);
            double result = value * 39.3700787;
            resultlabel.Text = value.ToString() + " m. = " + result.ToString() + " in.";
        }

        void INtoMClicked(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(editor.Text);
            double result = value * 0.0254;
            resultlabel.Text = value.ToString() + " in. = " + result.ToString() + " m.";
        }

        async void CFClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CelciusPage());
        }

        async void KFClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new kgPage());
        }
    }
}
