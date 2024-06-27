namespace WinFormsApp1
{
    partial class Bisection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bisection));
            Backb = new Button();
            eqInp = new TextBox();
            label1 = new Label();
            label3 = new Label();
            lowXInp = new TextBox();
            upXInp = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            truebt = new CheckBox();
            falsebt = new CheckBox();
            resbt = new Button();
            label5 = new Label();
            label6 = new Label();
            errorInp = new TextBox();
            iterInp = new TextBox();
            eqAns = new Button();
            label8 = new Label();
            label9 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Backb
            // 
            Backb.BackColor = SystemColors.ButtonHighlight;
            Backb.Cursor = Cursors.Hand;
            Backb.Location = new Point(12, 612);
            Backb.Name = "Backb";
            Backb.Size = new Size(94, 29);
            Backb.TabIndex = 8;
            Backb.Text = "Back";
            Backb.UseVisualStyleBackColor = false;
            Backb.Click += Backb_Click;
            // 
            // eqInp
            // 
            eqInp.Cursor = Cursors.IBeam;
            eqInp.Location = new Point(188, 123);
            eqInp.Name = "eqInp";
            eqInp.Size = new Size(227, 27);
            eqInp.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Simplified Arabic Fixed", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(116, 126);
            label1.Name = "label1";
            label1.Size = new Size(67, 25);
            label1.TabIndex = 2;
            label1.Text = "f(x)=";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Simplified Arabic Fixed", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(661, 126);
            label3.Name = "label3";
            label3.Size = new Size(34, 25);
            label3.TabIndex = 4;
            label3.Text = "xu";
            // 
            // lowXInp
            // 
            lowXInp.Cursor = Cursors.IBeam;
            lowXInp.Location = new Point(494, 123);
            lowXInp.Name = "lowXInp";
            lowXInp.Size = new Size(123, 27);
            lowXInp.TabIndex = 2;
            // 
            // upXInp
            // 
            upXInp.Cursor = Cursors.IBeam;
            upXInp.Location = new Point(701, 123);
            upXInp.Name = "upXInp";
            upXInp.Size = new Size(123, 27);
            upXInp.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Simplified Arabic Fixed", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(454, 126);
            label2.Name = "label2";
            label2.Size = new Size(34, 25);
            label2.TabIndex = 8;
            label2.Text = "xl";
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
            dataGridView1.TabIndex = 100;
            dataGridView1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Simplified Arabic Fixed", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(116, 216);
            label4.Name = "label4";
            label4.Size = new Size(221, 25);
            label4.TabIndex = 10;
            label4.Text = "Is The error% given";
            // 
            // truebt
            // 
            truebt.AutoSize = true;
            truebt.BackColor = Color.Transparent;
            truebt.Cursor = Cursors.Hand;
            truebt.Location = new Point(343, 215);
            truebt.Name = "truebt";
            truebt.Size = new Size(59, 24);
            truebt.TabIndex = 4;
            truebt.Text = "True";
            truebt.UseVisualStyleBackColor = false;
            truebt.CheckedChanged += truebt_CheckedChanged;
            // 
            // falsebt
            // 
            falsebt.AutoSize = true;
            falsebt.BackColor = Color.Transparent;
            falsebt.Cursor = Cursors.Hand;
            falsebt.Location = new Point(408, 215);
            falsebt.Name = "falsebt";
            falsebt.Size = new Size(63, 24);
            falsebt.TabIndex = 5;
            falsebt.Text = "False";
            falsebt.UseVisualStyleBackColor = false;
            falsebt.CheckedChanged += falsebt_CheckedChanged;
            // 
            // resbt
            // 
            resbt.BackColor = SystemColors.ButtonHighlight;
            resbt.Cursor = Cursors.Hand;
            resbt.Location = new Point(876, 612);
            resbt.Name = "resbt";
            resbt.Size = new Size(94, 29);
            resbt.TabIndex = 10;
            resbt.Text = "Reset";
            resbt.UseVisualStyleBackColor = false;
            resbt.Click += resbt_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Simplified Arabic Fixed", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(603, 172);
            label5.Name = "label5";
            label5.Size = new Size(155, 25);
            label5.TabIndex = 14;
            label5.Text = "Please Enter:";
            label5.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Simplified Arabic Fixed", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(494, 216);
            label6.Name = "label6";
            label6.Size = new Size(89, 25);
            label6.TabIndex = 15;
            label6.Text = "error%=";
            label6.Visible = false;
            // 
            // errorInp
            // 
            errorInp.Cursor = Cursors.IBeam;
            errorInp.Location = new Point(589, 213);
            errorInp.Name = "errorInp";
            errorInp.Size = new Size(71, 27);
            errorInp.TabIndex = 6;
            errorInp.Visible = false;
            errorInp.TextChanged += errorInp_TextChanged;
            // 
            // iterInp
            // 
            iterInp.Cursor = Cursors.IBeam;
            iterInp.Location = new Point(633, 213);
            iterInp.Name = "iterInp";
            iterInp.Size = new Size(71, 27);
            iterInp.TabIndex = 7;
            iterInp.Visible = false;
            iterInp.TextChanged += iterInp_TextChanged_1;
            // 
            // eqAns
            // 
            eqAns.Cursor = Cursors.Hand;
            eqAns.Enabled = false;
            eqAns.Location = new Point(776, 612);
            eqAns.Name = "eqAns";
            eqAns.Size = new Size(94, 29);
            eqAns.TabIndex = 9;
            eqAns.Text = "Solve";
            eqAns.UseVisualStyleBackColor = true;
            eqAns.Click += eqSolve_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(318, 598);
            label8.Name = "label8";
            label8.Size = new Size(84, 27);
            label8.TabIndex = 20;
            label8.Text = "Root =";
            label8.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ButtonHighlight;
            label9.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(408, 598);
            label9.Name = "label9";
            label9.Size = new Size(0, 27);
            label9.TabIndex = 21;
            label9.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Simplified Arabic Fixed", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.HotTrack;
            label7.Location = new Point(494, 216);
            label7.Name = "label7";
            label7.Size = new Size(133, 25);
            label7.TabIndex = 17;
            label7.Text = "Iteration#=";
            label7.Visible = false;
            // 
            // Bisection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 653);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(eqAns);
            Controls.Add(iterInp);
            Controls.Add(label7);
            Controls.Add(errorInp);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(resbt);
            Controls.Add(falsebt);
            Controls.Add(truebt);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(upXInp);
            Controls.Add(lowXInp);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(eqInp);
            Controls.Add(Backb);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Bisection";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bisection";
            Load += Bisection_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Backb;
        private TextBox eqInp;
        private Label label1;
        private Label label3;
        private TextBox lowXInp;
        private TextBox upXInp;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label4;
        private CheckBox truebt;
        private CheckBox falsebt;
        private Button resbt;
        private Label label5;
        private Label label6;
        private TextBox errorInp;
        private TextBox iterInp;
        private Button eqAns;
        private Label label8;
        private Label label9;
        private Label label7;
    }
}