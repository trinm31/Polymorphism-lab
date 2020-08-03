namespace lab2
{
    public class Cat: Animal
    {
        public Cat(string name, string favouriteFood) : base()
        {
            
        }
        /*public override string ExplainSelf()
        {
            return $"I am {Name} and my favourite food is {FavouriteFood} MEEOW";
        }*/
        public override string ExplainSelf()
        {
            return base.ExplainSelf() + "MEEOW";
        }
    }
}