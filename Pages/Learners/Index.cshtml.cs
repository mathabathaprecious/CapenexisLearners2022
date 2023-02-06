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
    public class IndexModel : PageModel
    {
        private readonly CapenexisLearners2022.Data.CapenexisLearners2022Context _context;

        public IndexModel(CapenexisLearners2022.Data.CapenexisLearners2022Context context)
        {
            _context = context;
        }

        public IList<Learner> Learner { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Learner != null)
            {
                Learner = await _context.Learner.ToListAsync();
            }
        }
    }
}
