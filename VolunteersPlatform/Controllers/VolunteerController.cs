using Microsoft.AspNetCore.Mvc;
using VolunteersPlatform.Models;

namespace VolunteersPlatform.Controllers
{
    public class VolunteerController : Controller
    {
        public IActionResult Dashboard()
        {
            // You can pass a list of opportunities to the view here
            var opportunities = new List<Opportunity>
            {
                new Opportunity { Id = 1, CampName = "Camp 1", Description = "A fun and rewarding experience.", Location = "Location 1", VolunteersNeeded = 10, Schedule = "Schedule 1" },
                new Opportunity { Id = 2, CampName = "Camp 2", Description = "Community outreach and education.", Location = "Location 2", VolunteersNeeded = 15, Schedule = "Schedule 2" },
                new Opportunity { Id = 3, CampName = "Camp 3", Description = "Build and restore homes.", Location = "Location 3", VolunteersNeeded = 20, Schedule = "Schedule 3" }
            };

            return View(opportunities);
        }

        public IActionResult SignUp(int id)
        {
            // Logic to handle volunteer sign-up
            Console.WriteLine($"Volunteer signed up for opportunity ID: {id}");

            // Redirect to the confirmation page
            return View();
        }
    }
}