using NoteAppAPI.Models.Entity;
using NoteAppAPI.Models.ViewModel;

namespace NoteAppAPI.Service.Abstract
{
    public interface ISubNoteService
    {
        bool AddSubNote(SubNoteViewModel model,int id);
        bool RemoveSubNote(int id);
        List<SubNoteViewModel> GetSubNotes(int id);
        SubNoteViewModel GetSubNoteById(int id);
    }
}
