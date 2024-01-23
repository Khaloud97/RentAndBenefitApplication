using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentAndBenefitApplication.BLL.Interfaces
{
    public interface IToolRepositry<Tool>
    {
        IEnumerable<Tool> GetAllTools();
        Tool GetToolById(int id);
        
        int AddTool(Tool item);
        int UpdateTool(Tool item);
        int DeleteTool(Tool item);
        int GetAllAvailableTools(Tool item);
        int GetToolsByType(Tool toolType);
    }
}
