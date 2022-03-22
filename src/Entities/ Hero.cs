namespace RPG.src.Entities
{ public class Hero
    {
        public Hero(String Name,int level, String HeroType){
            this.Name= Name;
            this.level=level;
            this.HeroType = HeroType;
        }
        public String Name;
        public int level;
        public String HeroType;

        public override String ToString(){
            return this.Name + " "+ this.level + " "+ this.HeroType;
        }

        public virtual String Attack(){
            return this.Name + " atacou com a sua espada!";
        }

        

 
    }
}