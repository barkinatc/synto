namespace synto.Areas.Admin.Models
{
    public class InstitutionTreeViewVM
    {
        public string? ID { get; set; }
        public string? Name { get; set; }

        public List<AdminTreeViewVM> Children { get; set; }

        public InstitutionTreeViewVM()
        {
            Children = new List<AdminTreeViewVM>();
        }
    }
}
