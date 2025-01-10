using AtcAntarctic.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AtcAntarctic.Pages.Vehicles;

public class Add : PageModel
{
    public IEnumerable<VehicleType> VehicleTypes { get; set; }
    public void OnGet()
    {
        VehicleTypes = Enum.GetValues<VehicleType>();
    }
}