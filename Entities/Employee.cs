using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyEmployees.Entities;

public class Employee
{
    [Column("EmployeeId")] public Guid Id { get; set; }
    
    [Required(ErrorMessage = "Employee name required.")]
    [MaxLength(30, ErrorMessage = "Max length for employee name is 30")]
    public string? Name { get; set; }
    
    [Required(ErrorMessage = "Age is required")]
    public int Age { get; set; }
    
    [Required(ErrorMessage = "Position is required")]
    [MaxLength(20, ErrorMessage = "Max length for position is 20 characters")]
    public string? Position { get; set; }
    
    [ForeignKey(nameof(Company))] 
    public Guid CompanyId { get; set; }

    public Company? Company { get; set; }
}