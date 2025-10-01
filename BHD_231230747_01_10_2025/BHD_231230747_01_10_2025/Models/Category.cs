using System.ComponentModel.DataAnnotations;

namespace BHD_231230747_01_10_2025.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ten danh muc khong duoc de trong")]
        [StringLength(150, MinimumLength = 6,
            ErrorMessage = "Ten danh muc phai tu 6 den 150 ki tu")]
        public string Name { get; set; } = "";
    }
}
