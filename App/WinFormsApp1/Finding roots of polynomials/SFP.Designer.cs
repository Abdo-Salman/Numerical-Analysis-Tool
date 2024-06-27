﻿namespace WinFormsApp1
{
    partial class SFP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public event EventHandler? GotFocus;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SFP));
            Backb = new Button();
            label9 = new Label();
            label8 = new Label();
            eqAns = new Button();
            resbt = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            eqInp = new TextBox();
            iterInp = new TextBox();
            errorInp = new TextBox();
            label6 = new Label();
            label5 = new Label();
            falsebt = new CheckBox();
            truebt = new CheckBox();
            label4 = new Label();
            xNodeInp = new TextBox();
            label3 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Backb
            // 
            Backb.BackColor = SystemColors.ButtonHighlight;
            Backb.Location = new Point(12, 612);
            Backb.Name = "Backb";
            Backb.Size = new Size(94, 29);
            Backb.TabIndex = 9;
            Backb.Text = "Back";
            Backb.UseVisualStyleBackColor = false;
            Backb.Click += Backb_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ButtonHighlight;
            label9.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(418, 598);
            label9.Name = "label9";
            label9.Size = new Size(0, 27);
            label9.TabIndex = 106;
            label9.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(328, 598);
            label8.Name = "label8";
            label8.Size = new Size(84, 27);
            label8.TabIndex = 105;
            label8.Text = "Root =";
            label8.Visible = false;
            // 
            // eqAns
            // 
            eqAns.Cursor = Cursors.Hand;
            eqAns.Enabled = false;
            eqAns.Location = new Point(776, 612);
            eqAns.Name = "eqAns";
            eqAns.Size = new Size(94, 29);
            eqAns.TabIndex = 103;
            eqAns.Text = "Solve";
            eqAns.UseVisualStyleBackColor = true;
            eqAns.Click += eqAns_Click;
            // 
            // resbt
            // 
            resbt.BackColor = SystemColors.ButtonHighlight;
            resbt.Cursor = Cursors.Hand;
            resbt.Location = new Point(876, 612);
            resbt.Name = "resbt";
            resbt.Size = new Size(94, 29);
            resbt.TabIndex = 104;
            resbt.Text = "Reset";
            resbt.UseVisualStyleBackColor = false;
            resbt.Click += resbt_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 250);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(958, 335);
            dataGridView1.TabIndex = 107;
            dataGridView1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Simplified Arabic Fixed", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(181, 126);
            label1.Name = "label1";
            label1.Size = new Size(67, 25);
            label1.TabIndex = 102;
            label1.Text = "g(x)=";
            // 
            // eqInp
            // 
            eqInp.Cursor = Cursors.IBeam;
            eqInp.ForeColor = SystemColors.ControlDark;
            eqInp.Location = new Point(253, 123);
            eqInp.Name = "eqInp";
            eqInp.Size = new Size(227, 27);
            eqInp.TabIndex = 101;
            eqInp.GotFocus += eqInp_GotFocus;
            eqInp.LostFocus += eqInp_LostFocus;
            // 
            // iterInp
            // 
            iterInp.Cursor = Cursors.IBeam;
            iterInp.Location = new Point(729, 213);
            iterInp.Name = "iterInp";
            iterInp.Size = new Size(71, 27);
            iterInp.TabIndex = 113;
            iterInp.Visible = false;
            iterInp.TextChanged += iterInp_TextChanged;
            // 
            // errorInp
            // 
            errorInp.Cursor = Cursors.IBeam;
            errorInp.Location = new Point(685, 213);
            errorInp.Name = "errorInp";
            errorInp.Size = new Size(71, 27);
            errorInp.TabIndex = 112;
            errorInp.Visible = false;
            errorInp.TextChanged += errorInp_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Simplified Arabic Fixed", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(590, 216);
            label6.Name = "label6";
            label6.Size = new Size(89, 25);
            label6.TabIndex = 116;
            label6.Text = "error%=";
            label6.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Simplified Arabic Fixed", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(696, 163);
            label5.Name = "label5";
            label5.Size = new Size(155, 25);
            label5.TabIndex = 115;
            label5.Text = "Please Enter:";
            label5.Visible = false;
            // 
            // falsebt
            // 
            falsebt.AutoSize = true;
            falsebt.BackColor = Color.Transparent;
            falsebt.Cursor = Cursors.Hand;
            falsebt.Location = new Point(439, 215);
            falsebt.Name = "falsebt";
            falsebt.Size = new Size(63, 24);
            falsebt.TabIndex = 111;
            falsebt.Text = "False";
            falsebt.UseVisualStyleBackColor = false;
            falsebt.CheckedChanged += falsebt_CheckedChanged;
            // 
            // truebt
            // 
            truebt.AutoSize = true;
            truebt.BackColor = Color.Transparent;
            truebt.Cursor = Cursors.Hand;
            truebt.Location = new Point(374, 215);
            truebt.Name = "truebt";
            truebt.Size = new Size(59, 24);
            truebt.TabIndex = 109;
            truebt.Text = "True";
            truebt.UseVisualStyleBackColor = false;
            truebt.CheckedChanged += truebt_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Simplified Arabic Fixed", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(147, 216);
            label4.Name = "label4";
            label4.Size = new Size(221, 25);
            label4.TabIndex = 114;
            label4.Text = "Is The error% given";
            // 
            // xNodeInp
            // 
            xNodeInp.Cursor = Cursors.IBeam;
            xNodeInp.Location = new Point(600, 123);
            xNodeInp.Name = "xNodeInp";
            xNodeInp.Size = new Size(123, 27);
            xNodeInp.TabIndex = 108;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Simplified Arabic Fixed", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(560, 126);
            label3.Name = "label3";
            label3.Size = new Size(34, 25);
            label3.TabIndex = 110;
            label3.Text = "xo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Simplified Arabic Fixed", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.HotTrack;
            label7.Location = new Point(590, 216);
            label7.Name = "label7";
            label7.Size = new Size(133, 25);
            label7.TabIndex = 118;
            label7.Text = "Iteration#=";
            label7.Visible = false;
            // 
            // SFP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 653);
            Controls.Add(label7);
            Controls.Add(iterInp);
            Controls.Add(errorInp);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(falsebt);
            Controls.Add(truebt);
            Controls.Add(label4);
            Controls.Add(xNodeInp);
            Controls.Add(label3);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(eqAns);
            Controls.Add(resbt);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(eqInp);
            Controls.Add(Backb);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SFP";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simple Fixed Point";
            Load += SFP_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void eqInp_GotFocus(object sender, EventArgs e)
        {
            if (isPlaceholderActive)
            {
                eqInp.Text = "";  // Clear the placeholder text
                eqInp.ForeColor = SystemColors.WindowText;  // Restore the default text color
                isPlaceholderActive = false;
            }
        }

        private void eqInp_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(eqInp.Text))
            {
                eqInp.Text = "Enter Equation as x = ....";  // Set the placeholder text
                eqInp.ForeColor = Color.Gray;  // Set the placeholder color
                isPlaceholderActive = true;
            }
        }
        #endregion

        private Button Backb;
        private Label label9;
        private Label label8;
        private Button eqAns;
        private Button resbt;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox eqInp;
        private TextBox iterInp;
        private TextBox errorInp;
        private Label label6;
        private Label label5;
        private CheckBox falsebt;
        private CheckBox truebt;
        private Label label4;
        private TextBox xNodeInp;
        private Label label3;
        private Label label7;
    }
}