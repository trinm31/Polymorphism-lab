namespace lab2
{
    public class Dog: Animal
    {
        public Dog(string name, string favouriteFood) : base()
        {
            
        }
        /*public override string ExplainSelf()
        {
            return $"I am {Name} and my favourite food is {FavouriteFood} DJAAF";
        }*/
        public override string ExplainSelf()
        {
            return base.ExplainSelf() + "DJAAF";
        }
        
        
    }
}