namespace CardGame.Cards
{
    // Card is made as base class 
    public abstract class Card 
    {

        public int GetValue(){
            return value * suit;
        }

        // Overriding the base objects ToString()
        public override string ToString(){
            return suitName + " " + value + " (" + GetValue() + ")"; 
        }

        private int value { get; protected set; }
        private int suit { get; protected set; }
        public string suitName { get; protected set; }

    }
}