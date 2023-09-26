using pr7Wpf.Models;
using pr7Wpf.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace pr7Wpf.ViewModels
{

    public class MainViewModel : INotifyPropertyChanged
    {
            private CalculatorModel calculator = new CalculatorModel();
            private double operand1;
            private double operand2;
            private string operatorSymbol;
            private double result;

            public double Operand1
            {
                get { return operand1; }
                set
                {
                    operand1 = value;
                    OnPropertyChanged();
                }
            }

            public double Operand2
            {
                get { return operand2; }
                set
                {
                    operand2 = value;
                    OnPropertyChanged();
                }
            }

            public string OperatorSymbol
            {
                get { return operatorSymbol; }
                set
                {
                    operatorSymbol = value;
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

            public event PropertyChangedEventHandler PropertyChanged;

            protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }

            public void Calculate()
            {
                try
                {
                    switch (OperatorSymbol)
                    {
                        case "+":
                            Result = calculator.Add(Operand1, Operand2);
                            break;
                        case "-":
                            Result = calculator.Subtract(Operand1, Operand2);
                            break;
                        case "*":
                            Result = calculator.Multiply(Operand1, Operand2);
                            break;
                        case "/":
                            Result = calculator.Divide(Operand1, Operand2);
                            break;
                        default:
                            throw new InvalidOperationException("Неверный оператор");
                    }
                }
                catch (DivideByZeroException ex)
                {
                    Result = double.NaN; 
                }
            }
        }
    }
