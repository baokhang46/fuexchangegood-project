using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BussinessObject.Model;

namespace FUGoodsExchange.Pages.OrderList
{
    public class IndexModel : PageModel
    {
        private readonly BussinessObject.Model.FugoodExchangeContext _context;

        public IndexModel(BussinessObject.Model.FugoodExchangeContext context)
        {
            _context = context;
        }

        public IList<Order> Order { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Order = await _context.Orders
                .Include(o => o.Buyer)
                .Include(o => o.Product)
                .Include(o => o.Seller).ToListAsync();
        }
    }
}
