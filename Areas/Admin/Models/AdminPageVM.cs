namespace synto.Areas.Admin.Models
{
    public class AdminPageVM
    {
        public int ID { get; set; }
        public int? CategoryID { get; set; }
        public int? PageType { get; set; }

        public int? Order { get; set; }
        public int? InstitutionID { get; set; }
    }
}
