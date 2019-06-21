namespace DrawIO
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
            this.pictureBoxVier = new System.Windows.Forms.PictureBox();
            this.pictureBoxCir = new System.Windows.Forms.PictureBox();
            this.vierkant = new System.Windows.Forms.Button();
            this.cirkel = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCir)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxVier
            // 
            this.pictureBoxVier.Location = new System.Drawing.Point(41, 45);
            this.pictureBoxVier.Name = "pictureBoxVier";
            this.pictureBoxVier.Size = new System.Drawing.Size(240, 212);
            this.pictureBoxVier.TabIndex = 0;
            this.pictureBoxVier.TabStop = false;
            // 
            // pictureBoxCir
            // 
            this.pictureBoxCir.Location = new System.Drawing.Point(312, 45);
            this.pictureBoxCir.Name = "pictureBoxCir";
            this.pictureBoxCir.Size = new System.Drawing.Size(240, 212);
            this.pictureBoxCir.TabIndex = 1;
            this.pictureBoxCir.TabStop = false;
            // 
            // vierkant
            // 
            this.vierkant.Location = new System.Drawing.Point(64, 282);
            this.vierkant.Name = "vierkant";
            this.vierkant.Size = new System.Drawing.Size(75, 23);
            this.vierkant.TabIndex = 2;
            this.vierkant.Text = "vierkant";
            this.vierkant.UseVisualStyleBackColor = true;
            this.vierkant.Click += new System.EventHandler(this.vierkant_Click);
            // 
            // cirkel
            // 
            this.cirkel.Location = new System.Drawing.Point(375, 281);
            this.cirkel.Name = "cirkel";
            this.cirkel.Size = new System.Drawing.Size(75, 23);
            this.cirkel.TabIndex = 3;
            this.cirkel.Text = "cirkel";
            this.cirkel.UseVisualStyleBackColor = true;
            this.cirkel.Click += new System.EventHandler(this.cirkel_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(205, 280);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "tekenen";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cirkel);
            this.Controls.Add(this.vierkant);
            this.Controls.Add(this.pictureBoxCir);
            this.Controls.Add(this.pictureBoxVier);
            this.Name = "Form1";
            this.Text = " kj";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxVier;
        private System.Windows.Forms.PictureBox pictureBoxCir;
        private System.Windows.Forms.Button vierkant;
        private System.Windows.Forms.Button cirkel;
        private System.Windows.Forms.Button button3;
    }
}

