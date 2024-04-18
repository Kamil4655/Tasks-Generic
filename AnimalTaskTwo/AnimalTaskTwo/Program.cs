using AnimalTaskTwo.Modelss;

namespace AnimalTaskTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cow cow = new Cow("Qarabagh cow");
            Lion lion = new Lion("Sir Hemise Sirdi :)", true);

            Animal[] animals = { cow, lion };
            foreach (var animal in animals)
            {
                if (animal is Lion lion1)
                {
                    Console.WriteLine(" ");
                    Meat meat = new Meat(550, "meat");
                    lion1.MadeSound();
                    lion1.EatFood(meat);
                }
                if (animal is Cow cow1)
                {

                    Grass grass = new Grass(250, "grass");
                    cow1.ProductMilk();
                    cow1.EatFood(grass);
                    cow1.MadeSound();
                }


            }

        }
    }
}
