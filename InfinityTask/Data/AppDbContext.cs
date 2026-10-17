using InfinityTask.Models;
using Microsoft.EntityFrameworkCore;

namespace InfinityTask.Data;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Question> Questions { get; set; } = null!;
    public DbSet<Topic> Topics { get; set; } = null!;
    public DbSet<Attempt> Attempts { get; set; } = null!;
    
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
}