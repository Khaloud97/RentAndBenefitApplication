using System.ComponentModel.DataAnnotations;

namespace RentAndBenefitApplication.PL.ViewModels
{
    public class ToolVM
    {
        
        public string ToolId { get; set; }
        [Required(ErrorMessage = "Code is Required for the Tool")]
        
        public string ToolName { get; set; }



    }
}