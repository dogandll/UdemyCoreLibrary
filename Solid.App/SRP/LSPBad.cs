namespace Solid.App.SRP.LSPBad
{
    /*
     *
     * Liskov Substitution Prensibinde class 'lar arası özellikler çağrılırken uygun olmayan özellik bir class'a geldiği zaman uygulamanın patlamaması gerekmektedir. 
     * 
     * Aşağıda uygulamayı patalatacak yazım örneğimiz mevcuttur.
     *
     */
    public abstract class BasePhone
    {
        public void Call()
        {
            Console.WriteLine("Arama yapıldı !");
        }
        public abstract void TakePhoto();
    }

    public class IPhone : BasePhone
    {
        public override void TakePhoto()
        {
            Console.WriteLine("Fotoğraf çekildi !");
        }
    }

    public class Nokia3310 : BasePhone
    {
        public override void TakePhoto()
        {
            throw new NotImplementedException();
        }
    }
}
