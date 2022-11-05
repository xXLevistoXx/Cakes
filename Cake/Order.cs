namespace Cake
{
    public class Order
    {
        private static string path = "C:\\Users\\tttll\\Desktop\\YourOrder.txt";
        public static ConsoleKeyInfo key = Console.ReadKey();
        public static void Arrow_Menu(List<string> elements, List<int> cost)
        {
                int position = 1;
                bool rr = true;
                ConsoleKeyInfo arrowUD = new ConsoleKeyInfo();
                while (arrowUD.Key != ConsoleKey.Enter)
                {
                    if (arrowUD.Key == ConsoleKey.UpArrow)
                    {
                        position--;
                        Console.SetCursorPosition(0, position);
                        Console.WriteLine("->");
                    }
                    if (arrowUD.Key == ConsoleKey.DownArrow)
                    {
                        position++;
                        Console.SetCursorPosition(0, position);
                        Console.WriteLine("->");
                    }
                    if (position < 3)
                    {
                        position++;
                        Console.SetCursorPosition(0, position);
                    }
                    if (position > 9)
                    {
                        position--;
                        Console.SetCursorPosition(0, position);
                    }
                    Console.Clear();
                    Program.Menu(elements, cost);
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("->");
                    arrowUD = Console.ReadKey();
                }
                Console.Clear();
                Program.Menu(elements, cost, position);

        }

        public static void DopMenu(CakesDesc[] All_Elements, List<string> elements, List<int> cost)
        {

                int position = 1;
                ConsoleKeyInfo arrowUD = new ConsoleKeyInfo();
                while (arrowUD.Key != ConsoleKey.Enter)
                {
                    if (arrowUD.Key == ConsoleKey.UpArrow)
                    {
                        position--;
                        Console.SetCursorPosition(0, position);
                        Console.WriteLine("->");
                    }
                    if (arrowUD.Key == ConsoleKey.DownArrow)
                    {
                        position++;
                        Console.SetCursorPosition(0, position);
                        Console.WriteLine("->");
                    }
                    if (arrowUD.Key == ConsoleKey.Escape)
                    {
                        Arrow_Menu(elements, cost);
                    }
                    if (position < 0)
                    {
                        position++;
                        Console.SetCursorPosition(0, position);
                    }
                    if (position > 2)
                    {
                        position--;
                        Console.SetCursorPosition(0, position);
                    }
                    Console.Clear();
                    foreach (CakesDesc desc in All_Elements)
                    {
                        Console.WriteLine(desc.Name + "," + desc.Price);
                    }
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("->");
                    arrowUD = Console.ReadKey();
                }
                Console.Clear();
                Program.Dobavleniye(position, All_Elements, elements, cost);

        }
        public static void Save_Order(List<string> elements, List<int> cost)
        {
            string text = "Your order:\n";
            int cost_order = cost.Sum();
            File.AppendAllText(path, text);
            string list = String.Join("\n", elements);
            File.AppendAllText(path, $"{list}");
            File.AppendAllText(path, "\nCost:\n" + cost_order.ToString()+ "\n");
            File.AppendAllText(path, DateTime.Now.ToString());
            File.AppendAllText(path, "\n--------------------------------------");
          elements.Clear();
            cost.Clear();
            Console.Clear();
            Arrow_Menu(elements,cost);
        }
    }
}
