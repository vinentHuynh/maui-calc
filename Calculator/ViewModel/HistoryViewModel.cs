using System;
using System.ComponentModel;
using Calculator.Models;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace Calculator
{
	public class HistoryViewModel: INotifyPropertyChanged
	{
        readonly IList<HistoryModel> source;
        HistoryModel equation ;
        public HistoryModel Equation
        {
            get
            {
                return equation;
            }
            set
            {
                if(equation !=value)
                {
                    equation = value;
                }
            }
        }
        public ObservableCollection<HistoryModel> Equations{ get; private set; }
        public HistoryViewModel()
        {
            source = new List<HistoryModel>();
            

            //SelectedMonkey = Monkeys.Skip(3).FirstOrDefault();
            OnPropertyChanged("SelectedMonkey");


        }
        public void Add(string eq)
        {
            source.Add(new HistoryModel { historyString = eq });
            Equations = new ObservableCollection<HistoryModel>(source);
        }
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

