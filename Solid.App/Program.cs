
#region OCP-BAD
//SalaryCalculator salaryCalculator = new SalaryCalculator();
//Console.WriteLine($"Low salary : {salaryCalculator.Calculate(1000, SalaryType.Low)}");
//Console.WriteLine($"Middle salary : {salaryCalculator.Calculate(1000, SalaryType.Middle)}");
//Console.WriteLine($"High salary : {salaryCalculator.Calculate(1000, SalaryType.High)}");
#endregion 
#region OCP-Good

//using static Solid.App.SRP.OCPGood.OCPGood2;

//SalaryCalculator salaryCalculator = new SalaryCalculator();

//Console.WriteLine($"Low salary :{salaryCalculator.Calculate(1000, new LowSalaryCalculate())}");
//Console.WriteLine($"Middle salary :{salaryCalculator.Calculate(1000, new MiddleSalaryCalculate())}");
//Console.WriteLine($"High salary :{salaryCalculator.Calculate(1000, new HighSalaryCalculate())}");
//Console.WriteLine($"Manager salary :{salaryCalculator.Calculate(1000, new ManagerSalaryCalculate())}");

#endregion 
#region OCP-Good2 

//using static Solid.App.SRP.OCPGood2.OCPGood2;

//SalaryCalculator salaryCalculator = new SalaryCalculator();

//Console.WriteLine($"Low salary :{salaryCalculator.Calculate(1000, new LowSalaryCalculate().Calculate)}");
//Console.WriteLine($"Middle salary :{salaryCalculator.Calculate(1000, new MiddleSalaryCalculate().Calculate)}");
//Console.WriteLine($"High salary :{salaryCalculator.Calculate(1000, new HighSalaryCalculate().Calculate)}");
//Console.WriteLine($"Manager salary :{salaryCalculator.Calculate(1000, new ManagerSalaryCalculate().Calculate)}");
// *Delegate yazıldığı için x anında örnek lazım olursa aşağıdaki gibi fonksiyon yazabiliyoruz.
// */
//Console.WriteLine($"Custom salary:{salaryCalculator.Calculate(1000, x =>
//{
//    return x * 15;
//})}");

#endregion 
#region LSPBad

//using Solid.App.SRP.LSPBad;
/////*
//BasePhone phone = new IPhone();

//phone.Call();
//phone.TakePhoto();

//phone = new Nokia3310();
//phone.Call();
//phone.TakePhoto();

#endregion 
#region LSPGood  
using Solid.App.SRP.LSPGood;

BasePhone phone = new IPhone();

phone.Call();
((ITakePhoto)phone).TakePhoto();

phone = new Nokia3310();
phone.Call(); 

#endregion