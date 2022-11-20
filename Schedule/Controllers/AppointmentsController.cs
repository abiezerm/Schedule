using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Schedule.Database;
using Schedule.Domain.Entities;

namespace Schedule.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AppointmentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Appointment>> Get()
        {
            return await _context.Appointments
                .Include(a => a.TypeDocument)       //Esto hace un join con la tabla city (incluye dicha tabla)
                .Include(b => b.Service) 
                .Include(c => c.StatusMigratory) 
                .Include(d => d.Service)
                .Include(e => e.City) 
                .Where(z => z.IsActive).ToListAsync();
        }

    }
}
