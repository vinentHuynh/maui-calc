
var builder = WebApplication.CreateBuilder(args);

var message = builder.Configuration["HelloKey"] ?? "Hello";

var app = builder.Build();



//app.MapGet("/", "{\"browsers\":{\"firefox\":{\"name\":\"Firefox\",\"pref_url\":\"about:config\",\"releases\":{\"1\":{\"release_date\":\"2004-11-09\",\"status\":\"retired\",\"engine\":\"Gecko\",\"engine_version\":\"1.7\"}}}}}");


app.MapGet("/search", ArticleMapping);
app.Run();
string ArticleMapping() 
{
    return "{\"1\":{\"correct\":\"2\",\"incorrect1\":\"3\",\"incorrect2\":\"4\",\"equation\":\"1+1\"}}";
}
