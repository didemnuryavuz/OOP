using _11_TekrarInterfaceKalitim.Abstract;
using _11_TekrarInterfaceKalitim.Concrete;
using _11_TekrarInterfaceKalitim.Dapper;
using _11_TekrarInterfaceKalitim.Models;

namespace _11_TekrarInterfaceKalitim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region GetShipperList()

            //ShipperManager shipperManager = new ShipperManager();
            //var liste = shipperManager.GetShipperList();

            //foreach (var shipper in liste)
            //{
            //    Console.WriteLine($"Id:{shipper.ShipperId}\tFirma:{shipper.CompanyName}\tTelefon:{shipper.Phone} ");
            //} 
            #endregion

            #region GetShipperOrdersList()

            //ShipperManager shipperManager = new ShipperManager();
            //var liste1 = shipperManager.GetShipperOrdersList(2,1997);
            //foreach (var item in liste1)
            //{
            //    Console.WriteLine($"id:{item.OrderId}\tFirma:{item.CustomerID}\tCalisan:{item.EmployeeID}\tSiparis Tarihi:{item.OrderDate}\tUlke:{item.ShipCountry}\tSehir:{item.ShipCity} ");
            //}

            #endregion

            #region Add Category
            //string sql = $@"insert into Categories 
            //   (CategoryName,Description) 
            //    values ('Tekstil','Giyim Kusam')

            //";
            //int sonuc = categoryService.Add(sql);
            //if(sonuc>0)
            //    Console.WriteLine("Kayit Basarili");
            #endregion

            #region Category Products

            //CategoryManager categoryManager = new CategoryManager();
            //var liste = categoryManager.GetProducts(2);
            //foreach (var item in liste)
            //{
            //    Console.WriteLine($"{item.ProductId}\t{item.ProductName}\t{item.CategoryName}\t{item.UnitPrice}\t{item.UnitInStock}");

            //}
            #endregion

            #region Dapper ile Veri Cekme

            //CategoryManager categoryManager = new CategoryManager();
            //var liste = categoryManager.GetProducts(3);
            //foreach (var item in liste)
            //{
            //    Console.WriteLine($"{item.ProductId}\t{item.ProductName}\t{item.CategoryName}\t{item.UnitPrice}\t{item.UnitInStock}");

            //}

            #region CustomerManager

            //CustomerManager customerManager = new CustomerManager();
            //var liste = customerManager.aylikMusteriRapor(1997);

            //foreach (var item in liste)
            //{
            //    Console.WriteLine(($"{item.CompanyName}\t{item.Ay}\t{item.Adet}"));
            //}
            #endregion
            #endregion

            #region Interface ile Calismak

            // Interface'ler veri tipi olarak kullanilabilir
            //Boyle bir durumda sadece Interface'de ki yetenekleri alacak sekilde bir instance olusturulur
            ICategoryService AdoCategoryService = new CategoryManager();
            ICategoryService DapperCategoryService = new CategoryManagerd();

            #endregion
        }
    }
}
