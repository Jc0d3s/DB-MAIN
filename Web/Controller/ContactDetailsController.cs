using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web.Data;
using Web.Models;

namespace Web.Controllers // This should be your namespace
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactDetailsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ContactDetailsController(AppDbContext context)
        {
            _context = context;
        }

        // PUT: api/contactdetails/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateContactDetail(int id, ContactDetail contactDetail)
        {
            if (id != contactDetail.Id)
            {
                return BadRequest(); // Return 400 if the id doesn't match
            }

            var existingContact = await _context.ContactDetails.FindAsync(id);

            if (existingContact == null || existingContact.IsDeleted == true)
            {
                return NotFound(); // Return 404 if the contact doesn't exist or is deleted
            }

            existingContact.Value = contactDetail.Value;
            existingContact.ModifiedDate = DateTime.UtcNow;
            existingContact.ModifiedBy = contactDetail.ModifiedBy;

            await _context.SaveChangesAsync();
            return NoContent(); // Return 204 to indicate successful update without content
        }
    }
}
