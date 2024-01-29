namespace Solid.App.SRP.ISPGoodAndBad
{
    /*
     * Interface Segregation Prenciple  | Client'lara özgü interface tanımlamamız gerekmektedir.
     * Bir repository içerisinde hem okuma hem de crud operasyonları yapılıyor fakat client tarafında okuma ayrı yazma ayrı istenildiği zaman respository bu şekilde dizayn etmemisi söylemektedir.
     * 
    * Class Library - Read Impl
    * Class Library - Create / Update / Delete
    */

    //Kötü örnek
    //public interface IProductRepository
    //{
    //    List<Product> GetList();
    //    Product GetById(int id);
    //    Product Create(Product product);
    //    Product Update(Product product);
    //    Product Delete(int id);

    //}

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }

    //1.Class Library
    public class ReadProductRepository : IReadRepository
    { 
        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetList()
        {
            throw new NotImplementedException();
        } 
    }


    //2.Class Library

    public class WriteRepository : IWriteRepository
    {
        public Product Create(Product product)
        {
            throw new NotImplementedException();
        }

        public Product Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product Update(Product product)
        {
            throw new NotImplementedException();
        }
    }


 

    public interface IWriteRepository
    {
        Product Create(Product product);

        Product Update(Product product);
        Product Delete(int id);
    }
    public interface IReadRepository
    {
        List<Product> GetList();
        Product GetById(int id);
    }
}
