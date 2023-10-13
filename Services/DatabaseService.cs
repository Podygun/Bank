using System.Text.Json;
using System.Text.Json.Serialization;

namespace BankTest.Services;

public class DatabaseService
{
    private readonly string apiUrl = "https://wryty.ru/api.php";

    public async Task<string> GetJsonResponse()
    {
        using (HttpClient httpClient = new HttpClient())
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string jsonContent = await response.Content.ReadAsStringAsync();
                    return jsonContent;
                }
                else
                {
                    Console.WriteLine($"Ошибка HTTP: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }

            return null;
        }
    }
}
