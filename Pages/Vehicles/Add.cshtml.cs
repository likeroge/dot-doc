using AtcAntarctic.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AtcAntarctic.Pages.Vehicles;

public class Add : PageModel
{
    public List<VehicleType> VehicleTypes;
    public void OnGet()
    {
        VehicleTypes= Enum.GetValues(typeof(VehicleType)).OfType<VehicleType>().ToList();
    }
}