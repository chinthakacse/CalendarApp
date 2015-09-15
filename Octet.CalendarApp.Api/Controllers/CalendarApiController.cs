using System.Collections.Generic;
using System.Web.Http;
using Octet.CalendarApp.Model;

namespace Octet.CalendarApp.Api.Controllers
{
    public class CalendarApiController : ApiController
    {
        private const string BaseImageUrl = @"http://localhost:56795/Content/Images";

        public IEnumerable<CalendarItem> Get()
        {
            return new List<CalendarItem>
            {
                new CalendarItem
                {
                    Id = 1,
                    Name = "SUITS",
                    SubscriberCount = 100,
                    ImageUrl = string.Format("{0}/{1}", BaseImageUrl,"Ferrari.jpg")
                },
                new CalendarItem
                {
                    Id = 2,
                    Name = "DIG",
                    SubscriberCount = 450,
                    ImageUrl = string.Format("{0}/{1}", BaseImageUrl,"sunset1.jpg")

                },
                new CalendarItem
                {
                    Id = 3,
                    Name = "COVERT AFFAIRS",
                    SubscriberCount = 230,
                    ImageUrl = string.Format("{0}/{1}", BaseImageUrl,"sky2.jpg")

                },
                new CalendarItem
                {
                    Id = 4,
                    Name = "GRACELAND",
                    SubscriberCount = 121,
                    ImageUrl = string.Format("{0}/{1}", BaseImageUrl,"Ferrari.jpg")

                },
                new CalendarItem
                {
                    Id = 5,
                    Name = "CHRISLEY",
                    SubscriberCount = 4732,
                    ImageUrl = string.Format("{0}/{1}", BaseImageUrl,"sky2.jpg")

                },
                new CalendarItem
                {
                    Id = 6,
                    Name = "CHRIS",
                    SubscriberCount = 24567,
                    ImageUrl = string.Format("{0}/{1}", BaseImageUrl,"sunset1.jpg")
                },
                new CalendarItem
                {
                    Id = 7,
                    Name = "PEREIS",
                    SubscriberCount = 234,
                    ImageUrl = string.Format("{0}/{1}", BaseImageUrl,"sunset1.jpg")
                },
                new CalendarItem
                {
                    Id = 8,
                    Name = "GRACE",
                    SubscriberCount = 12,
                    ImageUrl = string.Format("{0}/{1}", BaseImageUrl,"sunset1.jpg")
                },
                new CalendarItem
                {
                    Id = 8,
                    Name = "OPTIMUS",
                    SubscriberCount = 1,
                    ImageUrl = string.Format("{0}/{1}", BaseImageUrl,"Ferrari.jpg")
                },
            };
        }
       
    }
}
