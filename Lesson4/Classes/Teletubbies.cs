namespace TeletubbiesConsoleApp.Classes
{
    // This is the implementation of observer
    public class Teletubbies : ITeletubbies
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public Teletubbies(BigTelephone bigTelephone, string name, string color)
        {
            bigTelephone.Attach(this); 
            Name = name;
            Color = color;
        }

        public void Update(BigTelephoneData state)
        {
            Console.WriteLine($"Teletubbies {Name} is notified");

        }

    }
}