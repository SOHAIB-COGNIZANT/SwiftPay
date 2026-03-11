using System;
using System.ComponentModel.DataAnnotations;

namespace SwiftPay.FXModule.Api.Models
{
    public class FeeRule
    {
        [Key]
        public string FeeRuleID { get; set; } = Guid.NewGuid().ToString(); 
        public string Corridor { get; set; } = string.Empty; //"USD-INR" 
        public string PayoutMode { get; set; } = string.Empty; // Account/CashPickup/MobileWallet
        public string FeeType { get; set; } = string.Empty; 
        public decimal FeeValue { get; set; } 
        public decimal MinFee { get; set; } 
        public decimal MaxFee { get; set; } 
        public DateTime EffectiveFrom { get; set; }
        public DateTime EffectiveTo { get; set; }
        public string Status { get; set; } = "Active"; 
    }
}