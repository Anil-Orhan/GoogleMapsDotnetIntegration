using System.Text.Json;


class Program
{
    static async Task Main()
    {
        // API Key
        string apiKey = "YOUR_API_KEY";
        double latitude = 41.0042353; 
        double longitude = 28.8502218; 

        string address = await GetAddressFromCoordinates(apiKey, latitude, longitude);
        Console.WriteLine("Adress: " + address);
    }

    static async Task<string> GetAddressFromCoordinates(string apiKey, double latitude, double longitude)
    {
        using (var httpClient = new HttpClient())
        {
            string url = $"https://maps.googleapis.com/maps/api/geocode/json?latlng={latitude},{longitude}&key={apiKey}";

            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                using (JsonDocument doc = JsonDocument.Parse(responseBody))
                {
                    if (doc.RootElement.GetProperty("status").GetString() == "OK")
                    {
                        var results = doc.RootElement.GetProperty("results");
                        if (results.GetArrayLength() > 0)
                        {
                            return results[0].GetProperty("formatted_address").GetString();
                        }
                        else
                        {
                            return "Address is not found.";
                        }
                    }
                    else
                    {
                        return "Error: Geocode API did not respond.";
                    }
                }
            }
            catch (HttpRequestException e)
            {
                return "Error: " + e.Message;
            }
        }
    }
}