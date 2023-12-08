using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DeThiThu2.DomainClass;

[Table("LoaiSP")]
[Index("Ma", Name = "UQ__LoaiSP__3214CC9EEF438A5B", IsUnique = true)]
public partial class LoaiSp
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Ma { get; set; }

    [StringLength(50)]
    public string? Ten { get; set; }

    [InverseProperty("IdLoaiSpNavigation")]
    public virtual ICollection<SanPham> SanPhams { get; } = new List<SanPham>();
}
