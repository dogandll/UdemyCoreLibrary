namespace Solid.App.SRPBad
{
    /*
 * Single Responsibility Principle - Tek sorumluluk biçimi 
 * Yani bir klass bir iş yapsın birden fazla sorumluluğu olması
 * İhlal eden yazım ile ilgili örnek aşağıdaki gibidir.
 * ******* Projede birden fazla sorumluluk tek klas'a yüklenmiştir ve SRP ihlal edilmiştir ********
 * Konsola yazma
 *  Liste tutma , 
 * Repository Update  Delete işlemleri
 * 
 */
    public class Product
    { 
        public int Id { get; set; }
        public string Name { get; set; }

        private static List<Product> ProductList = new List<Product>();

        public List<Product> GetProducts => ProductList;

        public Product()
        {
            ProductList = new() {
                new() { Id = 1, Name = "Kalem 1" },
                new() { Id = 2, Name = "Kalem 2" },
                new() { Id = 3, Name = "Kalem 3" },
                new() { Id = 4, Name = "Kalem 4" },
                new() { Id = 5, Name = "Kalem 5" }
            };
        }

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

        public void WriteToConsole()
        {
            ProductList.ForEach(x => Console.WriteLine($"{x.Id} - {x.Name}"));

        }
    }
}
