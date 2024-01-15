namespace synto.Areas.Admin.Models
{
    public class AdminSubCategoryVM
    {
        public int ID { get; set; }
        public string ?SubCategoryName { get; set; }

        public int? CategoryID { get; set; }

    }
}
