using _17_NorthwindModels.Models.Abstract;

namespace _17_NorthwindModels.Models.Concrete
{
    public class User : BaseEntity<int>
    {
        public string FullName { get; set; }
    }
}
