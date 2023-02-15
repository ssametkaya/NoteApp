using System.ComponentModel.DataAnnotations;

namespace NoteAppAPI.Models.Entity
{
    public class Note
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(20,ErrorMessage ="En fazla 20 karakter girilebilir")]
        public string Title { get; set; }

        [MinLength(15, ErrorMessage = "En az 15 karakter girilmeli")]
        public string Description { get; set; }

        public DateTime Date { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<SubNote> SubNotes { get; set; }
    }
}
