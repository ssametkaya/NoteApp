using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NoteAppUI.Models;
using NoteAppUI.Models.ViewModel;
using System.Diagnostics;
using System.Text;

namespace NoteAppUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            
        }

        public IActionResult Index()
        {
            HttpClient httpClient = new HttpClient();
            var responseMessage = httpClient.GetAsync("http://localhost:5151/api/Note/GetNoteList").Result;
            List<NoteViewModel> notes = new List<NoteViewModel>();
            if (responseMessage.StatusCode == System.Net.HttpStatusCode.OK)
            {
                notes = JsonConvert.DeserializeObject<List<NoteViewModel>>(responseMessage.Content.ReadAsStringAsync().Result);
            }
            return View(notes);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AddNote()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddNote(NoteViewModel note)
        {
            HttpClient client = new HttpClient();
            StringContent content = new StringContent(JsonConvert.SerializeObject(note), Encoding.UTF8, "application/json");
            if (!ModelState.IsValid)
            {
                return View();
            }

            var responseMessage = client.PostAsync("http://localhost:5151/api/Note/AddNote", content).Result;

            if (responseMessage.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return RedirectToAction("Index","Home");
            }
            ModelState.AddModelError("", "Ekleme İşlemi Başarısız");
            return View();
        }

        public IActionResult GetNote(int id)
        {
            HttpClient httpClient = new HttpClient();
            var responseMessage = httpClient.GetAsync("http://localhost:5151/api/Note/GetNote/"+id).Result;
            NoteViewModel notes = new NoteViewModel();
            if (responseMessage.StatusCode == System.Net.HttpStatusCode.OK)
            {
                notes = JsonConvert.DeserializeObject<NoteViewModel>(responseMessage.Content.ReadAsStringAsync().Result);
            }
            return View(notes);
        }

        public IActionResult AddSubNote()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddSubNote(int id,SubNoteViewModel subNote)
        {
            HttpClient client = new HttpClient();
            StringContent content = new StringContent(JsonConvert.SerializeObject(subNote), Encoding.UTF8, "application/json");
            if (!ModelState.IsValid)
            {
                return View();
            }
            var responseMessage = client.PostAsync($"http://localhost:5151/api/SubNote/AddSubNote/{id}", content).Result;

            if (responseMessage.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return LocalRedirect($"/Home/GetNote/{id}");
            }
            ModelState.AddModelError("", "Ekleme İşlemi Başarısız");
            return View();
        }

        public IActionResult DeleteNote(int id)
        {
            HttpClient httpClient = new HttpClient();
            var responseMessage = httpClient.DeleteAsync($"http://localhost:5151/api/Note/RemoveNote/{id}").Result;
            return RedirectToAction("Index", "Home");
        }

        public IActionResult DeleteSubNote(int id)
        {
            HttpClient httpClient = new HttpClient();
            var responseMessage = httpClient.DeleteAsync($"http://localhost:5151/api/SubNote/RemoveSubNote/{id}").Result;
            return RedirectToAction("Index", "Home");
        }

        public IActionResult UpdateNote(int id)
        {
            HttpClient httpClient = new HttpClient();
            var responseMessage = httpClient.GetAsync("http://localhost:5151/api/Note/GetNote/" + id).Result;
            NoteViewModel notes = new NoteViewModel();
            if (responseMessage.StatusCode == System.Net.HttpStatusCode.OK)
            {
                notes = JsonConvert.DeserializeObject<NoteViewModel>(responseMessage.Content.ReadAsStringAsync().Result);
            }
            return View(notes);
        }

        [HttpPost]
        public IActionResult UpdateNote(int id, NoteViewModel model)
        {
            HttpClient httpClient = new HttpClient();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            if (!ModelState.IsValid)
            {
                return View();
            }
            var responseMessage = httpClient.PutAsync($"http://localhost:5151/api/Note/UpdateNote/{id}", content).Result;

            return LocalRedirect($"/Home/GetNote/{id}");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}