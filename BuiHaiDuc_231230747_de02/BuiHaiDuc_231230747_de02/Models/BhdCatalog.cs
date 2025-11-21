using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuiHaiDuc_231230747_de02.Models
{
    [Table("bhdCatalog")]
    public class BhdCatalog
    {
        [Key]
        [Display(Name = "Mã Sản phẩm")]
        public string BhdId { get; set; }

        [Required(ErrorMessage = "Tên sản phẩm không được để trống")]
        [Display(Name = "Tên Sản phẩm")]
        public string BhdCateName { get; set; }

        [Range(100, 5000, ErrorMessage = "Giá sản phẩm phải từ 100 đến 5000")]
        [Display(Name = "Giá")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? BhdCatePrice { get; set; }

        [Display(Name = "Số lượng")]
        public int? BhdCateQty { get; set; }

        [Display(Name = "Ảnh")]
        public string? BhdPicture { get; set; }

        [Display(Name = "Trạng thái")]
        public bool? BhdCateActive { get; set; }
    }
}
