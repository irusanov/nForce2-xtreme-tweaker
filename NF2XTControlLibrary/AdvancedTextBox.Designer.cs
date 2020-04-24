namespace nForce2XTLibrary
{
    partial class AdvancedTextBox
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Location = new System.Drawing.Point(0, 0);
            this.textBox.MaxLength = 2;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(26, 20);
            this.textBox.TabIndex = 0;
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox.Click += new System.EventHandler(this.TextBox_Click);
            this.textBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // AdvancedTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "AdvancedTextBox";
            this.Size = new System.Drawing.Size(26, 22);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
    }
}
