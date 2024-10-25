namespace WebApi.Models
{
    public class User
    {
        public int UserID { get; set; }
        public required string Name { get; set; }
        public int  Age { get; set; }
        public required string Email { get; set; }

    }
}
