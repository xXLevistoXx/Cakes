namespace Cake
{
    internal class Program
    {
        static void Main()
        {
            List<string> elements = new List<string>();
            List<int> cost = new List<int>();
            Order.Arrow_Menu(elements, cost);
        }

        public static void Menu(List<string> Chosen_Element, List<int> cost, int position = 0)
        {
            if (position == 0)
            {
                Console.WriteLine("Wellcome to \"Levisto Stuff\"\nCreate your cake \n---------------------------");
                Console.WriteLine("  Chose cake's Shape");
                Console.WriteLine("  Chose cake's Size");
                Console.WriteLine("  Chose cake's Taste");
                Console.WriteLine("  Chose cake's Glaze");
                Console.WriteLine("  Chose cake's Decor");
                Console.WriteLine("  Chose quantity");
                Console.WriteLine("  End_Of_Order");
            }
            if (Chosen_Element != null & position != 9)
            {
                Console.WriteLine("You chose: ");
                foreach (string element in Chosen_Element)
                {
                    Console.WriteLine(element);
                }
            }
            if (cost != null & position != 9)
            {
                Console.WriteLine("Cost of Order:");
                Console.WriteLine("  " + cost.Sum());
            }
            CakesDesc[] Shape = new CakesDesc[]
            {
                 new CakesDesc("  Round", 150),
                 new CakesDesc("  Square", 170),
                 new CakesDesc("  Rectangle", 180)
            };
            CakesDesc[] Size = new CakesDesc[]
            {
                new CakesDesc("  Small", 100),
                new CakesDesc("  Middle", 200),
                new CakesDesc("  Large", 300)
            };

            CakesDesc[] Taste = new CakesDesc[]
            {
                new CakesDesc("  Banana", 150),
                new CakesDesc("  Biscuit", 160),
                new CakesDesc("  Cherry", 200)
            };
            CakesDesc[] Glaze = new CakesDesc[]
            {
                new CakesDesc("  Milk Chocolate", 190),
                new CakesDesc("  White Chocolate", 160),
                new CakesDesc("  Сocoa", 150)
            };
            CakesDesc[] Decor = new CakesDesc[]
            {
                new CakesDesc("  Berries with Fruits", 150),
                new CakesDesc("  Сandies", 190),
                new CakesDesc("  To order", 300)
            };
            CakesDesc[] Amount = new CakesDesc[]
            {
                new CakesDesc("  Whole cake", 500),
                new CakesDesc("  Halh Of Cake", 250),
                new CakesDesc("  One Piece", 130)
            };

            if(position == 3)
            {
                Menu_2(Shape, Chosen_Element, cost);
            }
            else if(position == 4)
            {
                Menu_2(Size, Chosen_Element, cost);
            }
            else if (position == 5)
            {
                Menu_2(Taste, Chosen_Element, cost);
            }
            else if(position == 6)
            {
                Menu_2(Glaze, Chosen_Element, cost);
            }
            else if (position == 7)
            {
                Menu_2(Decor, Chosen_Element, cost);
            }
            else if (position == 8)
            {
                Menu_2(Amount, Chosen_Element, cost);
            }
            if (position != 0 & Chosen_Element != null & position != 9)
            {
                Console.ReadKey();
                Order.Arrow_Menu(Chosen_Element, cost);
            }
            if (position == 9)
            {
                Console.Clear();
                Console.WriteLine("Чтобы сделать еще один заказ, нажите клавишу Escape");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape)
                {
                    Order.Save_Order(Chosen_Element, cost);
                }    
            }
            
        }
        public static void Dobavleniye(int position, CakesDesc[] All_Elements, List<string> Chosen_Element, List<int> cost)
        {
            Chosen_Element.Add(All_Elements[position].Name);
            cost.Add(All_Elements[position].Price);
            Menu(Chosen_Element, cost);
        }
        public static void Menu_2(CakesDesc[] All_Elements, List<string> elemets, List<int> cost)
        {
            Order.DopMenu(All_Elements, elemets, cost);
        }
    }
}