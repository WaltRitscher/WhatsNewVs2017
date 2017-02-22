using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RouxAcademyWebApp.Models
{
  public class EventRepository
  {
    List<SchoolEvent> events = new List<SchoolEvent>();
    public EventRepository()
    {
      var theEvent = new SchoolEvent
      {
        EventDate = DateTime.Parse("3/10/2016"),
        Title = "Roux Benefit for the Elementary Arts Concert",
        Description = " Ut viverra dignissim diam, at auctor metus aliquam id."
      };
      events.Add(theEvent);

      theEvent = new SchoolEvent
      {
        EventDate = DateTime.Parse("3/12/2016"),
        Title = "Midterm exams begin",
        Description = " Duis sit amet metus eu ex ultricies commodo a eget sem."
      };
      events.Add(theEvent);

      theEvent = new SchoolEvent
      {
        EventDate = DateTime.Parse("3/16/2016"),
        Title = "Midterm exams begin",
        Description = "Curabitur ligula nibh, interdum a velit tempus, finibus malesuada ex."
      };
      events.Add(theEvent);

      theEvent = new SchoolEvent
      {
        EventDate = DateTime.Parse("4/06/2016"),
        Title = "Opening reception for The Stone World exhibit",
        Description = "Aliquam laoreet auctor faucibus."
      };
      events.Add(theEvent);

      theEvent = new SchoolEvent
      {
        EventDate = DateTime.Parse("4/23/2016"),
        Title = "Roux Student Fashion Weeks starts",
        Description = "Nulla ac pulvinar diam. Praesent neque sapien, "
      };
      events.Add(theEvent);
    }

    public List<SchoolEvent> GetAllEvents()
    {
      return events;
    }
  }
}