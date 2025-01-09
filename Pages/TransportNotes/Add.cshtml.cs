using AtcAntarctic.Models;
using AtcAntarctic.Repos;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AtcAntarctic.Pages.TransportNotes;

public class Add : PageModel
{
    // private readonly IHttpClientFactory _httpClientFactory;
    private readonly VehicleRepo _vehicleRepo;
    private readonly PlacesRepo _placesRepo;

    public Add(VehicleRepo vehicleRepo, PlacesRepo placesRepo)
    {
        _vehicleRepo = vehicleRepo;
        _placesRepo = placesRepo;
    }
    public List<Vehicle> Vehicles { get; set; }
    public List<Place> Places { get; set; }
    
    public void OnGet()
    {
        Vehicles = _vehicleRepo.GetAll().ToList();
        Places = _placesRepo.GetAll().ToList();
    }
}