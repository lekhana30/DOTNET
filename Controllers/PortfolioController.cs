using Lib.Core.Model;
using Lib.Service.PortfolioService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication11.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly IPortfolioService investorService;
        public PortfolioController(IPortfolioService inService)
        {
            investorService = inService;
        }
        public async Task<IActionResult> List()
        {
            var list = await investorService.GetInvestor();
            return View(list);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Portfolio model)
        {

            if (ModelState.IsValid)
            {
                bool response = await investorService.SavePortfolio(model);

                if (response)
                {
                    return RedirectToAction("List");
                }
            }

            return View(model);
        }
    }
}
