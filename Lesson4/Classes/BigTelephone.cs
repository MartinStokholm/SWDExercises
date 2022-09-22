namespace TeletubbiesConsoleApp.Classes
{
    // This is the implementation of the subject 
    public  class BigTelephone : IBigTelephone
    {
        public List<ITeletubbies> _teletubbies = new List<ITeletubbies>();
        public BigTelephoneData _bigTelephoneData = new BigTelephoneData(); 
        public BigTelephone(){

        }

        public void Attach(ITeletubbies teletubbies)
        {
            _teletubbies.Add(teletubbies);  
        }

        public void Detach(ITeletubbies teletubbies)
        {
            _teletubbies.Remove(teletubbies);
        }

        public void Notify()
        {
            foreach (var teletubbies in _teletubbies)
            {
                teletubbies.Update(_bigTelephoneData);
                
            }
        }
        
        public void SetData(BigTelephoneData bigTelephoneData)
        {
            _bigTelephoneData = bigTelephoneData;
        }


    }
}