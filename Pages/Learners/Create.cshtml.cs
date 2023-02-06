using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CapenexisLearners2022.Data;
using CapenexisLearners2022.Models;

namespace CapenexisLearners2022.Pages.Learners
{
    public class CreateModel : PageModel
    {
        private readonly CapenexisLearners2022.Data.CapenexisLearners2022Context _context;

        public CreateModel(CapenexisLearners2022.Data.CapenexisLearners2022Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Learner Learner { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Learner == null || Learner == null)
            {
                return Page();
            }

            _context.Learner.Add(Learner);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
