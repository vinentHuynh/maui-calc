
var builder = WebApplication.CreateBuilder(args);



var app = builder.Build();


app.MapGet("/1", exercise1);
app.MapGet("/2", exercise2);
app.MapGet("/3", exercise3);
app.MapGet("/4", exercise4);
app.MapGet("/5", exercise5);
app.MapGet("/6", exercise6);
app.MapGet("/7", exercise7);
app.MapGet("/8", exercise8);
app.MapGet("/9", exercise9);
app.MapGet("/10", exercise10);
app.Run();
string exercise1() 
{
    return "{\"correct\":\"2\",\"incorrect1\":\"3\",\"incorrect2\":\"4\",\"equation\":\"1+1\"}";
}
string exercise2() 
{
    return "{\"correct\":\"34\",\"incorrect1\":\"90\",\"incorrect2\":\"23\",\"equation\":\"12+22\"}";
}
string exercise3() 
{
    return "{\"correct\":\"23\",\"incorrect1\":\"33\",\"incorrect2\":\"48\",\"equation\":\"11+12\"}";
}
string exercise4() 
{
    return "{\"correct\":\"98\",\"incorrect1\":\"89\",\"incorrect2\":\"88\",\"equation\":\"20+78\"}";
}
string exercise5() 
{
    return "{\"correct\":\"121\",\"incorrect1\":\"125\",\"incorrect2\":\"111\",\"equation\":\"11*12\"}";
}
string exercise6() 
{
    return "{\"correct\":\"532\",\"incorrect1\":\"397\",\"incorrect2\":\"432\",\"equation\":\"874-342\"}";
}
string exercise7() 
{
    return "{\"correct\":\"54\",\"incorrect1\":\"65\",\"incorrect2\":\"43\",\"equation\":\"19+35\"}";
}
string exercise8() 
{
    return "{\"correct\":\"335\",\"incorrect1\":\"235\",\"incorrect2\":\"530\",\"equation\":\"87*5\"}";
}
string exercise9() 
{
    return "{\"correct\":\"101\",\"incorrect1\":\"120\",\"incorrect2\":\"98\",\"equation\":\"89+12\"}";
}
string exercise10() 
{
    return "{\"correct\":\"0\",\"incorrect1\":\"2\",\"incorrect2\":\"1\",\"equation\":\"1-1\"}";
}