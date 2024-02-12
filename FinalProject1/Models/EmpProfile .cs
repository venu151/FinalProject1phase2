﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FinalProject1.Models
{
    [Table("EmpProfile")]
    public class EmpProfile
    {  
            [Key]
            public int EmpCode { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string? EmpName { get; set; }
            public string? Email { get; set; }
            [ForeignKey("DeptCode")]
            public int DeptCode { get; set; }
        }
}
