using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;
using Newtonsoft.Json;
using Octet.CalendarApp.Model;
using Octet.CalendarApp.Web.ViewModels;

namespace Octet.CalendarApp.Web.Controllers
{
    public class HomeController : Controller
    {
        private const string CalendarApi = "http://localhost:56450/api/CalendarApi";

        public async Task<ActionResult> Index()
        {
            using (var httpClient = new HttpClient())
            {

                var calendars = JsonConvert.DeserializeObject<List<CalendarItem>>(
                                                                                  await
                                                                                      httpClient.GetStringAsync(
                                                                                                                CalendarApi));

                var vm = new CalendarListViewModel
                {
                    ActiveCalendarCount = calendars.Count,
                    CalendarItems = calendars,
                    TotalSubscriberCount = calendars.Sum(c => c.SubscriberCount)
                };
                return View(vm);
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}