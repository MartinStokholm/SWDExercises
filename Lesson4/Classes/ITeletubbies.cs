namespace TeletubbiesConsoleApp.Classes
{
    // This is interface of observer
    public interface ITeletubbies
    {
        public string Name { get; set; }
        public string Color { get; set; } 

        public void Update(BigTelephoneData state);
        
    }
}