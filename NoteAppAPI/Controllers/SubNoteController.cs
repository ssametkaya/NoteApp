using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NoteAppAPI.Models.Entity;
using NoteAppAPI.Models.ViewModel;
using NoteAppAPI.Service.Abstract;
using NoteAppAPI.Service.Concrete;
using System.Diagnostics.CodeAnalysis;

namespace NoteAppAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SubNoteController : ControllerBase
    {
        private readonly ISubNoteService _subNoteService;
        public SubNoteController(ISubNoteService SubnoteService)
        {
            _subNoteService = SubnoteService;
        }
        
        [HttpGet]
        [Route("~/api/[controller]/[action]/{id}")]
        public IActionResult GetSubNotes(int id)
        {
            return Ok(_subNoteService.GetSubNotes(id));
        }

        [HttpPost]
        [Route("~/api/[controller]/[action]/{id}")]
        public IActionResult AddSubNote(int id,SubNoteViewModel subNoteViewModel)
        {
            //_subNoteService.AddSubNote(subNoteViewModel,id);
            //return Ok();
            return _subNoteService.AddSubNote(subNoteViewModel, id) ? Ok("Başarılı") : BadRequest("Olmadı");
        }

        [HttpDelete]
        [Route("~/api/[controller]/[action]/{id}")]
        public IActionResult RemoveSubNote(int id)
        {
            return _subNoteService.RemoveSubNote(id) ? Ok("Sildi") : BadRequest("Silemedi");
        }
    }
}
