using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorLiveDemoPowerpoint.Data;

namespace RazorLiveDemoPowerpoint.Pages.Employees
{
    public class ReadModel : PageModel
    {
        private readonly ApplicationDbContext _dbContext;
        public List<Employee> Employees { get; set; }

        public ReadModel(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void OnGet()
        {
            Employees = _dbContext.Employees.ToList();
        }
    }
}
