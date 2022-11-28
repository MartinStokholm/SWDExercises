namespace MementoTest
{
    public class Caretaker
    {
        private Memento _memento;
        private List<Memento> _history;
        public void SetMemento(Memento memento)
        {
            _memento = memento;
        }
        public Memento GetMemento()
        {
            return _memento;
        }
    }
}