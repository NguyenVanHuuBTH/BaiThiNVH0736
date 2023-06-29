using System.ComponentModel.DataAnnotations;

namespace BaiThiNVH.Models;

public class NVHCau3
{
    [Key]
    [Display(Name ="Tên")]
    public string? Ten { get; set; }

    [Display(Name ="Lớp")]
    public string? Lop { get; set; }

    [Display(Name ="Địa Chỉ")]
    public string? DiaChi { get; set; }

    

    
}
