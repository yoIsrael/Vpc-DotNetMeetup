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

        private string result;

        private string fullOperation;

        private string[] numbers = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };

        private string[] basicOperators = new string[] { "+", "-", "*", "/" };

        private Operation currentOperation;

        private State currentState;

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

        public string Result
        {
            get { return result; }
            set
            {
                result = value;
                OnPropertyChanged();
            }
        }

        public string FullOperation
        {
            get { return fullOperation; }
            set
            {
                if (fullOperation != value)
                {
                    fullOperation = value;
                    OnPropertyChanged();
                }
            }
        }


        #endregion

        #region Contructor

        public CalculatorReloadedViewModel()
        {
            ClearValues();
        }

        #endregion

        #region Commands

        //public ICommand AdditionCommand => new RelayCommand(Addition);

        //public ICommand SubtractionCommand => new RelayCommand(Subtraction);

        //public ICommand MultiplicationCommand => new RelayCommand(Multiplication);

        //public ICommand DivisionCommand => new RelayCommand(Division);

        public ICommand ButtonPressCommand => new RelayCommand<string>(ButtonPress);

        public ICommand OperatorPressedCommand => new RelayCommand<string>(OperatorPressed);

        public ICommand NumberPressCommand => new RelayCommand<string>(NumberPress);

        #endregion

        #region Private Methods

        private void ClearValues()
        {
            FullOperation = string.Empty;
            FirstNumber = 0;
            SecondNumber = 0;
            Result = string.Empty;
            currentOperation = Operation.None;
            currentState = State.FirstNumber;
        }

        private void ButtonPress(string parameter)
        {
            switch (parameter)
            {
                case "+/-":
                    if (currentState == State.FirstNumber)
                    {
                        FirstNumber = FirstNumber * (-1);
                        Result = FirstNumber.ToString();
                    }
                    if (currentState == State.SecondNumber)
                    {
                        SecondNumber = SecondNumber * (-1);
                        Result = SecondNumber.ToString();
                    }
                    break;
                default:
                    ClearValues();
                    break;
            }
        }

        private void OperatorPressed(string parameter)
        {
            if (currentState == State.FirstNumber )
            {
                currentState = State.Operator;
                FullOperation = string.Concat(FullOperation,FirstNumber);
            }
            else if (currentState == State.SecondNumber)
            {
                currentState = State.Result;
                FullOperation = string.Concat(FullOperation, SecondNumber);
            }
            switch (parameter)
            {
                case "+":
                    currentOperation = Operation.Add;
                    FullOperation = string.Concat(FullOperation, parameter);
                    break;
                case "-":
                    currentOperation = Operation.Substract;
                    FullOperation = string.Concat(FullOperation, parameter);
                    break;
                case "/":
                    currentOperation = Operation.Division;
                    FullOperation = string.Concat(FullOperation, parameter);
                    break;
                case "*":
                    currentOperation = Operation.Product;
                    FullOperation = string.Concat(FullOperation, parameter);
                    break;
                default:
                    currentOperation = Operation.None;
                    break;
            }
            
        }

        private void NumberPress(string parameter)
        {
            if (currentState == State.Operator)
            {
                currentState = State.SecondNumber;
            }

            if (currentState == State.FirstNumber)
            {
                FirstNumber = double.Parse(FirstNumber.ToString() + parameter);
                Result = FirstNumber.ToString();
            }
            if (currentState == State.SecondNumber)
            {
                SecondNumber = double.Parse(SecondNumber.ToString() + parameter);
                Result = SecondNumber.ToString();
            }
            //FullOperation = string.Concat(FullOperation, parameter);
        }

        #endregion

    }

    public enum Operation
    {
        Add,
        Substract,
        Product,
        Division,
        None
    }

    public enum State
    {
        FirstNumber,
        Operator,
        SecondNumber,
        Result
    }
}
