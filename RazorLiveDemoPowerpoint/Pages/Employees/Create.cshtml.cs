using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorLiveDemoPowerpoint.Data;
using RazorLiveDemoPowerpoint.Data.ViewModels;

namespace RazorLiveDemoPowerpoint.Pages.Employees
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext dbContext;

        public CreateModel(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [BindProperty]
        public CreateEmployeeViewModel CreateEmployeeRequest { get; set; }
        public void OnGet()
        {
        }

        public void OnPost()
        {
            var employeeDbModel = new Employee
            {
                Name = CreateEmployeeRequest.Name,
                Email = CreateEmployeeRequest.Email,
                Salary = CreateEmployeeRequest.Salary,
                DateOfBirth = CreateEmployeeRequest.DateOfBirth,
                Department = CreateEmployeeRequest.Department
            };

            dbContext.Employees.Add(employeeDbModel);
            dbContext.SaveChanges();

            ViewData["Message"] = "Employee created successfully!";
        }

    }

}
