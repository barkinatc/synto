namespace synto.Models
{
    public class UserRegisterVM
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public string Mail { get; set; }

        public int InstitutionID { get; set; }

        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
