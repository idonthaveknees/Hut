namespace Hut
{
    partial class Hut
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.WNumeric = new System.Windows.Forms.NumericUpDown();
            this.tNumeric = new System.Windows.Forms.NumericUpDown();
            this.SNumeric = new System.Windows.Forms.NumericUpDown();
            this.HNumeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rotNumeric = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.whiteboardPanel = new System.Windows.Forms.Panel();
            this.linePanel = new System.Windows.Forms.Panel();
            this.lineCheckbox = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.WNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // WNumeric
            // 
            this.WNumeric.Location = new System.Drawing.Point(80, 13);
            this.WNumeric.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.WNumeric.Name = "WNumeric";
            this.WNumeric.Size = new System.Drawing.Size(70, 20);
            this.WNumeric.TabIndex = 0;
            this.WNumeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // tNumeric
            // 
            this.tNumeric.Location = new System.Drawing.Point(80, 88);
            this.tNumeric.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.tNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tNumeric.Name = "tNumeric";
            this.tNumeric.Size = new System.Drawing.Size(70, 20);
            this.tNumeric.TabIndex = 1;
            this.tNumeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // SNumeric
            // 
            this.SNumeric.Location = new System.Drawing.Point(80, 63);
            this.SNumeric.Name = "SNumeric";
            this.SNumeric.Size = new System.Drawing.Size(70, 20);
            this.SNumeric.TabIndex = 2;
            this.SNumeric.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // HNumeric
            // 
            this.HNumeric.Location = new System.Drawing.Point(80, 38);
            this.HNumeric.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.HNumeric.Name = "HNumeric";
            this.HNumeric.Size = new System.Drawing.Size(70, 20);
            this.HNumeric.TabIndex = 3;
            this.HNumeric.Value = new decimal(new int[] {
            112,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "S [mm]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "t [mm]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "rot [°]";
            // 
            // rotNumeric
            // 
            this.rotNumeric.Location = new System.Drawing.Point(80, 148);
            this.rotNumeric.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.rotNumeric.Name = "rotNumeric";
            this.rotNumeric.Size = new System.Drawing.Size(70, 20);
            this.rotNumeric.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "W [mm]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "H [mm]";
            // 
            // whiteboardPanel
            // 
            this.whiteboardPanel.BackColor = System.Drawing.Color.White;
            this.whiteboardPanel.Location = new System.Drawing.Point(200, 10);
            this.whiteboardPanel.Name = "whiteboardPanel";
            this.whiteboardPanel.Size = new System.Drawing.Size(440, 440);
            this.whiteboardPanel.TabIndex = 12;
            // 
            // linePanel
            // 
            this.linePanel.Location = new System.Drawing.Point(18, 184);
            this.linePanel.Name = "linePanel";
            this.linePanel.Size = new System.Drawing.Size(117, 253);
            this.linePanel.TabIndex = 13;
            this.linePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LinePanel_Paint);
            // 
            // lineCheckbox
            // 
            this.lineCheckbox.BackColor = System.Drawing.SystemColors.Control;
            this.lineCheckbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lineCheckbox.CheckOnClick = true;
            this.lineCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineCheckbox.FormattingEnabled = true;
            this.lineCheckbox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.lineCheckbox.Location = new System.Drawing.Point(148, 196);
            this.lineCheckbox.Name = "lineCheckbox";
            this.lineCheckbox.Size = new System.Drawing.Size(46, 228);
            this.lineCheckbox.TabIndex = 14;
            this.lineCheckbox.SelectedIndexChanged += new System.EventHandler(this.LineCheckbox_SelectedIndexChanged);
            // 
            // Hut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.lineCheckbox);
            this.Controls.Add(this.linePanel);
            this.Controls.Add(this.whiteboardPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rotNumeric);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HNumeric);
            this.Controls.Add(this.SNumeric);
            this.Controls.Add(this.tNumeric);
            this.Controls.Add(this.WNumeric);
            this.Name = "Hut";
            this.Text = "Hut";
            ((System.ComponentModel.ISupportInitialize)(this.WNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown WNumeric;
        private System.Windows.Forms.NumericUpDown tNumeric;
        private System.Windows.Forms.NumericUpDown SNumeric;
        private System.Windows.Forms.NumericUpDown HNumeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown rotNumeric;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel whiteboardPanel;
        private System.Windows.Forms.Panel linePanel;
        private System.Windows.Forms.CheckedListBox lineCheckbox;
    }
}

