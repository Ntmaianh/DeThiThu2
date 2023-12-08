﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DeThiThu2.DomainClass;

[Table("LoaiXM")]
[Index("Ma", Name = "UQ__LoaiXM__3214CC9E07B2D29C", IsUnique = true)]
public partial class LoaiXm
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Ma { get; set; }

    [StringLength(50)]
    public string? Ten { get; set; }

    [InverseProperty("IdLxmNavigation")]
    public virtual ICollection<XeMay> XeMays { get; } = new List<XeMay>();
}
