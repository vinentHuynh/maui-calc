using System.Collections.ObjectModel;
using Calculator;
using Calculator.Models;
namespace Calculator;

public partial class HistoryData : ContentPage
{
    HistoryDB database;
    public ObservableCollection<HistoryModel> Items { get; set; } = new();
    public HistoryData(HistoryDB historyDB)
	{
		InitializeComponent();
        database = historyDB;
        BindingContext = this;
    }
    protected override async void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        var items = await database.GetItemsAsync();
        MainThread.BeginInvokeOnMainThread(() =>
        {
            Items.Clear();
            foreach (var item in items)
                Items.Add(item);

        });
    }
    async void OnClear(object sender, EventArgs e)
    {
        await database.DeleteAll();

        // UPDATE PAGE HERE

        //var page = Application.Current.MainPage.Navigation.NavigationStack.LastOrDefault();
        //await Shell.Current.GoToAsync("//HistoryData",true, new Dictionary<string, object>
        //    {
        //    ["Item"] = new HistoryModel()
        //});
        //Navigation.RemovePage(page);

    }
}