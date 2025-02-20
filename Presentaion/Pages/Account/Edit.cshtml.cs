using DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Presentaion.Pages.Account;

public class EditModel : PageModel
{
    private readonly TatooWebContext _context;

    public EditModel(TatooWebContext context)
    {
        _context = context;
    }

    [BindProperty] public DataAccess.DataAccess.Account Account { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(Guid? id)
    {
        if (id == null || _context.Accounts == null) return NotFound();

        var account = await _context.Accounts.FirstOrDefaultAsync(m => m.Id == id);
        if (account == null) return NotFound();
        Account = account;
        return Page();
    }

    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see https://aka.ms/RazorPagesCRUD.
    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid) return Page();

        _context.Attach(Account).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!AccountExists(Account.Id))
                return NotFound();
            throw;
        }

        return RedirectToPage("./Index");
    }

    private bool AccountExists(Guid id)
    {
        return (_context.Accounts?.Any(e => e.Id == id)).GetValueOrDefault();
    }
}