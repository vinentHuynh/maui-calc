using SQLite;
using Calculator.Models;
using Microsoft.VisualBasic.FileIO;

public class HistoryDB
{
    SQLiteAsyncConnection Database;
    public const string DatabaseFilename = "HistorySQLite.db3";

    public const SQLite.SQLiteOpenFlags Flags =
        // open the database in read/write mode
        SQLite.SQLiteOpenFlags.ReadWrite |
        // create the database if it doesn't exist
        SQLite.SQLiteOpenFlags.Create |
        // enable multi-threaded database access
        SQLite.SQLiteOpenFlags.SharedCache;

    public static string DatabasePath =>
        Path.Combine(Microsoft.Maui.Storage.FileSystem.AppDataDirectory, DatabaseFilename);
    public HistoryDB()
    {
    }
    async Task Init()
    {
        if (Database is not null)
            return;
       
        Database = new SQLiteAsyncConnection(DatabasePath, Flags);
        var result = await Database.CreateTableAsync<HistoryModel>();
    }

    public async Task<List<HistoryModel>> GetItemsAsync()
    {
        await Init();
        return await Database.Table<HistoryModel>().ToListAsync();
    }

    public async Task<int> AddEquationAsync(HistoryModel model)
    {
        await Init();
        return await Database.InsertAsync(model);
    }
    public async Task<int> DeleteAll()
    {
        await Init();
        return await Database.DeleteAllAsync<HistoryModel>();
    }


}


