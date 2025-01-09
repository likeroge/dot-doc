using AtcAntarctic.Models;
using AtcAntarctic.Repos;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AtcAntarctic.Pages.TransportNotes;

public class Index : PageModel
{
    private readonly TransportNotesRepo _transportNotesRepo;
    
    public List<TransportNote> TransportNotes;

    public Index(TransportNotesRepo transportNotesRepo)
    {
        _transportNotesRepo = transportNotesRepo;
    }

    public void OnGet()
    {
        TransportNotes = _transportNotesRepo.GetAll().ToList();
    }
}