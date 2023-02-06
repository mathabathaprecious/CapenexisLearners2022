using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CapenexisLearners2022.Data;
using CapenexisLearners2022.Models;

namespace CapenexisLearners2022.Pages.Learners
{
    public class DetailsModel : PageModel
    {
        private readonly CapenexisLearners2022.Data.CapenexisLearners2022Context _context;

        public DetailsModel(CapenexisLearners2022.Data.CapenexisLearners2022Context context)
        {
            _context = context;
        }

      public Learner Learner { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Learner == null)
            {
                return NotFound();
            }

            var learner = await _context.Learner.FirstOrDefaultAsync(m => m.Id == id);
            if (learner == null)
            {
                return NotFound();
            }
            else 
            {
                Learner = learner;
            }
            return Page();
        }
    }
}
