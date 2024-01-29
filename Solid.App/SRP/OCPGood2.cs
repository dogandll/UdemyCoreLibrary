namespace Solid.App.SRP.OCPGood2
{
    public class OCPGood2
    {
        /*
         * 
         * İlgili işlemi interface yerine  delegate yöntemi ile de kullanarak ilerletebiliyoruz. 
         * 
         *************** Delegate tipleri***********************
         *    //Action => void  değer döndüren delegate
         *    //Predicate => bool değer döndürür delegate
         *    //Function => isteğin tipde döndürebiliyorsun delegate
         * 
         */




        public class LowSalaryCalculate
        {
            public decimal Calculate(decimal salary)
            {
                return salary * 2;
            }
        }
        public class MiddleSalaryCalculate
        {
            public decimal Calculate(decimal salary)
            {
                return salary * 4;
            }
        }
        public class HighSalaryCalculate
        {
            public decimal Calculate(decimal salary)
            {
                return salary * 6;
            }
        }
        public class ManagerSalaryCalculate
        {
            public decimal Calculate(decimal salary)
            {
                return salary * 7;
            }
        }


        public class SalaryCalculator
        {



            public decimal Calculate(decimal salary, Func<decimal, decimal> calculateDelegate)
            {
                return calculateDelegate(salary);
            }
        }

    }
}
