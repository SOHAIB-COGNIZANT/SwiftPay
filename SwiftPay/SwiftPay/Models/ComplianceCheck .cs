using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwiftPay.Domain.Remittance.Entities
{
    public class ComplianceCheck
    {
        [Key]
        [MaxLength(64)]
        public string CheckId { get; set; } = default!;

        // Foreign Key to RemittanceRequest
        [Required]
        [MaxLength(64)]
        public string RemitId { get; set; } = default!;

        // Check Type: Sanctions, PEP, AML, Geo
        [Required]
        [MaxLength(32)]
        public string CheckType { get; set; } = default!;

        // Result: Clear, Flag, Hold
        [Required]
        [MaxLength(20)]
        public string Result { get; set; } = default!;

        // Severity: Low, Medium, High
        [Required]
        [MaxLength(20)]
        public string Severity { get; set; } = default!;

        [Required]
        public DateTimeOffset CheckedDate { get; set; } = DateTimeOffset.UtcNow;

        // Optimistic concurrency to prevent race conditions during compliance updates
        [Timestamp]
        public byte[] RowVersion { get; set; } = Array.Empty<byte>();

        // Navigation Property (Optional but recommended in .NET EF Core)
        // [ForeignKey("RemitId")]
        // public virtual RemittanceRequest Remittance { get; set; } = default!;
    }
}