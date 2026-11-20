using Microsoft.EntityFrameworkCore;

public class day6_ba_thangContext(DbContextOptions<day6_ba_thangContext> options) : DbContext(options)
{
    public DbSet<day6_ba_thang.Models.product> product { get; set; } = default!;
}
