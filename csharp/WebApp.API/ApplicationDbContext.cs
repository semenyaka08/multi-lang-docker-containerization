using Microsoft.EntityFrameworkCore;
using WebApp.API.Models;

namespace WebApp.API;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<TaskNote> TaskNotes { get; set; }
}