namespace Random_example
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblKatse = new System.Windows.Forms.GroupBox();
            this.lblRand = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Pilt = new System.Windows.Forms.PictureBox();
            this.pilt1 = new System.Windows.Forms.PictureBox();
            this.pilt2 = new System.Windows.Forms.PictureBox();
            this.pilt3 = new System.Windows.Forms.PictureBox();
            this.lblKirjeldus = new System.Windows.Forms.Label();
            this.lblKatse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pilt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilt3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKatse
            // 
            this.lblKatse.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblKatse.Controls.Add(this.lblKirjeldus);
            this.lblKatse.Controls.Add(this.pilt3);
            this.lblKatse.Controls.Add(this.pilt2);
            this.lblKatse.Controls.Add(this.pilt1);
            this.lblKatse.Controls.Add(this.Pilt);
            this.lblKatse.Controls.Add(this.label2);
            this.lblKatse.Controls.Add(this.label1);
            this.lblKatse.Controls.Add(this.start);
            this.lblKatse.Controls.Add(this.ok);
            this.lblKatse.Controls.Add(this.lblRand);
            this.lblKatse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKatse.Location = new System.Drawing.Point(37, 37);
            this.lblKatse.Name = "lblKatse";
            this.lblKatse.Size = new System.Drawing.Size(815, 475);
            this.lblKatse.TabIndex = 0;
            this.lblKatse.TabStop = false;
            this.lblKatse.Text = "Случайное число";
            // 
            // lblRand
            // 
            this.lblRand.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRand.Location = new System.Drawing.Point(135, 59);
            this.lblRand.Name = "lblRand";
            this.lblRand.Size = new System.Drawing.Size(162, 92);
            this.lblRand.TabIndex = 0;
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(344, 62);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(152, 88);
            this.ok.TabIndex = 1;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(342, 176);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(153, 53);
            this.start.TabIndex = 2;
            this.start.Text = "начать игру";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(560, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Попытки";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(557, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Pilt
            // 
            this.Pilt.Location = new System.Drawing.Point(549, 207);
            this.Pilt.Name = "Pilt";
            this.Pilt.Size = new System.Drawing.Size(192, 137);
            this.Pilt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pilt.TabIndex = 5;
            this.Pilt.TabStop = false;
            // 
            // pilt1
            // 
            this.pilt1.Image = ((System.Drawing.Image)(resources.GetObject("pilt1.Image")));
            this.pilt1.Location = new System.Drawing.Point(47, 325);
            this.pilt1.Name = "pilt1";
            this.pilt1.Size = new System.Drawing.Size(133, 132);
            this.pilt1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pilt1.TabIndex = 6;
            this.pilt1.TabStop = false;
            // 
            // pilt2
            // 
            this.pilt2.Image = ((System.Drawing.Image)(resources.GetObject("pilt2.Image")));
            this.pilt2.Location = new System.Drawing.Point(220, 325);
            this.pilt2.Name = "pilt2";
            this.pilt2.Size = new System.Drawing.Size(124, 131);
            this.pilt2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pilt2.TabIndex = 7;
            this.pilt2.TabStop = false;
            // 
            // pilt3
            // 
            this.pilt3.Location = new System.Drawing.Point(379, 331);
            this.pilt3.Name = "pilt3";
            this.pilt3.Size = new System.Drawing.Size(116, 124);
            this.pilt3.TabIndex = 8;
            this.pilt3.TabStop = false;
            // 
            // lblKirjeldus
            // 
            this.lblKirjeldus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblKirjeldus.Location = new System.Drawing.Point(547, 381);
            this.lblKirjeldus.Name = "lblKirjeldus";
            this.lblKirjeldus.Size = new System.Drawing.Size(193, 61);
            this.lblKirjeldus.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 576);
            this.Controls.Add(this.lblKatse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.lblKatse.ResumeLayout(false);
            this.lblKatse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pilt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilt3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox lblKatse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Label lblRand;
        private System.Windows.Forms.Label lblKirjeldus;
        private System.Windows.Forms.PictureBox pilt3;
        private System.Windows.Forms.PictureBox pilt2;
        private System.Windows.Forms.PictureBox pilt1;
        private System.Windows.Forms.PictureBox Pilt;
    }
}

