using FinanceMentor.Shared;
using System;
using System.ComponentModel.DataAnnotations;

namespace FinanceMentor.Client.Coponents
{
    public class EarningsModel
    {

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string Subject { get; set; }

        //This is a custom Enum type that is defined in the shared project
        //Note: This is FinanceMentor.Shared, NOT shared folder under client!
        [Required]
        public EarningCategory Category { get; set; }

        [Required]
        public decimal Amount { get; set; }
    }
}
