using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Schedule.Database;
using Schedule.Domain.Entities;

namespace Schedule.Controllers;

[ApiController]
[Route("[controller]")]
public class CountriesController : Controller
{
    private readonly ApplicationDbContext _context;

    public CountriesController(ApplicationDbContext context)
    {
        _context = context;
    }
    
    [HttpGet]
    public async Task<IEnumerable<Country>> Get()
    {
        return await _context.Countries.ToListAsync();
    }
}