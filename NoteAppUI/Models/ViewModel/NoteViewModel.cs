using System.ComponentModel.DataAnnotations;

namespace NoteAppUI.Models.ViewModel
{
    public class NoteViewModel
    {
        public int Id { get; set; }
        [MaxLength(20, ErrorMessage = "En fazla 20 karakter girilebilir")]
        public string Title { get; set; }
        [MinLength(15, ErrorMessage = "En az 15 karakter girilmeli")]
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
