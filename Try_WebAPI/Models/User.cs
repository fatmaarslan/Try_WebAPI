namespace Try_WebAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int ProjectId { get; set; }
        public long AddedDate { get; set; }
    }
}
