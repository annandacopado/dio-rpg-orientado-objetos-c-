// See https://aka.ms/new-console-template for more information
using RPG.src.Entities;

namespace RPG
{
    class program
    {
         static void Main(string[] args)
       {
            Hero arus =  new Hero("Arus", 48 ,"Knight");
            Hero oponnent  = new Hero("Maleficius",66 , "Devil");
            Wizard wizard  = new Wizard("Jennica",98 , "White Wizard");


            Console.WriteLine(arus);
            Console.WriteLine(wizard.Attack(8));
    
       }
    }
}
