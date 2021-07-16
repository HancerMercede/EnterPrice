using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnterPrice.Entities;
using EnterPrice.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EnterPrice.Pages
{
    public class BuildingModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public BuildingModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<Building> Buildings { get; set; }
   
        public int Amount { get; set; }
        public void OnGet()
        {
            Buildings = _context.Buidings.ToList();
            Amount = _context.Buidings.Count();
        }
    }
}
