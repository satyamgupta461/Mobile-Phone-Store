using Microsoft.AspNetCore.Mvc;
using MobilePhoneStore.Models;

namespace MobilePhoneStore.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class MobileController : Controller
    {
        private MyDbContext _myDbContext;

        public MobileController(MyDbContext myDbContext)
        {
            this._myDbContext = myDbContext;
        }

        [HttpGet]
        public IEnumerable<Mobile> GetMobiles()
        {
            return _myDbContext.Mobiles.ToList();
        }

        [HttpPost]
        public async Task<string> Post([FromBody] Mobile mobile)
        {
            await _myDbContext.Mobiles.AddAsync(mobile);
            await _myDbContext.SaveChangesAsync();
            return "Mobile Details Added Successfully!!";
        }

        [HttpPut("{id}")]
        public async Task<string> Put(int id, [FromBody] Mobile mobile)
        {
            Mobile mobile1 =  await _myDbContext.Mobiles.FindAsync(id);
            mobile1.MobileName = mobile.MobileName;
            mobile1.MobileBrand = mobile.MobileBrand;
            mobile1.CostPrice = mobile.CostPrice;
            mobile1.MRP = mobile.MRP;
            mobile1.Discount = mobile.Discount;
            mobile1.SellingDate = mobile.SellingDate;
            _myDbContext.SaveChanges();
            return "Updated Successfully!!";

        }

        [HttpDelete("{id}")]
        public async Task<string> Delete(int id)
        {
            Mobile mobile = await _myDbContext.Mobiles.FindAsync(id);
            _myDbContext.Mobiles.Remove(mobile);
            _myDbContext.SaveChanges();
            return "Deleted Successfully!!!";

        }
    }
}
