using Domain;
using Persistance;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class ActivitiesController : BaseController
    {
        private readonly DataContext _context;
        
        public ActivitiesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivities()
        {
            try
            {
                return await _context.Activities.ToListAsync();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error: " + ex.Message); 
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> GetActivity(Guid id)
        {
            return await _context.Activities.FindAsync(id);
        }
    }
}