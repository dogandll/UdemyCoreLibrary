namespace Solid.App.SRP.DIPGoodAndBad
{

    /*
     * 
     * Dependency Inversion Prenciple :  High level modül ile low level modüller üzerinde bağlı olmayacak , her ikiside soyutlama üzerinden birbiri ile haberleşecek .   
     * Interface veya abstract  kullanarak   servislerin çağrılmasını implement etmekteyiz.
     * Kodlamada akış aşağıdan yukarıya doğrudur dependency ile yukarıdan aşağıya doğru akış sağlayabiliriz. (Inversion )
     * 
     */
    #region DIPBad
    //public class ProductService
    //{
    //    private readonly ProductRepositoryFromSqlServer _repository;

    //    public ProductService(ProductRepositoryFromSqlServer repository)
    //    {
    //        _repository = repository;
    //    }

    //    public List<string> GetAll()
    //    {
    //        return _repository.GetAll();
    //    }
    //}

    //public class ProductRepositoryFromSqlServer
    //{
    //    public List<string> GetAll()
    //    {
    //        return new List<string>
    //        {
    //            "Sql Server Kalem 1","Sql Server Kalem 2"
    //        };
    //    }
    //}

    #endregion

    #region DIPGood
    public class ProductService
    {
        private readonly IRepository _repository;

        public ProductService(IRepository repository)
        {
            _repository = repository;
        }

        public List<string> GetAll()
        {
            return _repository.GetAll();
        }
    }
    public interface IRepository
    {
        public List<string> GetAll();
    }
    public class ProductRepositoryFromSqlServer : IRepository
    {
        public List<string> GetAll()
        {
            return new List<string>
            {
                "Sql Server Kalem 1","Sql Server Kalem 2"
            };
        }
    }
    public class ProductRepositoryFromMongoDb : IRepository
    {
        public List<string> GetAll()
        {
            return new List<string>
            {
                "Mongo Db Kalem 1","Mongo Db Kalem 2"
            };
        }
    }

    #endregion


}
