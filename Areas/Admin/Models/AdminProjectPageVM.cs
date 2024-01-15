namespace synto.Areas.Admin.Models
{
    public class AdminProjectPageVM
    {
        public List<AdminProjectVM> ProjectVMs { get; set; }
        public AdminProjectVM ProjectVM { get; set; }
        public List<AdminTreeViewVM> AdminTreeViewVMs { get; set; }
        public AdminCategoryVM AdminCategoryVM { get; set; }
    }
}
