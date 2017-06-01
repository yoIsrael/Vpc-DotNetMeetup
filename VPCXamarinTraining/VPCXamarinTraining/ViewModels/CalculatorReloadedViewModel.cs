using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using VPCXamarinTraining.ViewModels.Base;

namespace VPCXamarinTraining.ViewModels
{
    public class CalculatorReloadedViewModel : ViewModelBase
    {
        #region Atributtes

        private double firstNumber;

        private double secondNumber;

        private double result;

        #endregion

        #region Properties

        public double FirstNumber
        {
            get { return firstNumber; }
            set
            {
                firstNumber = value;
                OnPropertyChanged();
            }
        }

        public double SecondNumber
        {
            get { return secondNumber; }
            set
            {
                secondNumber = value;
                OnPropertyChanged();
            }
        }

        public double Result
        {
            get { return result; }
            set
            {
                result = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region Commands

        public ICommand AdditionCommand => new RelayCommand(Addition);

        public ICommand SubtractionCommand => new RelayCommand(Subtraction);

        public ICommand MultiplicationCommand => new RelayCommand(Multiplication);

        public ICommand DivisionCommand => new RelayCommand(Division);

        #endregion

        #region Private Methods

        private void Addition()
        {
            Result = FirstNumber + SecondNumber;
        }

        private void Subtraction()
        {
            Result = FirstNumber - SecondNumber;
        }

        private void Multiplication()
        {
            Result = FirstNumber * SecondNumber;
        }

        private void Division()
        {
            Result = FirstNumber / SecondNumber;
        }

        #endregion
        
    }
}
