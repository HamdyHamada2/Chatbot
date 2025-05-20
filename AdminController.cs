using Microsoft.AspNetCore.Mvc;
using ElectronicProductsAPI.Data;
using ElectronicProductsAPI.Models;

namespace ElectronicProductsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("add-knowledge")]
        public IActionResult AddKnowledge([FromBody] KnowledgeEntry entry)
        {
            _context.KnowledgeEntries.Add(entry);
            _context.SaveChanges();
            return Ok(entry);
        }
    }
}