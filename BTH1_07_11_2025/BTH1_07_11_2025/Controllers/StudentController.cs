using BTH1_07_11_2025.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BTH1_07_11_2025.Controllers
{
    public class StudentController : Controller
    {
        private List<Student> listStudents = new List<Student>();
        public StudentController()
        {
            listStudents = new List<Student>()
            {
                new Student() { Id = 101, Name = "Hải Đức", branch = Branch.IT,
                    gender = Gender.Male, IsRegular=true,
                    Address = "A1-2018", Email = "Nam@g.com" },

                new Student() { Id = 102, Name = "Minh Tú", branch = Branch.BE,
                    gender = Gender.Female, IsRegular=true,
                    Address = "A1-2019", Email = "Tu@g.com" },

                new Student() { Id = 103, Name = "Hoàng Phong", branch = Branch.CE,
                    gender = Gender.Male, IsRegular=false,
                    Address = "A1-2020", Email = "Phong@g.com" },

                new Student() { Id = 104, Name = "Xuân Mai", branch = Branch.EE,
                    gender = Gender.Female, IsRegular = false,
                    Address = "A1-2021", Email = "mai@g.com" }
            };
        }
        public IActionResult Index()
        {
            return View(listStudents);
        }

        [HttpGet]
        public IActionResult Create()
        {
            //Lấy danh sách các giá trị Gender để hiển thị radio button trên form
            ViewBag.AllGenders = Enum.GetValues(typeof(Gender)).Cast<Gender>().ToList();
            //Lấy danh sách các giá trị Branch để hiển thị select-option trên form
            //Để hiển thị select-option trên View cần dùng List<SelectListItem>
            ViewBag.AllBranches = new List<SelectListItem>()
    {
        new SelectListItem { Text = "IT", Value = "1" },
        new SelectListItem { Text = "BE", Value = "2" },
        new SelectListItem { Text = "CE", Value = "3" },
        new SelectListItem { Text = "EE", Value = "4" }
    };
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student s)
        {
            s.Id = listStudents.Last<Student>().Id + 1;
            listStudents.Add(s);
            return View("Index", listStudents);
        }
    }
}
