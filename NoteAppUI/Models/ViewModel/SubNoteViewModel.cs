using System.ComponentModel.DataAnnotations;

namespace NoteAppUI.Models.ViewModel
{
    public class SubNoteViewModel
    {
        public int Id { get; set; }
        [Required]
        [MinLength(15, ErrorMessage = "En az 15 karakter girilmeli")]
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
        public int NoteID { get; set; }
    }
}
