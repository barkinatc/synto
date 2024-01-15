namespace synto.Areas.Admin.Models
{
    public class AdminChoseVM
    {
        public int CategoryID { get; set; }
        public List<DraggableItem> Items { get; set; }
    }
}
