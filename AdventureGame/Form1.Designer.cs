namespace AdventureGame
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.option1 = new System.Windows.Forms.Button();
            this.option2 = new System.Windows.Forms.Button();
            this.option3 = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.option1Label = new System.Windows.Forms.Label();
            this.option2Label = new System.Windows.Forms.Label();
            this.option3Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(67, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(438, 268);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // option1
            // 
            this.option1.Location = new System.Drawing.Point(176, 355);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(22, 23);
            this.option1.TabIndex = 1;
            this.option1.UseVisualStyleBackColor = true;
            this.option1.Click += new System.EventHandler(this.option1_Click);
            // 
            // option2
            // 
            this.option2.Location = new System.Drawing.Point(176, 384);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(22, 23);
            this.option2.TabIndex = 2;
            this.option2.UseVisualStyleBackColor = true;
            this.option2.Click += new System.EventHandler(this.option2_Click);
            // 
            // option3
            // 
            this.option3.Enabled = false;
            this.option3.Location = new System.Drawing.Point(176, 413);
            this.option3.Name = "option3";
            this.option3.Size = new System.Drawing.Size(22, 23);
            this.option3.TabIndex = 3;
            this.option3.UseVisualStyleBackColor = true;
            this.option3.Visible = false;
            this.option3.Click += new System.EventHandler(this.option3_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(103, 9);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(366, 69);
            this.outputLabel.TabIndex = 4;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.outputLabel.Click += new System.EventHandler(this.outputLabel_Click);
            // 
            // option1Label
            // 
            this.option1Label.AutoSize = true;
            this.option1Label.BackColor = System.Drawing.Color.Black;
            this.option1Label.ForeColor = System.Drawing.Color.White;
            this.option1Label.Location = new System.Drawing.Point(204, 360);
            this.option1Label.Name = "option1Label";
            this.option1Label.Size = new System.Drawing.Size(0, 13);
            this.option1Label.TabIndex = 5;
            // 
            // option2Label
            // 
            this.option2Label.AutoSize = true;
            this.option2Label.ForeColor = System.Drawing.Color.White;
            this.option2Label.Location = new System.Drawing.Point(204, 389);
            this.option2Label.Name = "option2Label";
            this.option2Label.Size = new System.Drawing.Size(0, 13);
            this.option2Label.TabIndex = 6;
            // 
            // option3Label
            // 
            this.option3Label.AutoSize = true;
            this.option3Label.ForeColor = System.Drawing.Color.White;
            this.option3Label.Location = new System.Drawing.Point(204, 418);
            this.option3Label.Name = "option3Label";
            this.option3Label.Size = new System.Drawing.Size(0, 13);
            this.option3Label.TabIndex = 7;
            this.option3Label.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(570, 446);
            this.Controls.Add(this.option3Label);
            this.Controls.Add(this.option2Label);
            this.Controls.Add(this.option1Label);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.option3);
            this.Controls.Add(this.option2);
            this.Controls.Add(this.option1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Adventure Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button option1;
        private System.Windows.Forms.Button option2;
        private System.Windows.Forms.Button option3;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label option1Label;
        private System.Windows.Forms.Label option2Label;
        private System.Windows.Forms.Label option3Label;
    }
}

