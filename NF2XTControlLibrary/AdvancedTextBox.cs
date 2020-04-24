using System;
using System.Drawing;
using System.Windows.Forms;

namespace nForce2XTLibrary
{
    public partial class AdvancedTextBox : UserControl
    {
        private const byte MIN_VALUE = byte.MinValue;
        private const byte MAX_VALUE = byte.MaxValue;
        private bool readonlyMode;
        private byte timing = MAX_VALUE;

        public AdvancedTextBox()
        {
            InitializeComponent();
        }

        public virtual bool IsValueValid(byte value)
        {
            return value >= Min && value <= Max;
        }

        public byte Value
        {
            get
            {
                bool success = byte.TryParse(textBox.Text.Trim().ToLower(), System.Globalization.NumberStyles.HexNumber,
                    null as IFormatProvider, out byte byteValue);
                if (success)
                {
                    return byteValue;
                }
                return 0;
            }

            set
            {
                if (IsValueValid(value))
                    timing = value;

                textBox.Text = timing.ToString("X2");
                textBox.BackColor = SystemColors.Window;
            }
        }

        public int Min { get; set; } = MIN_VALUE;
        public int Max { get; set; } = MAX_VALUE;
        public bool Changed => timing != Value;
        public bool Readonly
        {
            get => readonlyMode;
            set
            {
                readonlyMode = value;
                textBox.Enabled = !value;
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (Changed)
                textBox.BackColor = SystemColors.Info;
            else
                textBox.BackColor = SystemColors.Window;

            // textBox.Text = textBox.Text.ToUpper();
            textBox.ForeColor = SystemColors.WindowText;
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ("abcdefABCDEF0123456789".IndexOf(e.KeyChar) == -1 && e.KeyChar != Convert.ToChar(Keys.Back))
                e.Handled = true;
        }

        private void TextBox_Click(object sender, EventArgs e)
        {
            textBox.SelectionStart = 0;
            textBox.SelectionLength = 2;
        }
    }
}
