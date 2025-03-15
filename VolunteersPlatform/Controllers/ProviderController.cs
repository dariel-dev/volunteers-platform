using Microsoft.AspNetCore.Mvc;
using VolunteersPlatform.Models;

namespace VolunteersPlatform.Controllers
{
    public class ProviderController : Controller
    {
        // GET: Provider/Application
        // Displays the Opportunity Provider Application form
        public IActionResult Application()
        {
            return View();
        }

        // POST: Provider/SubmitApplication
        // Handles the form submission for the Opportunity Provider Application
        [HttpPost]
        public IActionResult SubmitApplication(Opportunity opportunity)
        {
            // Validate the model (ensure all required fields are filled)
            if (!ModelState.IsValid)
            {
                // If the model is invalid, return to the form with validation errors
                return View("Application", opportunity);
            }

            // Logic to handle the submission 
            Console.WriteLine("New Opportunity Submitted:");
            Console.WriteLine($"Camp Name: {opportunity.CampName}");
            Console.WriteLine($"Description: {opportunity.Description}");
            Console.WriteLine($"Location: {opportunity.Location}");
            Console.WriteLine($"Volunteers Needed: {opportunity.VolunteersNeeded}");
            Console.WriteLine($"Schedule: {opportunity.Schedule}");

            // Redirect to the confirmation page
            return RedirectToAction("ApplicationConfirmation");
        }

        // GET: Provider/ApplicationConfirmation
        // Displays the confirmation page after the form is submitted
        public IActionResult ApplicationConfirmation()
        {
            return View();
        }
    }
}