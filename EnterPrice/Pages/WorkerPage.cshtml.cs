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
    public class WorkerPageModel : PageModel
    {
        public readonly ApplicationDbContext _Context;
        
        public WorkerPageModel(ApplicationDbContext Context)
        {
            _Context = Context;
        }
        public List<Worker> workers { get; set; }
        public List<Worker> WorkerPerSalary { get; set; }
        public int Amount { get; set; }
        public void OnGet()
        {
            workers = _Context.Wokers.Include(x=>x.SuperVisor).ToList();
            Amount = _Context.Wokers.Count();
            WorkerPerSalary = _Context.Wokers.Where(x => x.SalaryPerHour >= 10).ToList();
        }
    }
}
