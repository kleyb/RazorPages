using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Models;

namespace RazorPages.Pages
{
    public class PeopleModel : PageModel
    {
        private readonly DBContext _context;



        [BindProperty]
        public Person NewPerson { get; set; }

        public List<Person> People { get; set; } = new List<Person>();

        public PeopleModel(DBContext context)
        {
            _context = context;
        }    
        public void OnGet()
        {
           People = _context.People.ToList();
        }

        public IActionResult OnPost()
        {
            _context.People.Add(NewPerson);
            _context.SaveChanges();


            return RedirectToPage();
        }
    }
}
