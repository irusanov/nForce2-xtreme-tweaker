using System;
using System.Drawing;
using System.Windows.Forms;

namespace nForce2XTLibrary
{
    public partial class TimingItem : UserControl
    {
        private const int MIN_VALUE = 0;
        private const int MAX_VALUE = 31;
        private bool readonlyMode = false;
        public int timing = -1;
        private int dropdownWidth;

        public virtual bool IsValueValid(int value)
        {
            return value >= MIN_VALUE && value <= MAX_VALUE;
        }
        public virtual void PopulateItems()
        {
            double display = MinDisplay;
            //comboBoxTiming.Items.Clear();

            for (int i = Min; i <= Max; i++)
            {
                CustomListItem item = new CustomListItem(i, string.Format(Format, display));
                comboBoxTiming.Items.Add(item);
                if (i == timing) comboBoxTiming.SelectedItem = item;
                display += Step;
            }
        }

        public TimingItem()
        {
            InitializeComponent();
        }

        public virtual int Value
        {
            get
            {
                if (comboBoxTiming.SelectedItem != null)
                    return (comboBoxTiming.SelectedItem as CustomListItem).Value;
                return -1;
            }
            set
            {
                if (IsValueValid(value))
                    timing = value;

                foreach (CustomListItem item in comboBoxTiming.Items)
                {
                    if (item.Value == value)
                        comboBoxTiming.SelectedItem = item;
                }

                comboBoxTiming.BackColor = SystemColors.Window;
            }
        }
        public int Min { get; set; } = MIN_VALUE;
        public int Max { get; set; } = MAX_VALUE;
        public double MinDisplay { get; set; } = 0.0;
        public double Step { get; set; } = 1.0;
        public virtual string Format { get; set; } = "{0}";
        public bool Changed => timing != Value;
        public bool Readonly
        {
            get => readonlyMode;
            set
            {
                readonlyMode = value;
                comboBoxTiming.Enabled = !value;
            }
        }
        public string Label { get => label1.Text; set => label1.Text = value.Trim(); }

        public int DropdownWidth
        {
            get => dropdownWidth; 
            set
            {
                if (value > 0)
                {
                    dropdownWidth = value;
                    comboBoxTiming.Width = value;
                }
            }
        }

        private void ComboBoxTiming_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Changed)
                comboBoxTiming.BackColor = SystemColors.Info;
            else
                comboBoxTiming.BackColor = SystemColors.Window;

            ForeColor = SystemColors.WindowText;
        }

        private void ComboBoxTiming_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index > -1)
            {
                ComboBox box = ((ComboBox)sender);
                string text = box.GetItemText(comboBoxTiming.Items[e.Index]);
                var color = SystemColors.WindowText;

                if (box.DroppedDown)
                {
                    if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                        e.Graphics.FillRectangle(new SolidBrush(SystemColors.Highlight), e.Bounds);
                    else
                        e.Graphics.FillRectangle(new SolidBrush(box.BackColor), e.Bounds);

                    color = e.ForeColor;
                }

                if (!box.Enabled)
                    color = SystemColors.InactiveCaption;

                e.Graphics.DrawString(text, e.Font, new SolidBrush(color), e.Bounds);
            }
        }

        private void TimingItem_Load(object sender, EventArgs e)
        {
            PopulateItems();
        }
    }
}
