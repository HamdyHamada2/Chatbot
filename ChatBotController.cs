using Microsoft.AspNetCore.Mvc;
using ElectronicProductsAPI.Data;
using ElectronicProductsAPI.Models;
using ElectronicProductsAPI.Services;

namespace ElectronicProductsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatBotController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly ChatBotService _chatBotService;

        public ChatBotController(ApplicationDbContext context, ChatBotService chatBotService)
        {
            _context = context;
            _chatBotService = chatBotService;
        }

        [HttpPost("ask")]
        public IActionResult Ask([FromBody] ChatMessage message)
        {
            var response = _chatBotService.GetResponse(message.Text);
            return Ok(new { response });
        }
    }
}