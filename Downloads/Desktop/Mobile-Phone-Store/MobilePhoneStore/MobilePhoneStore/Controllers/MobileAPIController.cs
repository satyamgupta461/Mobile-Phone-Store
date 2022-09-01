using Microsoft.AspNetCore.Mvc;
using MobilePhoneStore.Models;

namespace MobilePhoneStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MobileAPIController : Controller
    {
        private MyDbContext _myDbContext;
        public MobileAPIController(MyDbContext myDbContext)
        {
            this._myDbContext = myDbContext;
        }

        [HttpGet]

        public List<Mobile> getMonthlySales(DateTime from, DateTime to)
        {
            List<Mobile> result = new List<Mobile>();
            var AllDetails = _myDbContext.Mobiles.ToList();
            foreach (var sellDetails in AllDetails)
            {
                if(sellDetails.SellingDate.Year == from.Year && sellDetails.SellingDate.DayOfYear >= from.DayOfYear && sellDetails.SellingDate.DayOfYear <= to.DayOfYear)
                {
                    result.Add(sellDetails);
                }
            }
            return result;
        }
    }
}
