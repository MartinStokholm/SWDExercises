namespace flashlightapp 
{
    public abstract class FlashLightState
    {
        public void HandleLightOn(Flashlight flashlight){}
        public void HandleLightOff(Flashlight flashlight){}
    }

    public class FlashLightOn : FlashLightState
    {
        public new void HandleLightOff(Flashlight flashlight)
        {
            flashlight.LightOff();
            flashlight.state = new FlashLightOff();
        }
    }
    public class FlashLightOff : FlashLightState
    {
        public new void HandleLightOn(Flashlight flashlight)
        {
            flashlight.LightOn();
            flashlight.state = new FlashLightOn();
        }
    }
    public class Flashlight
    {
        FlashLightState flashLightState;
        
        public Flashlight(FlashLightState state)
        {
            this.flashLightState = state;
        }
        public void LightOn()
        {
            System.Console.WriteLine("The light is on");
        }
        public void LightOff()
        {
            System.Console.WriteLine("The light is off");
        }
        public FlashLightState state 
        { 
            get{return flashLightState;} 
            set
            {
                flashLightState = value;
                System.Console.WriteLine("State: " + flashLightState.GetType().Name);
            } 
        }
        public void LightOnPressed()
        {
            flashLightState.HandleLightOn(this);
        }
        public void LightOffPressed()
        {
            flashLightState.HandleLightOff(this);
        }
    }
}