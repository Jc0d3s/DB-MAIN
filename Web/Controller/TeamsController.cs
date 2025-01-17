using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web.Models;
using Web.Data;

namespace Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeamController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TeamController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/team
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Team>>> GetTeam()
        {
            return await _context.Teams.ToListAsync();
        }

        // GET: api/team/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Team>> GetTeamMember(int id)
        {
            var teamMember = await _context.Teams.FindAsync(id);

            if (teamMember == null)
            {
                return NotFound();
            }

            return teamMember;
        }

        // POST: api/team
        [HttpPost]
        public async Task<ActionResult<Team>> CreateTeamMember(Team team)
        {
            team.CreatedDate = DateTime.UtcNow;
            _context.Teams.Add(team);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTeamMember), new { id = team.Id }, team);
        }

        // PUT: api/team/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTeamMember(int id, Team team)
        {
            if (id != team.Id)
            {
                return BadRequest();
            }

            var existingTeamMember = await _context.Teams.FindAsync(id);

            if (existingTeamMember == null)
            {
                return NotFound();
            }

            existingTeamMember.Name = team.Name;
            existingTeamMember.Role = team.Role;
            existingTeamMember.CreatedDate = DateTime.UtcNow;

            await _context.SaveChangesAsync();
            return NoContent();
        }

        // DELETE: api/team/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTeamMember(int id)
        {
            var teamMember = await _context.Teams.FindAsync(id);

            if (teamMember == null)
            {
                return NotFound();
            }

            _context.Teams.Remove(teamMember);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
