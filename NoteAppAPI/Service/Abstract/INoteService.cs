using NoteAppAPI.Models.Entity;
using NoteAppAPI.Models.ViewModel;

namespace NoteAppAPI.Service.Abstract
{
    public interface INoteService
    {
        bool AddNote(NoteViewModel model);
        bool RemoveNote(int id);
        List<NoteViewModel> GetNoteList();
        NoteViewModel GetNoteById(int id);
        bool UpdateNote(int id,NoteViewModel model);
    }
}
