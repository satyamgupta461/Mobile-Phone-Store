using Microsoft.AspNetCore.Mvc;
using MobilePhoneStore.Models;

namespace MobilePhoneStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MobileAccountReportController : Controller
    {
        private MyDbContext _myDbContext;
        public MobileAccountReportController(MyDbContext myDbContext)
        {
            this._myDbContext = myDbContext;
        }

        //Determines full month summary of a particular year
        [HttpGet]

        public object getNetSummary(int month , int year)
        {
            var mobileData = _myDbContext.Mobiles;
            var totalSale = 0;
            var totalSaleAmount = 0;
            var totalCostAmount = 0;
            var totalProfitLoss = 0;

            foreach (var mobile in mobileData)
            {
                if(mobile.SellingDate.Month == month && mobile.SellingDate.Year == year)
                {
                    totalSale++;
                    var sellingPrice = (mobile.MRP - ((mobile.MRP * mobile.Discount) / 100));
                    totalSaleAmount += sellingPrice;
                    totalCostAmount += mobile.CostPrice;
                    totalProfitLoss += (sellingPrice-mobile.CostPrice);
                }
            }
            dynamic response = new
            {
                TotalProductSale = totalSale,
                TotalProductSaleAmount = totalSaleAmount,
                TotalProductCostAmount = totalCostAmount,
                TotalProfitLoss = totalProfitLoss < 0 ? "Loss of " + totalProfitLoss : "Profit of " + totalProfitLoss,
            };
            return response;
        }

    }
}
