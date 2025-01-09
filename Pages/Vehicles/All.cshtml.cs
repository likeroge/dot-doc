using AtcAntarctic.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AtcAntarctic.Pages.Vehicles;

public class All : PageModel
{
    private readonly IHttpClientFactory _httpClientFactory;

    public List<Vehicle>? Vehicles { get; set; }
    
    public All(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    /// <summary>
    /// OnGet is called when the page is loaded.
    /// This method will get all the vehicles from the API and store them in the Vehicles property.
    /// </summary>
    public void OnGet()
    {
        Vehicles = new List<Vehicle>();
        var httpCLient = _httpClientFactory.CreateClient("MyApiClient");
        var httpResponseMessage = httpCLient.GetAsync("api/Vehicle").Result;
        Vehicles = httpResponseMessage.Content.ReadFromJsonAsync<List<Vehicle>>().Result;
    }
}