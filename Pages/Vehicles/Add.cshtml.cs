using AtcAntarctic.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AtcAntarctic.Pages.Vehicles;

public class Add : PageModel
{
    // private readonly IConfiguration _configuration;
    
    // public string ApiUrl { get; set; }
    public List<VehicleType> VehicleTypes;

    // public Add(IConfiguration configuration)
    // {
    //     _configuration = configuration;
    // }

    public void OnGet()
    {
         // ApiUrl = _configuration["BaseUrl"];
        VehicleTypes= Enum.GetValues(typeof(VehicleType)).OfType<VehicleType>().ToList();
    }
}