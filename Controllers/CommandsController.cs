using CommandAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly CommandContext _context;

        public CommandsController(CommandContext context)
        {
            _context = context;
        }

        // GET: api/commands
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetCommandItems()
        {
            return _context.CommandItems;
        }
    }
}
