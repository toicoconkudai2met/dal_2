using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace prl_2.DomainClass;

[Table("SINHVIEN")]
public partial class Sinhvien
{
    [Key]
    [Column("MSV")]
    [StringLength(7)]
    public string Msv { get; set; } = null!;

    [Column("HOTEN")]
    [StringLength(50)]
    public string Hoten { get; set; } = null!;

    [Column("DOB")]
    public DateOnly Dob { get; set; }

    [Column("EMAIL")]
    [StringLength(50)]
    public string Email { get; set; } = null!;

    [Column("DIEMTONGKET")]
    public double? Diemtongket { get; set; }
}
