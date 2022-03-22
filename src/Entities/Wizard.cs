namespace RPG.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int level, string HeroType) : base(Name, level, HeroType)
        {
            this.Name= Name;
            this.level=level;
            this.HeroType = HeroType;
        }

        public override string Attack()
        {
            return this.Name + " lançou magia!";
        }
         public String Attack(int bonus){
             if(bonus>6){
                 return this.Name + " lançou uma magia super efetiva com bonus de " + bonus;
             }else
                 return this.Name + " lançou uma magia com força fraca de " + bonus;
            
        }
    }
}