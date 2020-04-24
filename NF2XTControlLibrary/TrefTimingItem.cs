namespace nForce2XTLibrary
{
    public partial class TrefTimingItem : nForce2XTLibrary.TimingItem
    {
        private static readonly int[] items =
        {
            16,
            32,
            64,
            128,
            388,
            516,
            648,
            776,
            780,
            908,
            1032,
            1168,
            1296,
            1536,
            1552,
            1560,
            1816,
            2048,
            2064,
            2336,
            2560,
            2592,
            3072,
            3120,
            3632,
            3684,
            4128,
            4196,
            4672,
            4708,
        };

        public override bool IsValueValid(int value)
        {
            return value >= items[0] && value <= items[items.Length - 1];
        }

        public override void PopulateItems()
        {
            //comboBoxTiming.Items.Clear();
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

        //public int[] Items { get; set; }

        public TrefTimingItem()
        {
            InitializeComponent();
        }
    }
}
