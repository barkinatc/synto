namespace synto.Areas.Admin.Models
{
    public class AppUserVM
    {
        public int  ID { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }


        public string? Mail { get; set; }

        public int? InstitutionID { get; set; }
    }
}
