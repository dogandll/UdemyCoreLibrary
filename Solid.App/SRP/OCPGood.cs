namespace Solid.App.SRP.OCPGood
{
    public class OCPGood2
    {
        /*
         * ilk önce switch - case blogu ve enum'dan kurtuluyoruz. 
         * Sonrasında interface özelliğinden yararlanarak genel hesaplama interface oluşturuyoruz. Her hesaplama türü için ayrı class oluşturuyoruz.
         * 4. bir maaş tipi eklenmek istenildiğinde artık eklemek çok kolay , yeni class işimizi çözmektedir.
         */

        public interface ISalaryCalculate
        {
            decimal Calculate(decimal salary);
        }

        public class LowSalaryCalculate : ISalaryCalculate
        {
            public decimal Calculate(decimal salary)
            {
                return salary * 2;
            }
        }
        public class MiddleSalaryCalculate : ISalaryCalculate
        {
            public decimal Calculate(decimal salary)
            {
                return salary * 4;
            }
        }
        public class HighSalaryCalculate : ISalaryCalculate
        {
            public decimal Calculate(decimal salary)
            {
                return salary * 6;
            }
        }
        public class ManagerSalaryCalculate : ISalaryCalculate
        {
            public decimal Calculate(decimal salary)
            {
                return salary * 7;
            }
        }


        public class SalaryCalculator
        {
            public decimal Calculate(decimal salary, ISalaryCalculate salaryCalculate)
            {
                return salaryCalculate.Calculate(salary);
            }
        }

    }
}
