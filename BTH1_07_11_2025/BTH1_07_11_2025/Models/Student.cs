namespace BTH1_07_11_2025.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public Branch? branch { get; set; }
        public Gender? gender { get; set; }
        public bool IsRegular { get; set; }
        public string? Address { get; set; }
        public DateTime DateOfBorth { get; set; }
    }
}
