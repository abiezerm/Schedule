namespace Schedule.Domain.Entities
{
    public class Appointment : AEntityActivable<int>
    {
        public string Nis { get; set; }
        public string Document { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateShedule { get; set; }
        public DateTime atDate { get; set; }

        public int idCity { get; set; }

        public int idStatusMigratory { get; set; }
        public int idTypeDocument { get; set; }
        public int idNationality { get; set; }
        public int idServices { get; set; }


        public StatusMigratory StatusMigratory { get; set; }
        public City City { get; set; }
        public TypeDocument TypeDocument { get; set; }
        public Country Nationalitie { get; set; }
        public Services Service { get; set; }

    }
}


