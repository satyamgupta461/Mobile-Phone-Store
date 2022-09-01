using Microsoft.AspNetCore.Mvc;
using MobilePhoneStore.Models;

namespace MobilePhoneStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MobileBrandWiseController : Controller
    {
        private MyDbContext _myDbContext;
        public MobileBrandWiseController(MyDbContext myDbContext)
        {
            this._myDbContext = myDbContext;
        }

        [HttpGet]
        public List<Mobile> getBrandWiseDeatils(string brand, DateTime from, DateTime to)
        {
            List<Mobile> result = new List<Mobile>();
            var brandWiseDetails = _myDbContext.Mobiles.ToList();
            foreach (var sellDetails in brandWiseDetails)
            {
                if (sellDetails.SellingDate.Year == from.Year && sellDetails.SellingDate.DayOfYear >= from.DayOfYear && sellDetails.SellingDate.DayOfYear <= to.DayOfYear && sellDetails.MobileBrand == brand)
                {
                    result.Add(sellDetails);

                }

            }
            return result;
        }
    }
}
