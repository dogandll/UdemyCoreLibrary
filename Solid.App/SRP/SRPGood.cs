using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.App.SRPGood
{ 
    /*
     * Single Responsibility Principle - Tek sorumluluk biçimi 
     * Yani bir klass bir iş yapsın birden fazla sorumluluğu olması
     * İhlal etmeyen yazım ile ilgili örnek aşağıdaki gibidir.
     * ******* Projede birden fazla sorumluluk tek klas'a yüklenmemiştir , SRP ihlal edilmemiştir ********
     * Konsola yazma - (Presenter class)
     *  Liste tutma  - Update -  Delete işlemleri - (Repository class), 
     *  Product class (Entity class)
     * 
     */
    public class Product
    {

        public int Id { get; set; }
        public string Name { get; set; } 
    } 
    public class ProductRepository
    {
        private static List<Product> ProductList = new List<Product>(); 
        public ProductRepository()
        {
            ProductList = new() {
                new() { Id = 1, Name = "Kalem 1" },
                new() { Id = 2, Name = "Kalem 2" },
                new() { Id = 3, Name = "Kalem 3" },
                new() { Id = 4, Name = "Kalem 4" },
                new() { Id = 5, Name = "Kalem 5" }
            };
        }
        public List<Product> GetProducts => ProductList;
        public void SaveOrUpdate(Product p)
        {
            var hasProduct = ProductList.Any(x => x.Id == p.Id);
            if (!hasProduct)
            {
                ProductList.Add(p);
            }
            else
            {
                var index = ProductList.FindIndex(x => x.Id == p.Id);
                ProductList[index] = p;

            }
        }

        public void Delete(int id)
        {
            var hasProduct = ProductList.Find(x => x.Id == id);
            if (hasProduct == null)
            {
                throw new Exception("Ürün bulunamadı !");
            }
            ProductList.Remove(hasProduct);
        }

    } 
    public class ProductPresenter
    {
        public void WriteToConsole(List<Product>ProductList)
        {
            ProductList.ForEach(x => Console.WriteLine($"{x.Id} - {x.Name}"));

        }
    }
}
