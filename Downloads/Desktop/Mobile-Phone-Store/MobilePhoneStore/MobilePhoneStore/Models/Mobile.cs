using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MobilePhoneStore.Models
{
    public class Mobile
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string MobileName { get; set; }
        public string MobileBrand { get; set; }
        public int CostPrice { get; set; }
        public int MRP { get; set; }
        public int Discount { get; set; }
        public DateTime SellingDate { get; set; }


    }
}
