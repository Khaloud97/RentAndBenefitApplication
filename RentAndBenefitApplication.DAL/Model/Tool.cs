using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentAndBenefitApplication.DAL.Model
{

    public class Tool
    {
        public int ToolId { get; set; }

        [MaxLength(50)]
        public string ToolName { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [DataType(DataType.Currency)]
        public decimal RentalCost { get; set; }
        public bool IsAvailable { get; set; }
        public ToolType Type { get; set; }

        public double Latitude { get; set; } // Tool's latitude
        public double Longitude { get; set; } // Tool's longitude

        // Navigation property to link a tool to its owner (a user)
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
    public enum ToolType
    {
        Section1,
        Section2,
        Section3
    }

}
