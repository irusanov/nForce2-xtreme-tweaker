namespace nForce2XTLibrary
{
    public partial class BooleanTimingItem : nForce2XTLibrary.TimingItem
    {
        public override void PopulateItems()
        {
            for (var i = 0; i < Items.Length; ++i)
            {
                CustomListItem item = new CustomListItem(i, string.Format(Format, Items[i]));
                comboBoxTiming.Items.Add(item);
                if (i == timing) comboBoxTiming.SelectedItem = item;
            }
        }

        public string[] Items { get; set; } = { "Disabled", "Enabled" };

        public BooleanTimingItem()
        {
            InitializeComponent();
        }
    }
}
