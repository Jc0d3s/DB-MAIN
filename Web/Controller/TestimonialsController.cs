using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web.Models;
using Web.Data;

namespace Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestimonialsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TestimonialsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/testimonials
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Testimonial>>> GetTestimonials()
        {
            return await _context.Testimonials.Where(t => t.IsDeleted != true).ToListAsync();
        }

        // GET: api/testimonials/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Testimonial>> GetTestimonial(int id)
        {
            var testimonial = await _context.Testimonials.FindAsync(id);

            if (testimonial == null || testimonial.IsDeleted == true)
            {
                return NotFound();
            }

            return testimonial;
        }

        // POST: api/testimonials
        [HttpPost]
        public async Task<ActionResult<Testimonial>> CreateTestimonial(Testimonial testimonial)
        {
            testimonial.CreatedDate = DateTime.UtcNow;
            _context.Testimonials.Add(testimonial);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTestimonial), new { id = testimonial.Id }, testimonial);
        }

        // PUT: api/testimonials/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTestimonial(int id, Testimonial testimonial)
        {
            if (id != testimonial.Id)
            {
                return BadRequest();
            }

            var existingTestimonial = await _context.Testimonials.FindAsync(id);

            if (existingTestimonial == null || existingTestimonial.IsDeleted == true)
            {
                return NotFound();
            }

            existingTestimonial.Name = testimonial.Name;
            existingTestimonial.Position = testimonial.Position;
            existingTestimonial.Quote = testimonial.Quote;
            existingTestimonial.Image = testimonial.Image;
            existingTestimonial.ModifiedDate = DateTime.UtcNow;
            existingTestimonial.ModifiedBy = testimonial.ModifiedBy;

            await _context.SaveChangesAsync();
            return NoContent();
        }

        // DELETE: api/testimonials/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTestimonial(int id)
        {
            var testimonial = await _context.Testimonials.FindAsync(id);

            if (testimonial == null || testimonial.IsDeleted == true)
            {
                return NotFound();
            }

            testimonial.IsDeleted = true;
            testimonial.DeletedDate = DateTime.UtcNow;
            testimonial.DeletedBy = "System"; // Modify as per your requirement

            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
