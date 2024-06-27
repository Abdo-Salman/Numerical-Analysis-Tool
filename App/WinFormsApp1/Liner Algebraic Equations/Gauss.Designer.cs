namespace WinFormsApp1
{
    partial class Gauss
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gauss));
            Backb = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            frstInp = new TextBox();
            SecInp = new TextBox();
            thrdInp = new TextBox();
            eqAns = new Button();
            resbt = new Button();
            a10 = new TextBox();
            a03 = new TextBox();
            a02 = new TextBox();
            a01 = new TextBox();
            a00 = new TextBox();
            a12 = new TextBox();
            a11 = new TextBox();
            a23 = new TextBox();
            a21 = new TextBox();
            a22 = new TextBox();
            a20 = new TextBox();
            a13 = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            label4 = new Label();
            panel3 = new Panel();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            x1Out = new TextBox();
            x3Out = new TextBox();
            x2Out = new TextBox();
            m31Out = new TextBox();
            m32Out = new TextBox();
            m21Out = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Simplified Arabic Fixed", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(353, 151);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 10;
            label1.Text = "eq(1)=";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Simplified Arabic Fixed", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(353, 192);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 11;
            label2.Text = "eq(2)=";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Simplified Arabic Fixed", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(353, 229);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 12;
            label3.Text = "eq(3)=";
            // 
            // frstInp
            // 
            frstInp.Location = new Point(437, 148);
            frstInp.Name = "frstInp";
            frstInp.Size = new Size(180, 27);
            frstInp.TabIndex = 13;
            // 
            // SecInp
            // 
            SecInp.Location = new Point(437, 189);
            SecInp.Name = "SecInp";
            SecInp.Size = new Size(180, 27);
            SecInp.TabIndex = 14;
            // 
            // thrdInp
            // 
            thrdInp.Location = new Point(437, 226);
            thrdInp.Name = "thrdInp";
            thrdInp.Size = new Size(180, 27);
            thrdInp.TabIndex = 15;
            thrdInp.TextChanged += thrdInp_TextChanged;
            // 
            // eqAns
            // 
            eqAns.Enabled = false;
            eqAns.Location = new Point(776, 612);
            eqAns.Name = "eqAns";
            eqAns.Size = new Size(94, 29);
            eqAns.TabIndex = 113;
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
            resbt.TabIndex = 114;
            resbt.Text = "Reset";
            resbt.UseVisualStyleBackColor = false;
            resbt.Click += resbt_Click;
            // 
            // a10
            // 
            a10.Enabled = false;
            a10.Location = new Point(202, 441);
            a10.Name = "a10";
            a10.Size = new Size(35, 27);
            a10.TabIndex = 120;
            a10.Visible = false;
            // 
            // a03
            // 
            a03.Enabled = false;
            a03.Location = new Point(342, 408);
            a03.Name = "a03";
            a03.Size = new Size(35, 27);
            a03.TabIndex = 121;
            a03.Visible = false;
            // 
            // a02
            // 
            a02.Enabled = false;
            a02.Location = new Point(284, 408);
            a02.Name = "a02";
            a02.Size = new Size(35, 27);
            a02.TabIndex = 122;
            a02.Visible = false;
            // 
            // a01
            // 
            a01.Enabled = false;
            a01.Location = new Point(243, 408);
            a01.Name = "a01";
            a01.Size = new Size(35, 27);
            a01.TabIndex = 123;
            a01.Visible = false;
            // 
            // a00
            // 
            a00.Enabled = false;
            a00.Location = new Point(202, 408);
            a00.Name = "a00";
            a00.Size = new Size(35, 27);
            a00.TabIndex = 124;
            a00.Visible = false;
            // 
            // a12
            // 
            a12.Enabled = false;
            a12.Location = new Point(284, 441);
            a12.Name = "a12";
            a12.Size = new Size(35, 27);
            a12.TabIndex = 125;
            a12.Visible = false;
            // 
            // a11
            // 
            a11.Enabled = false;
            a11.Location = new Point(243, 441);
            a11.Name = "a11";
            a11.Size = new Size(35, 27);
            a11.TabIndex = 125;
            a11.Visible = false;
            // 
            // a23
            // 
            a23.Enabled = false;
            a23.Location = new Point(342, 474);
            a23.Name = "a23";
            a23.Size = new Size(35, 27);
            a23.TabIndex = 126;
            a23.Visible = false;
            // 
            // a21
            // 
            a21.Enabled = false;
            a21.Location = new Point(243, 474);
            a21.Name = "a21";
            a21.Size = new Size(35, 27);
            a21.TabIndex = 127;
            a21.Visible = false;
            // 
            // a22
            // 
            a22.Enabled = false;
            a22.Location = new Point(284, 474);
            a22.Name = "a22";
            a22.Size = new Size(35, 27);
            a22.TabIndex = 128;
            a22.Visible = false;
            // 
            // a20
            // 
            a20.Enabled = false;
            a20.Location = new Point(202, 474);
            a20.Name = "a20";
            a20.Size = new Size(35, 27);
            a20.TabIndex = 129;
            a20.Visible = false;
            // 
            // a13
            // 
            a13.Enabled = false;
            a13.Location = new Point(342, 441);
            a13.Name = "a13";
            a13.Size = new Size(35, 27);
            a13.TabIndex = 130;
            a13.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(171, 395);
            panel1.Name = "panel1";
            panel1.Size = new Size(25, 125);
            panel1.TabIndex = 131;
            panel1.Visible = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(383, 395);
            panel2.Name = "panel2";
            panel2.Size = new Size(25, 125);
            panel2.TabIndex = 132;
            panel2.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Simplified Arabic Fixed", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(116, 441);
            label4.Name = "label4";
            label4.Size = new Size(49, 34);
            label4.TabIndex = 133;
            label4.Text = "A=";
            label4.Visible = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.ForeColor = Color.Black;
            panel3.Location = new Point(325, 395);
            panel3.Name = "panel3";
            panel3.Size = new Size(11, 125);
            panel3.TabIndex = 134;
            panel3.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Simplified Arabic Fixed", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(564, 492);
            label5.Name = "label5";
            label5.Size = new Size(54, 28);
            label5.TabIndex = 135;
            label5.Text = "x3=";
            label5.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Simplified Arabic Fixed", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(564, 444);
            label6.Name = "label6";
            label6.Size = new Size(54, 28);
            label6.TabIndex = 136;
            label6.Text = "x2=";
            label6.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Simplified Arabic Fixed", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.HotTrack;
            label7.Location = new Point(564, 394);
            label7.Name = "label7";
            label7.Size = new Size(54, 28);
            label7.TabIndex = 137;
            label7.Text = "x1=";
            label7.Visible = false;
            // 
            // x1Out
            // 
            x1Out.Enabled = false;
            x1Out.Location = new Point(624, 395);
            x1Out.Name = "x1Out";
            x1Out.Size = new Size(70, 27);
            x1Out.TabIndex = 138;
            x1Out.Visible = false;
            // 
            // x3Out
            // 
            x3Out.Enabled = false;
            x3Out.Location = new Point(624, 493);
            x3Out.Name = "x3Out";
            x3Out.Size = new Size(70, 27);
            x3Out.TabIndex = 139;
            x3Out.Visible = false;
            // 
            // x2Out
            // 
            x2Out.Enabled = false;
            x2Out.Location = new Point(624, 445);
            x2Out.Name = "x2Out";
            x2Out.Size = new Size(70, 27);
            x2Out.TabIndex = 140;
            x2Out.Visible = false;
            // 
            // m31Out
            // 
            m31Out.Enabled = false;
            m31Out.Location = new Point(823, 445);
            m31Out.Name = "m31Out";
            m31Out.Size = new Size(70, 27);
            m31Out.TabIndex = 146;
            m31Out.Visible = false;
            // 
            // m32Out
            // 
            m32Out.Enabled = false;
            m32Out.Location = new Point(823, 493);
            m32Out.Name = "m32Out";
            m32Out.Size = new Size(70, 27);
            m32Out.TabIndex = 145;
            m32Out.Visible = false;
            // 
            // m21Out
            // 
            m21Out.Enabled = false;
            m21Out.Location = new Point(823, 395);
            m21Out.Name = "m21Out";
            m21Out.Size = new Size(70, 27);
            m21Out.TabIndex = 144;
            m21Out.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Simplified Arabic Fixed", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.HotTrack;
            label8.Location = new Point(749, 394);
            label8.Name = "label8";
            label8.Size = new Size(68, 28);
            label8.TabIndex = 143;
            label8.Text = "m21=";
            label8.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Simplified Arabic Fixed", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.HotTrack;
            label9.Location = new Point(749, 444);
            label9.Name = "label9";
            label9.Size = new Size(68, 28);
            label9.TabIndex = 142;
            label9.Text = "m31=";
            label9.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Simplified Arabic Fixed", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.HotTrack;
            label10.Location = new Point(749, 492);
            label10.Name = "label10";
            label10.Size = new Size(68, 28);
            label10.TabIndex = 141;
            label10.Text = "m32=";
            label10.Visible = false;
            // 
            // Gauss
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 653);
            Controls.Add(m31Out);
            Controls.Add(m32Out);
            Controls.Add(m21Out);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(x2Out);
            Controls.Add(x3Out);
            Controls.Add(x1Out);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(panel3);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(a13);
            Controls.Add(a20);
            Controls.Add(a22);
            Controls.Add(a21);
            Controls.Add(a23);
            Controls.Add(a11);
            Controls.Add(a12);
            Controls.Add(a00);
            Controls.Add(a01);
            Controls.Add(a02);
            Controls.Add(a03);
            Controls.Add(a10);
            Controls.Add(eqAns);
            Controls.Add(resbt);
            Controls.Add(thrdInp);
            Controls.Add(SecInp);
            Controls.Add(frstInp);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Backb);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Gauss";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gauss Elimination";
            Load += Gauss_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Backb;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox frstInp;
        private TextBox SecInp;
        private TextBox thrdInp;
        private Button eqAns;
        private Button resbt;
        private TextBox a10;
        private TextBox a03;
        private TextBox a02;
        private TextBox a01;
        private TextBox a00;
        private TextBox a12;
        private TextBox a11;
        private TextBox a23;
        private TextBox a21;
        private TextBox a22;
        private TextBox a20;
        private TextBox a13;
        private Panel panel1;
        private Panel panel2;
        private Label label4;
        private Panel panel3;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox x1Out;
        private TextBox x3Out;
        private TextBox x2Out;
        private TextBox m31Out;
        private TextBox m32Out;
        private TextBox m21Out;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}