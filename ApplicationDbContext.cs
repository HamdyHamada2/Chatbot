using Microsoft.EntityFrameworkCore;
using ElectronicProductsAPI.Models;

namespace ElectronicProductsAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<ChatMessage> ChatMessages { get; set; }
        public DbSet<KnowledgeEntry> KnowledgeEntries { get; set; }
    }
}