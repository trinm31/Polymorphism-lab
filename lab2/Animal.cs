using System;

namespace lab2
{
    public class Animal
    {
        public string Name;
        public string FavouriteFood;

        public Animal()
        {
            
        }

        public Animal(string name,string favouriteFood)
        {
            this.Name = name;
            this.FavouriteFood = favouriteFood;
        }

        public virtual string ExplainSelf()
        {
            return $"I am {Name} and my favourite food is {FavouriteFood} ";
        }
    }
}