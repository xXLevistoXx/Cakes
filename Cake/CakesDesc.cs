namespace Cake
{
    public class CakesDesc
    {
        public string Name;
        public int Price;
        public static List<int> Chosen_Price_Element;
        public static List<string> Chosen_Element = null;
        public static int cost;
        public CakesDesc(string boxName_Of_Element,  int boxPrice_Of_Element)
        {
            Name = boxName_Of_Element;
            Price = boxPrice_Of_Element;
        }
    }
}
