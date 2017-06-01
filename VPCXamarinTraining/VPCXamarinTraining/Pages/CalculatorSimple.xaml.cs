using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VPCXamarinTraining.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalculatorSimple : ContentPage
    {
        #region Atributtes

        private double FirtsNumber;

        private double SecondNumber;

        private double Result;

        #endregion

        #region Constructor

        public CalculatorSimple()
        {
            InitializeComponent();
        }

        #endregion

        #region Events

        private void btnAddition_Clicked(object sender, EventArgs e)
        {
            FirtsNumber = double.Parse(txtFirstNumber.Text);
            SecondNumber = double.Parse(txtSecondNumber.Text);
            Result = FirtsNumber + SecondNumber;
            txtResult.Text = Result.ToString("N0");
        }

        private void btnSubtraction_Clicked(object sender, EventArgs e)
        {
            FirtsNumber = double.Parse(txtFirstNumber.Text);
            SecondNumber = double.Parse(txtSecondNumber.Text);
            Result = FirtsNumber - SecondNumber;
            txtResult.Text = Result.ToString("N0");
        }

        private void btnMultiplication_Clicked(object sender, EventArgs e)
        {
            FirtsNumber = double.Parse(txtFirstNumber.Text);
            SecondNumber = double.Parse(txtSecondNumber.Text);
            Result = FirtsNumber * SecondNumber;
            txtResult.Text = Result.ToString("N0");
        }

        private void btnDivision_Clicked(object sender, EventArgs e)
        {
            FirtsNumber = double.Parse(txtFirstNumber.Text);
            SecondNumber = double.Parse(txtSecondNumber.Text);
            Result = FirtsNumber / SecondNumber;
            txtResult.Text = Result.ToString("N2");
        }

        #endregion
    }
}