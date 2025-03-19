using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMVC.Models
{
    public class DaiLy1
    {
    [Key]
    public string MaDaiLy { get; set; }
    public string TenDaiLy { get; set; }
    public string DiaChi { get; set; }
    public string NguoiDaiDien { get; set; }
    public string DienThoai { get; set; }
    
    [ForeignKey("HeThongPhanPhoi1")]
    public string MaHTPP { get; set; }
    public HeThongPhanPhoi1 HeThongPhanPhoi { get; set; }
    }
}