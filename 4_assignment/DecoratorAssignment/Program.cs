using static DecoratorAssignment.Program;

namespace DecoratorAssignment
{
    // Instructions
    // You can implement your whole solution here
    // Optionally you can use folder structure if you deem it necessary
    // For this Assignment we will use Decorator pattern example introduced in the book Head First Design Patterns by O'Reilly
    // Chapeter 3 the DecoratorPattern: Decorating Objects (starts at page 79)
    // Link to pdf: https://github.com/ajitpal/BookBank/blob/master/%5BO%60Reilly.%20Head%20First%5D%20-%20Head%20First%20Design%20Patterns%20-%20%5BFreeman%5D.pdf
    // NOTE: Remember that the code examples in this book are written in java so you can't just copy the code examples given there
    public class Program
    {

        public abstract class Beverage
        {
            protected string description = "No coffee";
            public string GetDescription() => description;
            public abstract decimal Cost();

        }

        public class HouseBlend : Beverage
        {
            public HouseBlend() { description = "House Blend Coffee"; }
            public override decimal Cost() => 0.89M;
        }
        public class DarkRoast : Beverage
        {
            public DarkRoast() { description = "Dark Roast Coffee"; }
            public override decimal Cost() => 0.99M;
        }
        public class Decaf : Beverage
        {
            public Decaf() { description = "Decaf Coffee"; }
            public override decimal Cost() => 1.05M;
        }

        public class Espresso : Beverage
        {
            public Espresso() { description = "Espresso"; }
            public override decimal Cost() => 1.99M;
        }

        // Create Decorator class
        public abstract class CondimentDecorator : Beverage
        {
            public Beverage beverage; // composition. reference to beverage to wrap. 
        }

        public class Milk : CondimentDecorator
        {
            public Milk(Beverage beverage)
            {
                this.beverage = beverage;
                description = beverage.GetDescription() + ", Milk";
            }
            public override decimal Cost() => beverage.Cost() + 0.20M;

        }

        public class Mocha : CondimentDecorator
        {
            public Mocha(Beverage beverage)
            {
                this.beverage = beverage;
                description = beverage.GetDescription() + ", Mocha";
            }

            public override decimal Cost() => beverage.Cost() + 0.20M;
        }
        public class Soy : CondimentDecorator
        {
            public Soy(Beverage beverage)
            {
                this.beverage = beverage;
                description = beverage.GetDescription() + ", Soy";
            }
            public override decimal Cost() => beverage.Cost() + 0.15M;

        }
        public class Whip : CondimentDecorator
        {
            public Whip(Beverage beverage)
            {
                this.beverage = beverage;
                description = beverage.GetDescription() + ", Whip";
            }

            public override decimal Cost() => beverage.Cost() + 0.10M;

        }
        static void Main(string[] args)
        {

            Beverage beverage = new Decaf();
            beverage = new Mocha(beverage);
            beverage = new Whip(beverage);
            Console.WriteLine(beverage.GetDescription()); //"Decaf Coffee, Mocha, Whip"
            Console.WriteLine(beverage.Cost()); // 1.35M

        }
    }
}