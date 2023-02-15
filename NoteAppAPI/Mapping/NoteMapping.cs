using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NoteAppAPI.Models.Entity;

namespace NoteAppAPI.Mapping
{
    public class NoteMapping : IEntityTypeConfiguration<Note>
    {
        public void Configure(EntityTypeBuilder<Note> builder)
        {

            builder.HasData(
               new Note { ID = 1, Title = "Spor", Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", IsDeleted = false, Date = DateTime.Now },
               new Note { ID = 2, Title = "Online", Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", IsDeleted = false, Date = DateTime.Now },
               new Note { ID = 3, Title = "Sinema", Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", IsDeleted = false, Date = DateTime.Now },
               new Note { ID = 4, Title = "Müzik", Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", IsDeleted = false, Date = DateTime.Now },
               new Note { ID = 5, Title = "Cuma", Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", IsDeleted = false, Date = DateTime.Now },
               new Note { ID = 6, Title = "Perşembe", Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", IsDeleted = false, Date = DateTime.Now },
               new Note { ID = 7, Title = "Çarşamba", Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", IsDeleted = false, Date = DateTime.Now },
               new Note { ID = 8, Title = "Salı", Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", IsDeleted = false, Date = DateTime.Now },
               new Note { ID = 9, Title = "Pazartesi", Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", IsDeleted = false, Date = DateTime.Now }
               );
        }
    }
}
