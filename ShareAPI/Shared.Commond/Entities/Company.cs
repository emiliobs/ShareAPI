namespace Shared.Common.Entities;

using System.ComponentModel.DataAnnotations;

public class Company
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = null!;

    [Required]
    [MaxLength(20)]
    public string TaxId { get; set; } = null!; // Identification number (RUT, NIT, etc.)

    [Required]
    [MaxLength(200)]
    public string Address { get; set; } = null!;

    [Required]
    [EmailAddress]
    [MaxLength(150)]
    public string ContactEmail { get; set; } = null!;

    [Required]
    [MaxLength(20)]
    public string Phone { get; set; } = null!;
}