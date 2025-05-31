using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.API.Models;

namespace WebApp.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TaskNotesController(ApplicationDbContext context) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetTasks()
    {
        var taskNotes = await context.TaskNotes.ToListAsync();
        
        return Ok(taskNotes);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetTask(int id)
    {
        var taskNote = await context.TaskNotes.FirstOrDefaultAsync(t => t.Id == id);
        
        if (taskNote == null)
        {
            return NotFound();
        }
        
        return Ok(taskNote);
    }
    
    [HttpPost]
    public async Task<IActionResult> CreateTask([FromBody] TaskNote taskNote)
    {
        await context.TaskNotes.AddAsync(taskNote);
        
        await context.SaveChangesAsync();
        
        return CreatedAtAction(nameof(GetTask), new { id = taskNote.Id }, taskNote);
    }
}