namespace VolunteersPlatform.Models
{
    public class Opportunity
    {
        public int Id { get; set; }
        public string CampName { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public int VolunteersNeeded { get; set; }
        public string Schedule { get; set; }
        public string Photos { get; set; }
    }
}