namespace synto.Areas.Admin.Models
{
    public class MissionCreatePage
    {
        public AppUserVM? Appuser { get; set; }

        public List<AdminPageVM> PageVMs { get; set; }


        public IFormFile Image { get; set; }

        public string? TextArea { get; set; }
        public string? DataInput { get; set; }
        public string? itemId { get; set; }


    }
}
