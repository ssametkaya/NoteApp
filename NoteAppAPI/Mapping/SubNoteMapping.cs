using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NoteAppAPI.Models.Entity;

namespace NoteAppAPI.Mapping
{
    public class SubNoteMapping : IEntityTypeConfiguration<SubNote>
    {
        public void Configure(EntityTypeBuilder<SubNote> builder)
        {
            builder.HasData(
               new SubNote { ID = 1, Description = "There are many variations of passages of Lorem Ipsum", IsDeleted = false, Date = DateTime.Now, NoteId = 1 },
               new SubNote { ID = 2, Description = "There are many variations of passages of Lorem Ipsum", IsDeleted = false, Date = DateTime.Now, NoteId = 1 },
               new SubNote { ID = 3, Description = "There are many variations of passages of Lorem Ipsum", IsDeleted = false, Date = DateTime.Now, NoteId = 2 },
               new SubNote { ID = 4, Description = "There are many variations of passages of Lorem Ipsum", IsDeleted = false, Date = DateTime.Now, NoteId = 2 },
               new SubNote { ID = 5, Description = "There are many variations of passages of Lorem Ipsum", IsDeleted = false, Date = DateTime.Now, NoteId = 3 },
               new SubNote { ID = 6, Description = "There are many variations of passages of Lorem Ipsum", IsDeleted = false, Date = DateTime.Now, NoteId = 3 },
               new SubNote { ID = 7, Description = "There are many variations of passages of Lorem Ipsum", IsDeleted = false, Date = DateTime.Now, NoteId = 4 },
               new SubNote { ID = 8, Description = "There are many variations of passages of Lorem Ipsum", IsDeleted = false, Date = DateTime.Now, NoteId = 4 },
               new SubNote { ID = 9, Description = "There are many variations of passages of Lorem Ipsum", IsDeleted = false, Date = DateTime.Now, NoteId = 5 },
               new SubNote { ID = 10, Description = "There are many variations of passages of Lorem Ipsum", IsDeleted = false, Date = DateTime.Now, NoteId = 5 },
               new SubNote { ID = 11, Description = "There are many variations of passages of Lorem Ipsum", IsDeleted = false, Date = DateTime.Now, NoteId = 6 },
               new SubNote { ID = 12, Description = "There are many variations of passages of Lorem Ipsum", IsDeleted = false, Date = DateTime.Now, NoteId = 6 },
               new SubNote { ID = 13, Description = "There are many variations of passages of Lorem Ipsum", IsDeleted = false, Date = DateTime.Now, NoteId = 7 },
               new SubNote { ID = 14, Description = "There are many variations of passages of Lorem Ipsum", IsDeleted = false, Date = DateTime.Now, NoteId = 7 },
               new SubNote { ID = 15, Description = "There are many variations of passages of Lorem Ipsum", IsDeleted = false, Date = DateTime.Now, NoteId = 8 },
               new SubNote { ID = 16, Description = "There are many variations of passages of Lorem Ipsum", IsDeleted = false, Date = DateTime.Now, NoteId = 8 },
               new SubNote { ID = 17, Description = "There are many variations of passages of Lorem Ipsum", IsDeleted = false, Date = DateTime.Now, NoteId = 9 },
               new SubNote { ID = 18, Description = "There are many variations of passages of Lorem Ipsum", IsDeleted = false, Date = DateTime.Now, NoteId = 9 },
               new SubNote { ID = 19, Description = "There are many variations of passages of Lorem Ipsum", IsDeleted = false, Date = DateTime.Now, NoteId = 9 }
               );
        }
    }
}
