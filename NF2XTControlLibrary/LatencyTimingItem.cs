namespace nForce2XTLibrary
{
    public partial class LatencyTimingItem : nForce2XTLibrary.TimingItem
    {
        private static readonly int[] items =
        {
            16,
            32,
            64,
            96,
            128,
            160,
            192,
            224,
            255
        };


        public LatencyTimingItem()
        {
            InitializeComponent();
        }

        public override bool IsValueValid(int value)
        {
            return value >= items[0] && value <= items[items.Length - 1];
        }

        public override void PopulateItems()
        {
            var index = 0;
            foreach (var i in items)
            {
                CustomListItem item = new CustomListItem(i, string.Format(Format, i));
                comboBoxTiming.Items.Add(item);
                if (i == timing) comboBoxTiming.SelectedItem = item;
                if (i < timing) index++;
            }

            if (comboBoxTiming.SelectedIndex == -1 && IsValueValid(timing))
            {
                comboBoxTiming.Items.Insert(index, new CustomListItem(timing, string.Format(Format, timing)));
                comboBoxTiming.SelectedIndex = index;
            }
        }
    }
}
