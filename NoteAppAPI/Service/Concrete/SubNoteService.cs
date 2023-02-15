using Microsoft.EntityFrameworkCore;
using NoteAppAPI.Context;
using NoteAppAPI.Models.Entity;
using NoteAppAPI.Models.ViewModel;
using NoteAppAPI.Service.Abstract;

namespace NoteAppAPI.Service.Concrete
{
    public class SubNoteService : ISubNoteService
    {
        private readonly NoteAppContext _noteContext;
        public SubNoteService(NoteAppContext noteContext)
        {
            _noteContext = noteContext;
        }

        public bool AddSubNote(SubNoteViewModel model,int id)
        {
            SubNote subNote = null;

            if (model != null)
            {
                subNote = new SubNote();
                subNote.Description = model.Description;
                subNote.Date = DateTime.Now;
                subNote.IsDeleted = false;
                subNote.NoteId = id;
                _noteContext.Add(subNote);
                _noteContext.SaveChanges();

                return true;
            }

            return false;

        }

        public SubNoteViewModel GetSubNoteById(int id)
        {
            throw new NotImplementedException();
        }

        public List<SubNoteViewModel> GetSubNotes(int id)
        {
            return _noteContext.SubNotes.Include(x=>x.Note).Select(x => new SubNoteViewModel()
            {
                Id = x.ID,
                Description = x.Description,
                CreatedDate = x.Date,
                IsDeleted = x.IsDeleted,
                NoteID=x.Note.ID
            }).Where(x=>x.NoteID==id).ToList();
        }

        public bool RemoveSubNote(int id)
        {
            SubNote value = _noteContext.SubNotes.Find(id);

            if (value != null)
            {
                value.IsDeleted = true;
                _noteContext.SaveChanges();
                return true;
            }

            return false;
        }
    }
}
