using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyEmployees.Entities;

public class Company
{
    [Column("CompanyId")] public Guid Id { get; set; }
    
    [Required(ErrorMessage = "Company name required.")]
    [MaxLength(60, ErrorMessage = "Max length for name is 60 characters.")]
    public string? Name { get; set; }

    public string? Country { get; set; }
    public string? Address { get; set; }

    public ICollection<Employee>? Employees { get; set; }
}
