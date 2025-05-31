using WebApp.API.Models;

namespace WebApp.API.DataSeeder;

public class DataSeeder(ApplicationDbContext dbContext) : IDataSeeder
{
    public async Task SeedDataAsync()
    {
        if (dbContext.TaskNotes.Any())
        {
            return;
        }
        
        var taskNotes = new List<TaskNote>
        {
            new() { Title = "Task 1", Description = "Description for Task 1" },
            new() { Title = "Task 2", Description = "Description for Task 2" },
            new() { Title = "Task 3", Description = "Description for Task 3" }
        };
        
        await dbContext.TaskNotes.AddRangeAsync(taskNotes);
        
        await dbContext.SaveChangesAsync();
    }
}