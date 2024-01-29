namespace Solid.App.SRP.LSPGood
{
    /*
     *
     * Liskov Substitution Prensibinde class 'lar arası özellikler çağrılırken ortak olmayan özellik bir class'a çağrılması için interface'den yararlanırız, bu şekilde interface özelliği almayan class'da ilgili özellik gelmeyecektir. 
     * 
     *  
     *
     */

    public interface ITakePhoto
    {
        void TakePhoto();
    }

    public abstract class BasePhone
    {
        public void Call()
        {
            Console.WriteLine("Arama yapıldı !");
        }

    }

    public class IPhone : BasePhone, ITakePhoto
    {
        public void TakePhoto()
        {
            Console.WriteLine("Foto çekildi !");
        }
    }

    public class Nokia3310 : BasePhone
    {

    }
}
