using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json.Linq;

namespace Calculator
{
    public class GetAPI
    {
        public async Task<ExercisesData> GetData(int id)
        {
            ExercisesData data = new ExercisesData();
             var client = new HttpClient();

           
                string url = "http://localhost:5009/" + id;
                
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                
                
                var content = await response.Content.ReadAsStringAsync();
                
                data = JsonSerializer.Deserialize<ExercisesData>(content);
                return data;
            
            
        }
    }
}

