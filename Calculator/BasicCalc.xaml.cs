//using Java.Sql;
namespace Calculator;
using System.Data;

public partial class BasicCalc : ContentPage
{

    public BasicCalc()
    {
        InitializeComponent();
        OnClear(this, null);

    }

    string currentEntry = "";

    string mathOperator;

    string decimalFormat = "N0";



    void OnSelectNumber(object sender, EventArgs e)
    {

        Button button = (Button)sender;
        string pressed = button.Text;

        currentEntry = pressed;

        //if ((this.resultText.Text == "0" && pressed == "0")
        //    || (currentEntry.Length <= 1 && pressed != "0")
        //    || currentState < 0)
        //{
        //    this.resultText.Text = "";
        //    if (currentState < 0)
        //        currentState *= -1;
        //}

        //if (pressed == "." && decimalFormat != "N2")
        //{
        //    decimalFormat = "N2";
        //}

        this.resultText.Text = pressed;
        this.CurrentCalculation.Text += pressed;


    }

    void OnSelectOperator(object sender, EventArgs e)
    {
        // LockNumberValue(resultText.Text);


        Button button = (Button)sender;
        string pressed = button.Text;
        mathOperator = pressed;
        this.CurrentCalculation.Text += mathOperator;
    }

    //private void LockNumberValue(string text)
    //{
    //    double number;
    //    if (double.TryParse(text, out number))
    //    {
    //        if (currentState == 1)
    //        {
    //            firstNumber = number;
    //        }
    //        else
    //        {
    //            secondNumber = number;
    //        }

    //        currentEntry = string.Empty;
    //    }
    //}

    void OnClear(object sender, EventArgs e)
    {
        //firstNumber = 0;
        //secondNumber = 0;
        //currentState = 1;
        decimalFormat = "N0";
        this.resultText.Text = "0";
        currentEntry = string.Empty;
        this.CurrentCalculation.Text = string.Empty;
    }

    void OnCalculate(object sender, EventArgs e)
    {

        //LockNumberValue(resultText.Text);
        DataTable dt = new DataTable();

        // double result = Calculator.Calculate(firstNumber, secondNumber, mathOperator);

        // this.CurrentCalculation.Text = $"{firstNumber} {mathOperator} {secondNumber}";

        // this.resultText.Text = result.ToTrimmedString(decimalFormat);
        // firstNumber = result;
        // secondNumber = 0;
        //currentState = -1;
        string expression = this.CurrentCalculation.Text;
        expression = expression.Replace('×', '*');
        expression = expression.Replace('÷', '/');

        var result = (int)dt.Compute(expression, "");

        this.resultText.Text = result.ToString();
        currentEntry = string.Empty;

    }

    void OnNegative(object sender, EventArgs e)
    {
        //if (currentState == 1)
        //{
        //    secondNumber = -1;
        //    mathOperator = "×";
        //    currentState = 2;
        //    // OnCalculate(this, null);
        //}
    }

    void OnPercentage(object sender, EventArgs e)
    {
        //if (currentState == 1)
        //{
        //    LockNumberValue(resultText.Text);
        //    decimalFormat = "N2";
        //    secondNumber = 0.01;
        //    mathOperator = "×";
        //    currentState = 2;
        //    OnCalculate(this, null);
        //}
    }
}