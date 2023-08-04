using System.ComponentModel.DataAnnotations;

namespace LeThanhNam_03.Models
{
    public class NhanVien
    {
        [Key]
        public string MaNhanVien { get; set; }
        
        public string TenNhanvien { get; set; }
        
        public string MaPhongBan { get; set; }
        
    }
}