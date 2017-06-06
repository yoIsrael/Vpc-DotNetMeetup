using System;
using Xamarin.Forms;

namespace VPCXamarinTraining
{
    public partial class MainPage : ContentPage
    {
        #region Constructor

        public MainPage()
        {
            InitializeComponent();
        }

        #endregion

        #region Events

        private async void btnCalculatorSimple_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pages.CalculatorSimple());
        }

        private async void btnCalculatorReloaded_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pages.CalculatorReloaded());
        }

        private async void btnSoccerTeams_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pages.SoccerTeams());
        }

        #endregion

    }
}
