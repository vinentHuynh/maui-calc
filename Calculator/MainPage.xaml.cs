namespace Calculator;
using System.Data;
using Models;

//using Android.Widget;
[QueryProperty("Item", "Item")]
public partial class MainPage : ContentPage
{
    public HistoryViewModel model;

    HistoryModel item;
    public HistoryModel Item
    {
        get => BindingContext as HistoryModel;
        set => BindingContext = value;
    }
    HistoryDB database;
    public MainPage(HistoryViewModel viewModel, HistoryDB history)
    {
        InitializeComponent();
        OnClear(this, null);
        BindingContext = viewModel;
        model = viewModel;
        database= history;
    }


    
  
    void OnSelectNumber(object sender, EventArgs e)
    {
    
        Button button = (Button)sender;
        string pressed = button.Text;

    
    

        this.resultText.Text = pressed;
        this.CurrentCalculation.Text += pressed;


    }

    void OnSelectOperator(object sender, EventArgs e)
    {
        // LockNumberValue(resultText.Text);

        
        Button button = (Button)sender;
        string pressed = button.Text;

        if (pressed == "sqrt")
        {
            pressed += '(';
        }
        this.CurrentCalculation.Text += pressed;
    }

  
    void OnClear(object sender, EventArgs e)
    {

        this.resultText.Text = "0";

        this.CurrentCalculation.Text = string.Empty;
    }

    async void OnCalculate(object sender, EventArgs e)
    {
        

        DataTable dt = new DataTable();
        string expression = this.CurrentCalculation.Text;
        expression = expression.Replace('×', '*');
        expression = expression.Replace('÷', '/');
        expression = expression.Replace("mod", "%");
        
        if(expression.Contains("sqrt"))
        {
            int sqrt = expression.IndexOf("sqrt");
            int endParanth = expression.IndexOf(")");
            string substring = expression.Substring(sqrt + 5, endParanth-(sqrt+5));
            var eval = (int)dt.Compute(substring, "");
            double value = Math.Sqrt(eval);
            
            expression = expression.Remove(sqrt, endParanth-sqrt+1);
            expression = expression.Insert(sqrt, value.ToString());
            this.resultText.Text = dt.Compute(expression, "").ToString();
        }
        
        else
        {
            this.resultText.Text = dt.Compute(expression, "").ToString();
        }

        model.Add(this.CurrentCalculation.Text);
        
        HistoryModel  history = new HistoryModel();
        history.historyString= this.CurrentCalculation.Text;
        Item = history;
        await database.AddEquationAsync(Item);


    }    

    void OnNegative(object sender, EventArgs e)
    {
        this.resultText.Text = (-1*Convert.ToDouble(this.resultText.Text)).ToString();

    }

    void OnPercentage(object sender, EventArgs e)
    {
        double num = Convert.ToDouble(this.resultText.Text);
        num = num / 100;
        this.resultText.Text = num.ToString() + "%";
       

    }




}
