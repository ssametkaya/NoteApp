namespace NoteAppAPI.Models.ViewModel
{
    public class SubNoteViewModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
        public int NoteID { get; set; }
    }
}
