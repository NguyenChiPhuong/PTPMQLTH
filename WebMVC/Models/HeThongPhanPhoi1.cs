using System.ComponentModel.DataAnnotations;

namespace WebMVC.Models
{
    public class HeThongPhanPhoi1
    {
    [Key]
    public string MaHTPP { get; set; }
    public string TenHTPP { get; set; }
    
    public ICollection<DaiLy1> DaiLies { get; set; }

    }
}