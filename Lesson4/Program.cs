namespace TeletubbiesConsoleApp.Classes
{
    public class TeletubbiesConsoleApp
    {
        public static void Main(string[] args)
        {
            // Create instances of the concrete subject and concrete observer
            BigTelephone bigTelephone = new ConreteBigBigTelphone();
            Teletubbies tinkyWinky = new Teletubbies(bigTelephone,"Tinky Winky", "Purple");
            Teletubbies dipsy = new Teletubbies(bigTelephone,"Dipsy", "Yellow");
            Teletubbies laaLaa = new Teletubbies(bigTelephone,"Laa-Laa", "Pink");
            Teletubbies po = new Teletubbies(bigTelephone,"Po", "Green"); 
            
            BigTelephoneData bigTelephoneData = new BigTelephoneData();

            // Attache the observers to the subjects list
            bigTelephone.Attach(tinkyWinky);
            bigTelephone.Attach(dipsy);
            bigTelephone.Attach(laaLaa);
            bigTelephone.Attach(po);

            Console.WriteLine("Hello Tubbies!");
        }
    }
}
