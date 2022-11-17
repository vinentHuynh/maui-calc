namespace Calculator;

public partial class History : ContentPage
{
	public History(HistoryViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
