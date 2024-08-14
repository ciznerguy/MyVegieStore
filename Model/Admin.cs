namespace MyVegieStore.Model
{
    public class Admin : Person
    {
        
        public string Role { get; set; }
        public DateTime DateHired { get; set; }
        public DateTime LastLoginDate { get; set; }
    }
}
