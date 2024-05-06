using _17_NorthwindModels.Models.Abstract;

namespace _17_NorthwindModels.Models.Concrete
{
    public class Shipper : BaseEntity<int>
    {

        public string CompanyName { get; set; }
        public string Phone { get; set; }

    }
}
