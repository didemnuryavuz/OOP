namespace _17_NorthwindModels.Models.Concrete;
using _17_NorthwindModels.Services.Concrete;

internal class Program
{
    static void Main(string[] args)
    {
        //Generic Ornek

        
        //List<Customer> customers = new List<Customer>();
        //List<Category> categories = new List<Category>();
        //List<string> tags = new List<string>();
        //List<int> ids = new List<int>();

        //Category category = new Category();
        //category.Id = 1;
        //Customer customer = new Customer();
        //customer.Id = "QWE";

        UserManager userManager = new UserManager();
        User user = new User() { FullName = "Ali Yilmaz", Id = 1 };
        userManager.Insert(user);

        CategoryManager categoryManager = new CategoryManager();
        Category category = new Category() { CategoryName = "Testil", Description = "Tekstil", Id = 1 };
        categoryManager.Insert(category);
    }
}
