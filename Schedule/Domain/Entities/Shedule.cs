namespace Schedule.Domain.Entities
{
    public class Shedule : AEntityActivable<int>
    {
        public string Nis { get; set; }
        public string Document { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string DateShedule { get; set; }
        public string atDate { get; set; }
        public IList<StatusMigratory> MigratoryStatus { get; set; }
        public IList<City> Cities { get; set; }
        public IList<DocumentType> DocumentsTypes { get; set; }
        public IList<Country> Nationalities { get; set; }
        public IList<Service> Services{ get; set; }


    }
}
