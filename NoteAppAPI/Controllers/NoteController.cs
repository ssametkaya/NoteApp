using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NoteAppAPI.Models.ViewModel;
using NoteAppAPI.Service.Abstract;
using NoteAppAPI.Service.Concrete;

namespace NoteAppAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class NoteController : ControllerBase
    {
        private readonly INoteService _noteService;
        public NoteController(INoteService noteService)
        {
            _noteService = noteService;
        }
        [HttpGet]
        public IActionResult GetNoteList()
        {
            return Ok(_noteService.GetNoteList());
        }

        [Route("~/api/[controller]/[action]/{id}")]
        [HttpGet]
        public IActionResult GetNote(int id)
        {
            var value = _noteService.GetNoteById(id);
            if (value==null)
            {
                return NotFound("Not Bulunamadı.");
            }
            return Ok(value);
        }

        [HttpPost]
        public IActionResult AddNote(NoteViewModel noteViewModel)
        {
            //_noteService.AddNote(noteViewModel);
            ////return CreatedAtAction(nameof(GetNote),new {id=noteViewModel.ID},noteViewModel);
            //return Ok();
            return _noteService.AddNote(noteViewModel) ? Ok("Başarılı") : BadRequest("Olmadı");
        }

        [HttpDelete]
        [Route("~/api/[controller]/[action]/{id}")]
        public IActionResult RemoveNote(int id)
        {
            //_noteService.RemoveNote(id);
            //return Ok();
            return _noteService.RemoveNote(id) ? Ok("Sildi") : BadRequest("Silemedi");
        }

        [HttpPut]
        [Route("~/api/[controller]/[action]/{id}")]
        public IActionResult UpdateNote(int id,NoteViewModel note)
        {
            return _noteService.UpdateNote(id,note) ? Ok("Güncellendi") : BadRequest("Güncellenmedi");
        }
    }
}
