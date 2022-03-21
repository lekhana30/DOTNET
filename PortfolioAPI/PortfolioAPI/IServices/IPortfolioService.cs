using PortfolioAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioAPI.IServices
{
    public interface IPortfolioService
    {
        IEnumerable<Portfolio> GetInvestor();
        Portfolio GetInvestorById(int id);
        Portfolio AddInvestor(Portfolio portfolio);
        Portfolio UpdateInvestor(Portfolio portfolio);
        Portfolio DeleteInvestor(int id);
    }
}
