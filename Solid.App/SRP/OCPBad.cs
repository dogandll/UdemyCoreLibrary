namespace Solid.App.SRP.OCPBad
{
    public class OCPBad
    {
        /*
         * 
         * Aşağıdaki maaş hesaplamasında yeni enum eklenmesi durumunda Open Closed prensibi ihlal etmektedir , çünkü değişime kapalı , gelişime açık olması gerekiyor !
         * Not : var olan kodu bozmadan ben bu geliştirmeyi ekleyebilir miyiz? Sorusunu sormamız gerekmektedir !
         * 
         */
        public class SalaryCalculator
        {
            public decimal Calculate(decimal salary, SalaryType salaryType)
            {
                decimal newSalary = 0;
                switch (salaryType)
                {
                    case SalaryType.Low:
                        newSalary = salary * 2;
                        break;
                    case SalaryType.High:
                        newSalary = salary * 4;
                        break;
                    case SalaryType.Middle:
                        newSalary = salary * 6;
                        break;
                }
                return newSalary;
            }
        }
        public enum SalaryType
        {
            Low,
            Middle,
            High
        }
    }
}
