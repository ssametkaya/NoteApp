using System.ComponentModel.DataAnnotations;

namespace NoteAppAPI.Models.Entity
{
    public class SubNote
    {
        [Key]
        public int ID { get; set; }
        [MinLength(15, ErrorMessage = "En az 15 karakter girilmeli")]
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public bool IsDeleted { get; set; }
        public int NoteId { get; set; }
        public Note Note { get; set; }
    }
}
