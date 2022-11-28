namespace flashlightapp 
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of the Flashlight class
            Flashlight myFlashlight = new Flashlight(new FlashLightOff());
            myFlashlight.LightOnPressed();
            myFlashlight.LightOffPressed();
            System.Console.WriteLine("the end");

        }
    }
}