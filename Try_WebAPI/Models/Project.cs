namespace Try_WebAPI.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool IsAvailable { get; set; }
        public long AddedDate { get; set; }
    }
}
