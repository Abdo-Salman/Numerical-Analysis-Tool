namespace WinFormsApp1
{
    partial class Cramer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cramer));
            Backb = new Button();
            thrdInp = new TextBox();
            SecInp = new TextBox();
            frstInp = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            label4 = new Label();
            a20 = new TextBox();
            a22 = new TextBox();
            a21 = new TextBox();
            a11 = new TextBox();
            a12 = new TextBox();
            a00 = new TextBox();
            a01 = new TextBox();
            a02 = new TextBox();
            a10 = new TextBox();
            x2Out = new TextBox();
            x3Out = new TextBox();
            x1Out = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            A3Out = new TextBox();
            label10 = new Label();
            A2Out = new TextBox();
            A1Out = new TextBox();
            label8 = new Label();
            label9 = new Label();
            AOut = new TextBox();
            label11 = new Label();
            eqAns = new Button();
            resbt = new Button();
            SuspendLayout();
            // 
            // Backb
            // 
            Backb.BackColor = SystemColors.ButtonHighlight;
            Backb.Location = new Point(12, 612);
            Backb.Name = "Backb";
            Backb.Size = new Size(94, 29);
            Backb.TabIndex = 6;
            Backb.Text = "Back";
            Backb.UseVisualStyleBackColor = false;
            Backb.Click += Backb_Click;
            // 
            // thrdInp
            // 
            thrdInp.Location = new Point(430, 220);
            thrdInp.Name = "thrdInp";
            thrdInp.Size = new Size(180, 27);
            thrdInp.TabIndex = 3;
            thrdInp.TextChanged += thrdInp_TextChanged;
            // 
            // SecInp
            // 
            SecInp.Location = new Point(430, 183);
            SecInp.Name = "SecInp";
            SecInp.Size = new Size(180, 27);
            SecInp.TabIndex = 2;
            // 
            // frstInp
            // 
            frstInp.Location = new Point(430, 142);
            frstInp.Name = "frstInp";
            frstInp.Size = new Size(180, 27);
            frstInp.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Simplified Arabic Fixed", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(346, 223);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 18;
            label3.Text = "eq(3)=";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Simplified Arabic Fixed", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(346, 186);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 17;
            label2.Text = "eq(2)=";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Simplified Arabic Fixed", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(346, 145);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 16;
            label1.Text = "eq(1)=";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.ForeColor = Color.Black;
            panel3.Location = new Point(177, 393);
            panel3.Name = "panel3";
            panel3.Size = new Size(25, 125);
            panel3.TabIndex = 143;
            panel3.Visible = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.ForeColor = Color.Black;
            panel4.Location = new Point(331, 393);
            panel4.Name = "panel4";
            panel4.Size = new Size(25, 125);
            panel4.TabIndex = 144;
            panel4.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Simplified Arabic Fixed", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(122, 439);
            label4.Name = "label4";
            label4.Size = new Size(49, 34);
            label4.TabIndex = 145;
            label4.Text = "A=";
            label4.Visible = false;
            // 
            // a20
            // 
            a20.Enabled = false;
            a20.Location = new Point(208, 472);
            a20.Name = "a20";
            a20.Size = new Size(35, 27);
            a20.TabIndex = 142;
            a20.Visible = false;
            // 
            // a22
            // 
            a22.Enabled = false;
            a22.Location = new Point(290, 472);
            a22.Name = "a22";
            a22.Size = new Size(35, 27);
            a22.TabIndex = 141;
            a22.Visible = false;
            // 
            // a21
            // 
            a21.Enabled = false;
            a21.Location = new Point(249, 472);
            a21.Name = "a21";
            a21.Size = new Size(35, 27);
            a21.TabIndex = 140;
            a21.Visible = false;
            // 
            // a11
            // 
            a11.Enabled = false;
            a11.Location = new Point(249, 439);
            a11.Name = "a11";
            a11.Size = new Size(35, 27);
            a11.TabIndex = 138;
            a11.Visible = false;
            // 
            // a12
            // 
            a12.Enabled = false;
            a12.Location = new Point(290, 439);
            a12.Name = "a12";
            a12.Size = new Size(35, 27);
            a12.TabIndex = 139;
            a12.Visible = false;
            // 
            // a00
            // 
            a00.Enabled = false;
            a00.Location = new Point(208, 406);
            a00.Name = "a00";
            a00.Size = new Size(35, 27);
            a00.TabIndex = 137;
            a00.Visible = false;
            // 
            // a01
            // 
            a01.Enabled = false;
            a01.Location = new Point(249, 406);
            a01.Name = "a01";
            a01.Size = new Size(35, 27);
            a01.TabIndex = 136;
            a01.Visible = false;
            // 
            // a02
            // 
            a02.Enabled = false;
            a02.Location = new Point(290, 406);
            a02.Name = "a02";
            a02.Size = new Size(35, 27);
            a02.TabIndex = 135;
            a02.Visible = false;
            // 
            // a10
            // 
            a10.Enabled = false;
            a10.Location = new Point(208, 439);
            a10.Name = "a10";
            a10.Size = new Size(35, 27);
            a10.TabIndex = 134;
            a10.Visible = false;
            // 
            // x2Out
            // 
            x2Out.Enabled = false;
            x2Out.Location = new Point(772, 443);
            x2Out.Name = "x2Out";
            x2Out.Size = new Size(70, 27);
            x2Out.TabIndex = 152;
            x2Out.Visible = false;
            // 
            // x3Out
            // 
            x3Out.Enabled = false;
            x3Out.Location = new Point(772, 491);
            x3Out.Name = "x3Out";
            x3Out.Size = new Size(70, 27);
            x3Out.TabIndex = 151;
            x3Out.Visible = false;
            // 
            // x1Out
            // 
            x1Out.Enabled = false;
            x1Out.Location = new Point(772, 393);
            x1Out.Name = "x1Out";
            x1Out.Size = new Size(70, 27);
            x1Out.TabIndex = 150;
            x1Out.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Simplified Arabic Fixed", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.HotTrack;
            label7.Location = new Point(712, 392);
            label7.Name = "label7";
            label7.Size = new Size(54, 28);
            label7.TabIndex = 149;
            label7.Text = "x1=";
            label7.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Simplified Arabic Fixed", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(712, 442);
            label6.Name = "label6";
            label6.Size = new Size(54, 28);
            label6.TabIndex = 148;
            label6.Text = "x2=";
            label6.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Simplified Arabic Fixed", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(712, 490);
            label5.Name = "label5";
            label5.Size = new Size(54, 28);
            label5.TabIndex = 147;
            label5.Text = "x3=";
            label5.Visible = false;
            // 
            // A3Out
            // 
            A3Out.Enabled = false;
            A3Out.Location = new Point(564, 514);
            A3Out.Name = "A3Out";
            A3Out.Size = new Size(70, 27);
            A3Out.TabIndex = 174;
            A3Out.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Simplified Arabic Fixed", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.HotTrack;
            label10.Location = new Point(504, 513);
            label10.Name = "label10";
            label10.Size = new Size(54, 28);
            label10.TabIndex = 173;
            label10.Text = "A3=";
            label10.Visible = false;
            // 
            // A2Out
            // 
            A2Out.Enabled = false;
            A2Out.Location = new Point(564, 466);
            A2Out.Name = "A2Out";
            A2Out.Size = new Size(70, 27);
            A2Out.TabIndex = 172;
            A2Out.Visible = false;
            // 
            // A1Out
            // 
            A1Out.Enabled = false;
            A1Out.Location = new Point(564, 416);
            A1Out.Name = "A1Out";
            A1Out.Size = new Size(70, 27);
            A1Out.TabIndex = 171;
            A1Out.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Simplified Arabic Fixed", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.HotTrack;
            label8.Location = new Point(504, 415);
            label8.Name = "label8";
            label8.Size = new Size(54, 28);
            label8.TabIndex = 170;
            label8.Text = "A1=";
            label8.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Simplified Arabic Fixed", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.HotTrack;
            label9.Location = new Point(504, 465);
            label9.Name = "label9";
            label9.Size = new Size(54, 28);
            label9.TabIndex = 169;
            label9.Text = "A2=";
            label9.Visible = false;
            // 
            // AOut
            // 
            AOut.Enabled = false;
            AOut.Location = new Point(564, 367);
            AOut.Name = "AOut";
            AOut.Size = new Size(70, 27);
            AOut.TabIndex = 168;
            AOut.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Simplified Arabic Fixed", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.HotTrack;
            label11.Location = new Point(504, 366);
            label11.Name = "label11";
            label11.Size = new Size(40, 28);
            label11.TabIndex = 167;
            label11.Text = "A=";
            label11.Visible = false;
            // 
            // eqAns
            // 
            eqAns.Enabled = false;
            eqAns.Location = new Point(776, 612);
            eqAns.Name = "eqAns";
            eqAns.Size = new Size(94, 29);
            eqAns.TabIndex = 4;
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
            resbt.TabIndex = 5;
            resbt.Text = "Reset";
            resbt.UseVisualStyleBackColor = false;
            resbt.Click += resbt_Click;
            // 
            // Cramer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 653);
            Controls.Add(eqAns);
            Controls.Add(resbt);
            Controls.Add(A3Out);
            Controls.Add(label10);
            Controls.Add(A2Out);
            Controls.Add(A1Out);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(AOut);
            Controls.Add(label11);
            Controls.Add(x2Out);
            Controls.Add(x3Out);
            Controls.Add(x1Out);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(label4);
            Controls.Add(a20);
            Controls.Add(a22);
            Controls.Add(a21);
            Controls.Add(a11);
            Controls.Add(a12);
            Controls.Add(a00);
            Controls.Add(a01);
            Controls.Add(a02);
            Controls.Add(a10);
            Controls.Add(thrdInp);
            Controls.Add(SecInp);
            Controls.Add(frstInp);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Backb);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Cramer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cramer's Rule";
            Load += Cramer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Backb;
        private TextBox thrdInp;
        private TextBox SecInp;
        private TextBox frstInp;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel3;
        private Panel panel4;
        private Label label4;
        private TextBox a20;
        private TextBox a22;
        private TextBox a21;
        private TextBox a11;
        private TextBox a12;
        private TextBox a00;
        private TextBox a01;
        private TextBox a02;
        private TextBox a10;
        private TextBox x2Out;
        private TextBox x3Out;
        private TextBox x1Out;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox A3Out;
        private Label label10;
        private TextBox A2Out;
        private TextBox A1Out;
        private Label label8;
        private Label label9;
        private TextBox AOut;
        private Label label11;
        private Button eqAns;
        private Button resbt;
    }
}