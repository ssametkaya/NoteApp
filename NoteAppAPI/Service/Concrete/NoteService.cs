using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using NoteAppAPI.Context;
using NoteAppAPI.Models.Entity;
using NoteAppAPI.Models.ViewModel;
using NoteAppAPI.Service.Abstract;

namespace NoteAppAPI.Service.Concrete
{
    public class NoteService : INoteService
    {
        private readonly NoteAppContext _noteContext;
        public NoteService(NoteAppContext noteContext)
        {
            _noteContext = noteContext;
        }

        public bool AddNote(NoteViewModel model)
        {
            Note note = null;

            if (model != null)
            {
                note = new Note();
                note.Title = model.Title;
                note.Description = model.Description;
                note.Date = DateTime.Now;
                note.IsDeleted = false;

                _noteContext.Notes.Add(note);
                _noteContext.SaveChanges();

                return true;
            }

            return false;
        }

        public NoteViewModel GetNoteById(int id)
        {
            return _noteContext.Notes.Select(x => new NoteViewModel()
            {
                ID = x.ID,
                Description = x.Description,
                Title = x.Title,
                CreatedDate = x.Date,
                IsDeleted = x.IsDeleted
            }).Where(x => x.ID == id).FirstOrDefault();
        }

        public List<NoteViewModel> GetNoteList()
        {
            return _noteContext.Notes.Select(x => new NoteViewModel()
            {
                ID = x.ID,
                Description = x.Description,
                Title = x.Title,
                CreatedDate = x.Date,
                IsDeleted = x.IsDeleted
            }).OrderByDescending(x => x.ID).ToList();
        }

        public bool RemoveNote(int id)
        {
            Note note = _noteContext.Notes.Find(id);

            if (note != null)
            {
                note.IsDeleted = true;
                _noteContext.SaveChanges();
                return true;
            }

            return false;
        }

        public bool UpdateNote(int id, NoteViewModel model)
        {
            Note note = _noteContext.Notes.Find(id);
            if (note != null)
            {
                note.Title = model.Title;
                note.Description = model.Description;
                note.Date = DateTime.Now;
                note.IsDeleted = false;
                _noteContext.Update(note);
                _noteContext.SaveChanges();

                return true;
            }
            return false;
        }
    }
}
