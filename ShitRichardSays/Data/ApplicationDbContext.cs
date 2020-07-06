using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace ShitRichardSays.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Recording> Recordings { get; set; }

        public async Task<List<Recording>> GetRecordings()
        {
            return await Recordings.FromSqlRaw("SELECT ID,Title,AudioFile FROM Recordings;").ToListAsync();
            
        }
    }
}
