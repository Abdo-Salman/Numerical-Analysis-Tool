namespace WinFormsApp1
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            Bisec = new Button();
            Sec = new Button();
            Cram = new Button();
            FLP = new Button();
            SFP = new Button();
            Nton = new Button();
            LU = new Button();
            GElim = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Bisec
            // 
            Bisec.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Bisec.BackColor = SystemColors.ButtonHighlight;
            Bisec.Cursor = Cursors.Hand;
            Bisec.Font = new Font("Baskerville Old Face", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            Bisec.ForeColor = SystemColors.ControlText;
            Bisec.Location = new Point(660, 103);
            Bisec.Name = "Bisec";
            Bisec.Size = new Size(164, 82);
            Bisec.TabIndex = 33;
            Bisec.Text = "Bisection Method";
            Bisec.UseVisualStyleBackColor = false;
            Bisec.Click += Bisec_Click;
            // 
            // Sec
            // 
            Sec.BackColor = SystemColors.ButtonHighlight;
            Sec.Cursor = Cursors.Hand;
            Sec.Font = new Font("Baskerville Old Face", 12.8F, FontStyle.Italic, GraphicsUnit.Point);
            Sec.ForeColor = SystemColors.ControlText;
            Sec.Location = new Point(109, 519);
            Sec.Name = "Sec";
            Sec.Size = new Size(168, 61);
            Sec.TabIndex = 37;
            Sec.Text = "Secant Method";
            Sec.UseVisualStyleBackColor = false;
            Sec.Click += Sec_Click;
            // 
            // Cram
            // 
            Cram.BackColor = SystemColors.ButtonHighlight;
            Cram.Cursor = Cursors.Hand;
            Cram.Font = new Font("Baskerville Old Face", 11.8F, FontStyle.Italic, GraphicsUnit.Point);
            Cram.ForeColor = SystemColors.ControlText;
            Cram.Location = new Point(109, 369);
            Cram.Name = "Cram";
            Cram.Size = new Size(168, 36);
            Cram.TabIndex = 40;
            Cram.Text = "Cramer's rule";
            Cram.UseVisualStyleBackColor = false;
            Cram.Click += Cram_Click;
            // 
            // FLP
            // 
            FLP.BackColor = SystemColors.ButtonHighlight;
            FLP.Cursor = Cursors.Hand;
            FLP.Font = new Font("Baskerville Old Face", 12F, FontStyle.Italic, GraphicsUnit.Point);
            FLP.ForeColor = SystemColors.ControlText;
            FLP.Location = new Point(740, 262);
            FLP.Name = "FLP";
            FLP.Size = new Size(152, 64);
            FLP.TabIndex = 34;
            FLP.Text = "False Position Method";
            FLP.UseVisualStyleBackColor = false;
            FLP.Click += FLP_Click;
            // 
            // SFP
            // 
            SFP.BackColor = SystemColors.ButtonHighlight;
            SFP.Cursor = Cursors.Hand;
            SFP.Font = new Font("Baskerville Old Face", 11.8F, FontStyle.Italic, GraphicsUnit.Point);
            SFP.ForeColor = SystemColors.ControlText;
            SFP.Location = new Point(740, 404);
            SFP.Name = "SFP";
            SFP.Size = new Size(152, 78);
            SFP.TabIndex = 35;
            SFP.Text = "Simple Fixed Point Method";
            SFP.UseVisualStyleBackColor = false;
            SFP.Click += SFP_Click;
            // 
            // Nton
            // 
            Nton.BackColor = SystemColors.ButtonHighlight;
            Nton.Cursor = Cursors.Hand;
            Nton.Font = new Font("Baskerville Old Face", 11.8F, FontStyle.Italic, GraphicsUnit.Point);
            Nton.ForeColor = SystemColors.ControlText;
            Nton.Location = new Point(660, 572);
            Nton.Name = "Nton";
            Nton.Size = new Size(175, 33);
            Nton.TabIndex = 36;
            Nton.Text = "Newton Method";
            Nton.UseVisualStyleBackColor = false;
            Nton.Click += Nton_Click;
            // 
            // LU
            // 
            LU.BackColor = SystemColors.ButtonHighlight;
            LU.Cursor = Cursors.Hand;
            LU.Font = new Font("Baskerville Old Face", 12F, FontStyle.Italic, GraphicsUnit.Point);
            LU.ForeColor = SystemColors.ControlText;
            LU.Location = new Point(109, 103);
            LU.Name = "LU";
            LU.Size = new Size(164, 77);
            LU.TabIndex = 38;
            LU.Text = "LU Decomposition";
            LU.UseVisualStyleBackColor = false;
            LU.Click += LU_Click;
            // 
            // GElim
            // 
            GElim.BackColor = SystemColors.ButtonHighlight;
            GElim.Cursor = Cursors.Hand;
            GElim.Font = new Font("Baskerville Old Face", 12F, FontStyle.Italic, GraphicsUnit.Point);
            GElim.ForeColor = SystemColors.ControlText;
            GElim.Location = new Point(100, 258);
            GElim.Name = "GElim";
            GElim.Size = new Size(186, 36);
            GElim.TabIndex = 39;
            GElim.Text = "Gauss Elimination";
            GElim.UseVisualStyleBackColor = false;
            GElim.Click += GElim_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(-3, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(987, 655);
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 653);
            Controls.Add(pictureBox1);
            Controls.Add(Bisec);
            Controls.Add(Sec);
            Controls.Add(Cram);
            Controls.Add(FLP);
            Controls.Add(SFP);
            Controls.Add(Nton);
            Controls.Add(LU);
            Controls.Add(GElim);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Numerical Analysis Project";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Bisec;
        private Button Sec;
        private Button Cram;
        private Button FLP;
        private Button SFP;
        private Button Nton;
        private Button LU;
        private Button GElim;
        private PictureBox pictureBox1;
    }
}