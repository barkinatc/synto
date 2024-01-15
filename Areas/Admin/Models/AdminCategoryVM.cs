namespace synto.Areas.Admin.Models
{
    public class AdminCategoryVM
    {
        public int ID { get; set; }
        
        public string? Name { get; set; }
        
        public string? ParentID { get; set; }
    }
}
