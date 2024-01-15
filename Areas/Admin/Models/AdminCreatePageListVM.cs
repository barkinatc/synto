namespace synto.Areas.Admin.Models
{
    public class AdminCreatePageListVM
    {
        public AdminCreatePageVM CreatePageVM { get; set; }
        public AdminListPageVM ListPageVM { get; set; }
        public AdminCountPageVM adminCountPageVM { get; set; }

        public AdminCreatePageListVM()
        {
            CreatePageVM = new AdminCreatePageVM();
            ListPageVM = new AdminListPageVM();

        }
    }
}
