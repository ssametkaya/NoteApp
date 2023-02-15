using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using NoteAppAPI.Mapping;
using NoteAppAPI.Models.Entity;

namespace NoteAppAPI.Context
{
    public class NoteAppContext : DbContext
    {
        public NoteAppContext(DbContextOptions<NoteAppContext> options) : base(options)
        {

        }
        public DbSet<Note> Notes { get; set; }
        public DbSet<SubNote> SubNotes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new NoteMapping());
            builder.ApplyConfiguration(new SubNoteMapping());
            
        }
    }
}
