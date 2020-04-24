namespace nForce2XTLibrary
{
    public class CustomListItem
    {
        public int Value { get; } = 0;

        public string Display { get; } = "-";

        public CustomListItem(int value, string display)
        {
            Value = value;
            Display = display;
        }

        public override string ToString()
        {
            return Display;
        }
    }
}