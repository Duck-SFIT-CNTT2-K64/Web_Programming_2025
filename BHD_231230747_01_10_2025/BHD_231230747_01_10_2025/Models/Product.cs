using System.ComponentModel.DataAnnotations;

namespace BHD_231230747_01_10_2025.Models
{
    public class Product : IValidatableObject
    {
        public int Id { get; set; }

        [Display(Name = "Tên sản phẩm")]
        [Required(ErrorMessage = "Tên sản phẩm bắt buộc nhập")]
        [StringLength(150, MinimumLength = 6,
            ErrorMessage = "Tên phải từ 6 đến 150 ký tự")]
        public string Name { get; set; } = "";

        [Display(Name = "/products/lap_top.jpg")]
        public string Image { get; set; } = "";

        [Display(Name = "Giá chuẩn")]
        [DataType(DataType.Currency)]
        [Range(100000, double.MaxValue, ErrorMessage = "Giá chuẩn tối thiểu 100.000")]
        public decimal Price { get; set; }

        [Display(Name = "Giá khuyến mãi")]
        [DataType(DataType.Currency)]
        [Range(0, double.MaxValue, ErrorMessage = "Giá khuyến mãi không được âm")]
        public decimal SalePrice { get; set; }

        [Display(Name = "Mô tả")]
        [StringLength(1500, ErrorMessage = "Mô tả tối đa 1500 ký tự")]
        [NotContains("admin", "fack", "xxx", "sex", "bậy",
            ErrorMessage = "Mô tả chứa từ ngữ nhạy cảm, vui lòng thay đổi")]
        public string? Description { get; set; }

        [Display(Name = "Danh mục")]
        [Required(ErrorMessage = "Vui lòng chọn danh mục")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext context)
        {
            if (SalePrice > Price * 0.9m)
                yield return new ValidationResult(
                    "Giá khuyến mãi phải thấp hơn giá chuẩn ít nhất 10%",
                    new[] { nameof(SalePrice) });

            if (CategoryId <= 0)
                yield return new ValidationResult("Phải chọn danh mục", new[] { nameof(CategoryId) });
        }
    }
}
