using AtcAntarctic.Models;
using AtcAntarctic.Repos;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AtcAntarctic.Pages.Vehicles;

public class Index : PageModel
{
    private readonly VehicleRepo _vehicleRepo;
    
    public IEnumerable<Vehicle> Vehicles { get; set; }

    public Index(VehicleRepo repo)
    {
        _vehicleRepo = repo;
    }

    public async void OnGet()
    {
        Vehicles = await _vehicleRepo.GetAll();
    }
}