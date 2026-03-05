using Microsoft.EntityFrameworkCore;
using comp4513_blog_site.Models;

namespace comp4513_blog_site.Data;

public class BlogContext : DbContext
{
    public BlogContext(DbContextOptions<BlogContext> options) : base(options) { }

    public DbSet<Post> Post { get; set; } = default!; // database table
}