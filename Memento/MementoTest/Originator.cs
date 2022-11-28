namespace MementoTest
{
    public class Originator
    {
        class Memento
        {
            private string _state;
            private string State { get; set; }
        
        }

        public Memento Save()
        {
            return new Memento(_state);
        }
        public string restore(Memento memento)
        {
            _state = memento.State;
        }
    }
}