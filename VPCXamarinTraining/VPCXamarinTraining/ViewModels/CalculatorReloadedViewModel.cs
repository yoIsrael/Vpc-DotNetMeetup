using GalaSoft.MvvmLight.Command;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using VPCXamarinTraining.ViewModels.Base;
using Xamarin.Forms;

namespace VPCXamarinTraining.ViewModels
{
    public class CalculatorReloadedViewModel : ViewModelBase
    {
        #region Atributtes

        private double firstNumber;

        private double secondNumber;

        private string result;

        private string fullOperation;

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

        public ICommand ButtonPressCommand => new RelayCommand<string>(ButtonPress);

        public ICommand OperatorPressedCommand => new RelayCommand<string>(OperatorPressed);

        public ICommand NumberPressCommand => new RelayCommand<string>(NumberPress);

        public ICommand ResultPressCommand => new RelayCommand(ResultPress);

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
            if (currentState == State.FirstNumber)
            {
                currentState = State.Operator;
                FullOperation = string.Concat(FullOperation, FirstNumber);
            }
            else if (currentState == State.SecondNumber)
            {
                FirstNumber = Calculate();
                SecondNumber = 0;
                Result = string.Empty;
                FullOperation = string.Concat(string.Empty, FirstNumber);
            }

            if (basicOperators.Contains(fullOperation.Substring(fullOperation.Length - 1, 1)))
            {
                fullOperation = fullOperation.Remove(fullOperation.Length - 1, 1);
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
        }

        private void ResultPress()
        {
            FullOperation = string.Concat(FullOperation, SecondNumber);

            Result = Calculate().ToString();
        }

        private double Calculate()
        {
            double result = 0;
            switch (currentOperation)
            {
                case Operation.Add:
                    result = FirstNumber + SecondNumber;
                    break;
                case Operation.Substract:
                    result = FirstNumber - SecondNumber;
                    break;
                case Operation.Product:
                    result = FirstNumber * SecondNumber;
                    break;
                case Operation.Division:
                    if (SecondNumber != 0)
                    {
                        result = FirstNumber / SecondNumber;
                    }
                    break;
                default:
                    result = 0;
                    break;
            }
            return result;
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
