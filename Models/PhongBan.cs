using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LeThanhNam_03.Models
{
    [Table("PhongBan")]
    public class PhongBan 
    {
        [Key]
        public string MaPhongBan { get; set; }
        
        public string TenPhongBan { get; set; }
    
    }
}