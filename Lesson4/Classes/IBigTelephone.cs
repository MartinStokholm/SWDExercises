namespace TeletubbiesConsoleApp.Classes
{
    // This is the interface for the subject 
    public  interface IBigTelephone
    {
        public void Attach(ITeletubbies teletubbies);
        public void Detach(ITeletubbies teletubbies);

        public abstract void Notify();

    }
}