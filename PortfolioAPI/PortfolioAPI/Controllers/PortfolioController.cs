using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PortfolioAPI.IServices;
using PortfolioAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PortfolioController : ControllerBase
    {
        private readonly IPortfolioService investorService;
        public PortfolioController(IPortfolioService investor)
        {
            investorService = investor;
        }
        [HttpGet]
        [Route("[action]")]
        [Route("/api​/Portfolio​/GetInvestor")]
        public IEnumerable<Portfolio> GetInvestor()
        {
            return investorService.GetInvestor();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/Portfolio/Addinvestor")]
        public Portfolio AddInvestor(Portfolio portfolio)
        {
            return investorService.AddInvestor(portfolio);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/Portfolio/EditInvestor")]
        public Portfolio EditEmployee(Portfolio portfolio)
        {
            return investorService.UpdateInvestor(portfolio);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/Portfolio/DeleteInvestor")]
        public Portfolio DeleteInvestor(int id)
        {
            return investorService.DeleteInvestor(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Portfolio/GetInvestorId")]
        public Portfolio GetInvestorId(int id)
        {
            return investorService.GetInvestorById(id);
        }
    }
}
