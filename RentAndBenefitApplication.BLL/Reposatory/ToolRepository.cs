using Microsoft.EntityFrameworkCore;
using RentAndBenefitApplication.DAL.Contex;
using RentAndBenefitApplication.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentAndBenefitApplication.BLL.Reposatory
{
    public class ToolRepository
    {
        private readonly ApplicationDbContext _context;

        public ToolRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // this function to Get All Tool
        public IEnumerable<Tool> GetAllTools()
        {
            return _context.Tools.ToList();
        }

        // this function to Get Tool By Id 
        public Tool GetToolById(int toolId)
        {
            return _context.Tools.Find(toolId);
        }
        // this function Add Tool
        public void AddTool(Tool tool)
        {
            _context.Tools.Add(tool);
            _context.SaveChanges();
        }

        // this function Update Tool
        public void UpdateTool(Tool tool)
        {
            _context.Entry(tool).State = EntityState.Modified;
            _context.SaveChanges();
        }

        // this function Delete Tool
        public void DeleteTool(int toolId)
        {
            var tool = _context.Tools.Find(toolId);
            if (tool != null)
            {
                _context.Tools.Remove(tool);
                _context.SaveChanges();
            }
        }

        // this function if you need the  to Get All Available Tools
        public IEnumerable<Tool> GetAllAvailableTools()
        {
            return _context.Tools.Where(tool => tool.IsAvailable).ToList();
        }

        // this function if you need the  to Get Tool by type of  Tools
        public IEnumerable<Tool> GetToolsByType(ToolType toolType)
        {
            return _context.Tools.Where(tool => tool.Type == toolType).ToList();
        }
    }
}
