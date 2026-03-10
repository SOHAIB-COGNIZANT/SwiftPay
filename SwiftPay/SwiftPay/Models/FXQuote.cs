using System;
using System.ComponentModel.DataAnnotations;

namespace SwiftPay.FXModule.Api.Models
{
    public class FXQuote
    {
        [Key]
        public string QuoteID { get; set; } = Guid.NewGuid().ToString(); // primary key
        public string FromCurrency { get; set; } = string.Empty; 
        public string ToCurrency { get; set; } = string.Empty;
        public decimal MidRate { get; set; } 
        public int MarginBps { get; set; } 
        public decimal OfferedRate { get; set; } 
        public DateTime QuoteTime { get; set; } = DateTime.UtcNow;
        public DateTime ValidUntil { get; set; } 
        public string Status { get; set; } = "Active"; // Active or Expired
    }
}