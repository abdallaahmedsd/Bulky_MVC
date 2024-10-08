using BulkyWebRazor_Temp.Data;
using BulkyWebRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWebRazor_Temp.Pages.Categories
{
    public class CreateModel : PageModel
    {
		private readonly AppDbContext _context;

		public CreateModel(AppDbContext context)
		{
			_context = context;
		}

		[BindProperty]
		public Category Category { get; set; }

		public void OnGet()
        {
        }

		public IActionResult OnPost() 
		{		
			_context.Categories.Add(Category);
			_context.SaveChanges();

            TempData["success"] = "Category created successfully!";
            return RedirectToPage("Index");
		}
    }
}
