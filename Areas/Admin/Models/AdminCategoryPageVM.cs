namespace synto.Areas.Admin.Models
{
    public class AdminCategoryPageVM
    {
        public List<AdminCategoryVM> AdminCategoryVMs { get; set; }
        public AdminCategoryVM AdminCategoryVM { get; set; }
        public List<AdminSubCategoryVM>AdminSubCategoryVMs { get; set; }
        public List<AdminTreeViewVM> AdminTreeViewVMs { get; set; }
    }
}
