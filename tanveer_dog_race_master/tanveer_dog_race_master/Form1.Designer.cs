namespace tanveer_dog_race_master
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.runner1 = new System.Windows.Forms.PictureBox();
            this.runner2 = new System.Windows.Forms.PictureBox();
            this.runner3 = new System.Windows.Forms.PictureBox();
            this.runner4 = new System.Windows.Forms.PictureBox();
            this.p1 = new System.Windows.Forms.PictureBox();
            this.p2 = new System.Windows.Forms.PictureBox();
            this.p3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Player1 = new System.Windows.Forms.Label();
            this.Player2 = new System.Windows.Forms.Label();
            this.Player3 = new System.Windows.Forms.Label();
            this.betAmount = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.blance1 = new System.Windows.Forms.Label();
            this.balance2 = new System.Windows.Forms.Label();
            this.balance3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.runner1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.runner2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.runner3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.runner4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // runner1
            // 
            this.runner1.Image = ((System.Drawing.Image)(resources.GetObject("runner1.Image")));
            this.runner1.Location = new System.Drawing.Point(12, 12);
            this.runner1.Name = "runner1";
            this.runner1.Size = new System.Drawing.Size(108, 54);
            this.runner1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.runner1.TabIndex = 0;
            this.runner1.TabStop = false;
            this.runner1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // runner2
            // 
            this.runner2.Image = ((System.Drawing.Image)(resources.GetObject("runner2.Image")));
            this.runner2.Location = new System.Drawing.Point(12, 82);
            this.runner2.Name = "runner2";
            this.runner2.Size = new System.Drawing.Size(108, 54);
            this.runner2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.runner2.TabIndex = 1;
            this.runner2.TabStop = false;
            this.runner2.Click += new System.EventHandler(this.Runner2_Click);
            // 
            // runner3
            // 
            this.runner3.Image = ((System.Drawing.Image)(resources.GetObject("runner3.Image")));
            this.runner3.Location = new System.Drawing.Point(12, 151);
            this.runner3.Name = "runner3";
            this.runner3.Size = new System.Drawing.Size(108, 54);
            this.runner3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.runner3.TabIndex = 2;
            this.runner3.TabStop = false;
            this.runner3.Click += new System.EventHandler(this.Runner3_Click);
            // 
            // runner4
            // 
            this.runner4.Image = ((System.Drawing.Image)(resources.GetObject("runner4.Image")));
            this.runner4.Location = new System.Drawing.Point(12, 220);
            this.runner4.Name = "runner4";
            this.runner4.Size = new System.Drawing.Size(108, 54);
            this.runner4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.runner4.TabIndex = 3;
            this.runner4.TabStop = false;
            this.runner4.Click += new System.EventHandler(this.Runner4_Click);
            // 
            // p1
            // 
            this.p1.Image = ((System.Drawing.Image)(resources.GetObject("p1.Image")));
            this.p1.Location = new System.Drawing.Point(48, 289);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(103, 97);
            this.p1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p1.TabIndex = 4;
            this.p1.TabStop = false;
            this.p1.Click += new System.EventHandler(this.PictureBox5_Click);
            // 
            // p2
            // 
            this.p2.Image = ((System.Drawing.Image)(resources.GetObject("p2.Image")));
            this.p2.Location = new System.Drawing.Point(233, 289);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(107, 97);
            this.p2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p2.TabIndex = 5;
            this.p2.TabStop = false;
            this.p2.Click += new System.EventHandler(this.PictureBox6_Click);
            // 
            // p3
            // 
            this.p3.Image = ((System.Drawing.Image)(resources.GetObject("p3.Image")));
            this.p3.Location = new System.Drawing.Point(502, 289);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(111, 97);
            this.p3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p3.TabIndex = 6;
            this.p3.TabStop = false;
            this.p3.Click += new System.EventHandler(this.P3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Script MT Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(741, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 43);
            this.button1.TabIndex = 7;
            this.button1.Text = "Bet";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Script MT Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(741, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 43);
            this.button2.TabIndex = 8;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Font = new System.Drawing.Font("Script MT Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(741, 374);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 43);
            this.button3.TabIndex = 9;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Font = new System.Drawing.Font("Script MT Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(741, 423);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 43);
            this.button4.TabIndex = 10;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Player1
            // 
            this.Player1.AutoSize = true;
            this.Player1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1.Location = new System.Drawing.Point(8, 402);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(31, 13);
            this.Player1.TabIndex = 11;
            this.Player1.Text = "Anny";
            this.Player1.Click += new System.EventHandler(this.Player1_Click);
            // 
            // Player2
            // 
            this.Player2.AutoSize = true;
            this.Player2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2.Location = new System.Drawing.Point(229, 402);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(26, 13);
            this.Player2.TabIndex = 12;
            this.Player2.Text = "Anu";
            // 
            // Player3
            // 
            this.Player3.AutoSize = true;
            this.Player3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player3.Location = new System.Drawing.Point(498, 402);
            this.Player3.Name = "Player3";
            this.Player3.Size = new System.Drawing.Size(32, 13);
            this.Player3.TabIndex = 13;
            this.Player3.Text = "Anjali";
            // 
            // betAmount
            // 
            this.betAmount.BackColor = System.Drawing.Color.Gray;
            this.betAmount.Location = new System.Drawing.Point(48, 442);
            this.betAmount.Maximum = 50;
            this.betAmount.Name = "betAmount";
            this.betAmount.Size = new System.Drawing.Size(419, 45);
            this.betAmount.TabIndex = 14;
            this.betAmount.TickFrequency = 10;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(836, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 419);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 474);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "20";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 474);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "30";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 474);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "40";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(448, 474);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "50";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 474);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "0";
            // 
            // blance1
            // 
            this.blance1.AutoSize = true;
            this.blance1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blance1.Location = new System.Drawing.Point(8, 423);
            this.blance1.Name = "blance1";
            this.blance1.Size = new System.Drawing.Size(0, 13);
            this.blance1.TabIndex = 22;
            // 
            // balance2
            // 
            this.balance2.AutoSize = true;
            this.balance2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance2.Location = new System.Drawing.Point(229, 426);
            this.balance2.Name = "balance2";
            this.balance2.Size = new System.Drawing.Size(0, 13);
            this.balance2.TabIndex = 23;
            // 
            // balance3
            // 
            this.balance3.AutoSize = true;
            this.balance3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance3.Location = new System.Drawing.Point(499, 423);
            this.balance3.Name = "balance3";
            this.balance3.Size = new System.Drawing.Size(0, 13);
            this.balance3.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 528);
            this.Controls.Add(this.balance3);
            this.Controls.Add(this.balance2);
            this.Controls.Add(this.blance1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.betAmount);
            this.Controls.Add(this.Player3);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.p3);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.runner4);
            this.Controls.Add(this.runner3);
            this.Controls.Add(this.runner2);
            this.Controls.Add(this.runner1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.runner1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.runner2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.runner3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.runner4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox runner1;
        private System.Windows.Forms.PictureBox runner2;
        private System.Windows.Forms.PictureBox runner3;
        private System.Windows.Forms.PictureBox runner4;
        private System.Windows.Forms.PictureBox p1;
        private System.Windows.Forms.PictureBox p2;
        private System.Windows.Forms.PictureBox p3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label Player1;
        private System.Windows.Forms.Label Player2;
        private System.Windows.Forms.Label Player3;
        private System.Windows.Forms.TrackBar betAmount;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label blance1;
        private System.Windows.Forms.Label balance2;
        private System.Windows.Forms.Label balance3;
    }
}

