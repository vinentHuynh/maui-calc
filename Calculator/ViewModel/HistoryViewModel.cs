using System;
using Calculator.Models;
namespace Calculator.ViewModel
{
	public class HistoryViewModel
	{
		private IList<Models.History> historyModel;
		public HistoryViewModel(string equation)
		{
			new History{ historyString=equation};
		}
	}
}

