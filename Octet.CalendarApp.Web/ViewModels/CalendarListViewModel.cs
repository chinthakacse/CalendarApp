using System.Collections.Generic;
using Octet.CalendarApp.Model;

namespace Octet.CalendarApp.Web.ViewModels
{
    public class CalendarListViewModel
    {
        public int ActiveCalendarCount { get; set; }
        public int TotalSubscriberCount { get; set; }
        public List<CalendarItem> CalendarItems { get; set; }

    }
}