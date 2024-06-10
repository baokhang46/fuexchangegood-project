using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BussinessObject.Model;

namespace FUGoodsExchange.Pages.OrderList
{
    public class CreateModel : PageModel
    {
        private readonly BussinessObject.Model.FugoodExchangeContext _context;

        public CreateModel(BussinessObject.Model.FugoodExchangeContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["BuyerId"] = new SelectList(_context.Buyers, "BuyerId", "BuyerId");
        ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "ProductId");
        ViewData["SellerId"] = new SelectList(_context.Sellers, "SellerId", "SellerId");
            return Page();
        }

        [BindProperty]
        public Order Order { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Orders.Add(Order);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
