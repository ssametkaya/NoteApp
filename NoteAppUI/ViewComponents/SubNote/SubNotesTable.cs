using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NoteAppUI.Models.ViewModel;

namespace NoteAppUI.ViewComponents.SubNote
{
    public class SubNotesTable:ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            HttpClient httpClient = new HttpClient();
            var responseMessage = httpClient.GetAsync("http://localhost:5151/api/SubNote/GetSubNotes/" + id).Result;
            List<SubNoteViewModel> subnotes = new List<SubNoteViewModel>();
            if (responseMessage.StatusCode == System.Net.HttpStatusCode.OK)
            {
                subnotes = JsonConvert.DeserializeObject<List<SubNoteViewModel>>(responseMessage.Content.ReadAsStringAsync().Result);
            }
            return View(subnotes);
        }
    }
}
