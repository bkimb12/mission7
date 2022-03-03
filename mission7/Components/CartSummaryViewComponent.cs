using Microsoft.AspNetCore.Mvc;
using mission7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mission7.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Basket basket { get; set; }

        public CartSummaryViewComponent(Basket cartService)
        {
            basket = cartService;
        }
        public IViewComponentResult Invoke()
        {
            return View(basket);
        }

    }
}
