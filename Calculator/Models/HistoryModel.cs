using SQLite;
namespace Calculator.Models
{
	[Table("history")]
	public class HistoryModel
	{
		[PrimaryKey, AutoIncrement,Column("_id")]
		public int Id { get; set; }
		public string historyString { get;set; }

	}
}

