using System.ComponentModel.DataAnnotations;

namespace WebMVC.Models
{
    public class DaiLy
    {
        [Key]
        public string MaDL { get; set; }
        public string TenDL { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string NguoiDaiDien { get; set; }
        public string MaHTPP { get; set; }
}
}