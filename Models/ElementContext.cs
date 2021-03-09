using Microsoft.EntityFrameworkCore;

namespace Gallery.Models
{
    public class ElementContext : DbContext
    {
        public TodoContext(DbContextOptions<ElementContext> options)
            : base(options)
        {
        }

        public DbSet<Element> Elements { get; set; }
    }
}