using Microsoft.AspNetCore.Mvc;

namespace EmployeeModel.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string fullName { get; set; } = string.Empty;

        public string Gender { get; set; } = string.Empty;

        public string? Phone { get; set; }

        public string? Email { get; set; }

        public decimal Salary { get; set; }

        public string Status { get; set; } = "Active";
    }
}
