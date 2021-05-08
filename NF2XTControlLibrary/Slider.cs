﻿using System;
using System.Windows.Forms;

namespace nForce2XTLibrary
{
    public partial class Slider : UserControl
    {
        private void UpdateButtonsState()
        {
            int value = trackBar.Value;
            int max = trackBar.Maximum;
            int min = trackBar.Minimum;
            buttonDec.Enabled = value != min;
            buttonInc.Enabled = value != max;
        }

        public Slider()
        {
            InitializeComponent();
        }

        public TickStyle TickStyle
        {
            get { return trackBar.TickStyle; }
            set { trackBar.TickStyle = value; }
        }

        public int TickFrequency
        {
            get { return trackBar.TickFrequency; }
            set { trackBar.TickFrequency = value; }
        }

        public int Maximum
        {
            get { return trackBar.Maximum; }
            set { trackBar.Maximum = value; }
        }

        public int Minimum
        {
            get { return trackBar.Minimum; }
            set { trackBar.Minimum = value; }
        }

        public int LargeChange
        {
            get { return trackBar.LargeChange; }
            set { trackBar.LargeChange = value; }
        }

        public int SmallChange
        {
            get { return trackBar.SmallChange; }
            set { trackBar.SmallChange = value; }
        }

        public int Value
        {
            get { return trackBar.Value; }
            set { trackBar.Value = value; }
        }

        private void ButtonInc_Click(object sender, EventArgs e)
        {
            if (trackBar.Value != trackBar.Maximum)
            {
                trackBar.Value += trackBar.SmallChange;
            }
        }

        private void ButtonDec_Click(object sender, EventArgs e)
        {
            if (trackBar.Value != trackBar.Minimum)
            {
                trackBar.Value -= trackBar.SmallChange;
            }
        }

        private void TrackBar_ValueChanged(object sender, EventArgs e)
        {
            this.Value = trackBar.Value;
            label1.Text = $"{Value:F2}MHz";
            UpdateButtonsState();
        }

        private void TrackBar_Layout(object sender, LayoutEventArgs e)
        {
            UpdateButtonsState();
        }
    }
}
