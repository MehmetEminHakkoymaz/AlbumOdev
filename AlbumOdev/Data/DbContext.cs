using AlbumOdev.Models;
using Microsoft.EntityFrameworkCore;

namespace AlbumOdev.Data {
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<MAlbum> Album { get; set; }
        // Diğer DbSet'ler buraya eklenebilir
    }
}
