using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnterPrice.Entities;
using EnterPrice.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EnterPrice.Pages
{
    public class AsigmentsModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public AsigmentsModel(ApplicationDbContext context)
        {
          _context = context;
        }
        public List<Asigment> Asigments { get; set; }
        public int Amount { get; set; }
        public void OnGet()
        {
            Asigments = _context.Asigments.Include(x=>x.Building).Include(x=>x.Worker).ToList();
            Amount = _context.Asigments.Count();
        }
    }
}
