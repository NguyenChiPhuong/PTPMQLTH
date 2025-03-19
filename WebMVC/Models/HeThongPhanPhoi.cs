using System.ComponentModel.DataAnnotations;

namespace WebMVC.Models
{
    public class HeThongPhanPhoi
    {
        [Key]
        public string MaHTPP { get; set; }
        public string TenHeThong { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
    }
}