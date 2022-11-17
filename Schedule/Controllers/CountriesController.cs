using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Schedule.Database;
using Schedule.Domain.Entities;
using Schedule.Dto;

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
        return await _context.Countries.Where(c => c.IsActive).ToListAsync();
    }
    
    [HttpPost]
    public async Task<int> Post([FromBody] AddCountryDto dto)
    {
        var entity = new Country()
        {
            Name = dto.Name,
            IsActive = true,
        };

        _context.Countries.Add(entity);
        await _context.SaveChangesAsync();

        return entity.Id;
    }
    
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] Country dto)
    {
        var country = await _context.Countries.FirstOrDefaultAsync(c => c.Id == id);

        if (country == null) return NotFound($"Country does not exist with id {id}");

        country.Name = dto.Name;
        country.IsActive = dto.IsActive;

        _context.Countries.Update(country);
        await _context.SaveChangesAsync();

        return Ok();
    }
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> Update(int id)
    {
        var country = await _context.Countries.FirstOrDefaultAsync(c => c.Id == id);

        if (country == null) return NotFound($"Country does not exist with id {id}");
        
        //_context.Countries.Remove(country);
        country.IsActive = false;
        _context.Update(country);
        await _context.SaveChangesAsync();

        return Ok();
    }
}