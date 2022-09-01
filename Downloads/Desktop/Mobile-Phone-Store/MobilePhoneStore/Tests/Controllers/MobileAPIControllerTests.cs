using Microsoft.EntityFrameworkCore;
using MobilePhoneStore.Controllers;
using MobilePhoneStore.Models;
using Moq;

namespace Tests.Controllers
{
    [TestFixture]

    public class MobileAPIControllerTests
    {
        [Test]
        public void getMonthlySalesSuccess()
        {
            var mockMobile = new List<Mobile>
            {
                new Mobile()
                {
                     CostPrice = 0,
                     Discount = 0,
                     Id = 1,
                     MobileBrand = "test-brand",
                     MobileName = "test-name",
                     MRP = 0,
                     SellingDate = DateTime.Now
                },
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Mobile>>();
            mockSet.As<IQueryable<Mobile>>().Setup(x => x.Provider).Returns(mockMobile.Provider);
            mockSet.As<IQueryable<Mobile>>().Setup(x => x.Expression).Returns(mockMobile.Expression);
            mockSet.As<IQueryable<Mobile>>().Setup(x => x.ElementType).Returns(mockMobile.ElementType);
            mockSet.As<IQueryable<Mobile>>().Setup(x => x.GetEnumerator()).Returns(mockMobile.GetEnumerator);

            var mockContext = new Mock<MyDbContext>();
            mockContext.Setup(x => x.Mobiles).Returns(mockSet.Object); 
            var mobileApi = new MobileAPIController(mockContext.Object);
            var from = DateTime.Now;
            var to = DateTime.Now;
            var result = mobileApi.getMonthlySales(from, to);
            Assert.That(result, Is.Not.Null);
        }
    }
}
