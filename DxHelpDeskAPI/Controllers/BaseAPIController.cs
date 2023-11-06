using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DxHelpDeskAPI.ViewModels;
using DxHelpDeskModelCreator.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace DxHelpDeskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseApiController<T> : ControllerBase where T : class
    {
        private readonly DxHelpDeskDBContext _context;

        public BaseApiController(DxHelpDeskDBContext context)
        {
            _context = context;
        }

        // Generic CRUD methods will go here
        [HttpGet]
        public async Task<ActionResult<IEnumerable<T>>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<T>> GetById(int id)
        {
            var item = await _context.Set<T>().FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }
        #region create
        [HttpPost]
        public async Task<ActionResult<T>> Create(T item)
        {
            _context.Set<T>().Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetById", new { id = GetEntityId(item) }, item);
        }
        #endregion

        private int GetEntityId(T item)
        {
            // Implement logic to retrieve ID from the item
            return int.Parse(item.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _context.Set<T>().FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }

            _context.Set<T>().Remove(item);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, T item)
        {
            if (id != GetEntityId(item))
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EntityExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        private bool EntityExists(int id)
        {
            // Implement logic to check if the entity exists
            
            return true; 
        }


    }

}
