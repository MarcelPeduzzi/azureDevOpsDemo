using System.Windows;
using System.Windows.Controls;

namespace Calculator;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private double _firstNumber = 0;
    private double _secondNumber = 0;
    private string _operation = "";
    private bool _isOperationPerformed = false;

    public MainWindow()
    {
        InitializeComponent();
    }

    private void NumberButton_Click(object sender, RoutedEventArgs e)
    {
        if (sender is Button button)
        {
            string number = button.Content.ToString() ?? "";
            
            if (_isOperationPerformed || DisplayTextBox.Text == "0")
            {
                DisplayTextBox.Text = number;
                _isOperationPerformed = false;
            }
            else
            {
                DisplayTextBox.Text += number;
            }
        }
    }

    private void DecimalButton_Click(object sender, RoutedEventArgs e)
    {
        if (_isOperationPerformed)
        {
            DisplayTextBox.Text = "0.";
            _isOperationPerformed = false;
        }
        else if (!DisplayTextBox.Text.Contains("."))
        {
            DisplayTextBox.Text += ".";
        }
    }

    private void OperationButton_Click(object sender, RoutedEventArgs e)
    {
        if (sender is Button button)
        {
            string buttonContent = button.Content.ToString() ?? "";
            
            if (double.TryParse(DisplayTextBox.Text, out double currentNumber))
            {
                if (_operation != "" && !_isOperationPerformed)
                {
                    // Perform the previous operation first
                    PerformCalculation();
                }
                else
                {
                    _firstNumber = currentNumber;
                }

                // Map the button content to the operation
                _operation = buttonContent switch
                {
                    "+" => "+",
                    "-" => "-",
                    "×" => "*",
                    "÷" => "/",
                    _ => ""
                };

                _isOperationPerformed = true;
            }
        }
    }

    private void EqualsButton_Click(object sender, RoutedEventArgs e)
    {
        PerformCalculation();
        _operation = "";
    }

    private void PerformCalculation()
    {
        if (double.TryParse(DisplayTextBox.Text, out double currentNumber))
        {
            _secondNumber = currentNumber;
            double result = 0;

            switch (_operation)
            {
                case "+":
                    result = _firstNumber + _secondNumber;
                    break;
                case "-":
                    result = _firstNumber - _secondNumber;
                    break;
                case "*":
                    result = _firstNumber * _secondNumber;
                    break;
                case "/":
                    if (_secondNumber != 0)
                    {
                        result = _firstNumber / _secondNumber;
                    }
                    else
                    {
                        DisplayTextBox.Text = "Fehler";
                        _operation = "";
                        _isOperationPerformed = true;
                        return;
                    }
                    break;
            }

            DisplayTextBox.Text = result.ToString();
            _firstNumber = result;
            _isOperationPerformed = true;
        }
    }

    private void ClearButton_Click(object sender, RoutedEventArgs e)
    {
        DisplayTextBox.Text = "0";
        _firstNumber = 0;
        _secondNumber = 0;
        _operation = "";
        _isOperationPerformed = false;
    }
}