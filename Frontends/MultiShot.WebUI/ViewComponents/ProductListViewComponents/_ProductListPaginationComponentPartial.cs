﻿using Microsoft.AspNetCore.Mvc;

namespace MultiShot.WebUI.ViewComponents.ProductListViewComponents
{
    public class _ProductListPaginationComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }


    }
}
