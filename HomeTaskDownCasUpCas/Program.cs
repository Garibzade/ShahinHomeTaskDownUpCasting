using HomeTaskDownCasUpCas.Models;
using HomeTaskDownCasUpCas.Models2;
using System.Reflection;

namespace HomeTaskDownCasUpCas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region TaskinIlkHissesi
            Apple apple = new Apple(5.6m, "Seki Almasi", 40, 45);
            Pinapple pinapple = new Pinapple(6.4m, "Seki Ananasi", 50, 55);
            Orange orange = new Orange(7.9m, "Lokbatan Portagali", 60);

            Fruit[] basket = { apple, pinapple, orange };

            foreach (var fruit in basket)
            {
                Type fruitType= fruit.GetType();
                Console.WriteLine(fruitType.Name);
                FieldInfo[] fields = fruitType.GetFields();
                foreach (var item in fields)
                {
                    Console.WriteLine(item.GetValue(fruit));
                }
            }
            #endregion


            #region TaskinIkinciHissesi
            Lion lion = new Lion("Xaski",true);
            Cow cow = new Cow("Lokbatan ineyi");

            Animal[] animals = { cow, lion };
            foreach (var animal in animals)
            {
                if (animal is Cow)
                {
                    Cow cow2 = (Cow)animal;
                    Grass grass = new Grass("Goyerti", 3000);
                    cow2.EatFood(grass);
                    cow2.ProducedMilk();
                }
                else if (animal is Lion) 
                {
                    Lion lion2 = (Lion)animal;
                    Meat meat = new Meat(30000,"Qirmizi et");
                    lion2.EatFood(meat);
                    
                }
            }
            #endregion
        }
    }
}
