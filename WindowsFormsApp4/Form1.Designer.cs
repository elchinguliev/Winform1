namespace WindowsFormsApp4
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
            this.londonbtn = new System.Windows.Forms.Button();
            this.bakubtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // londonbtn
            // 
            this.londonbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.londonbtn.Location = new System.Drawing.Point(62, 246);
            this.londonbtn.Name = "londonbtn";
            this.londonbtn.Size = new System.Drawing.Size(283, 55);
            this.londonbtn.TabIndex = 2;
            this.londonbtn.Text = "LONDON";
            this.londonbtn.UseVisualStyleBackColor = true;
            this.londonbtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.londonbtn_MouseClick);
            // 
            // bakubtn
            // 
            this.bakubtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bakubtn.Location = new System.Drawing.Point(449, 246);
            this.bakubtn.Name = "bakubtn";
            this.bakubtn.Size = new System.Drawing.Size(196, 55);
            this.bakubtn.TabIndex = 3;
            this.bakubtn.Text = "BAKU";
            this.bakubtn.UseVisualStyleBackColor = true;
            this.bakubtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bakubtn_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.Bakiu;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bakubtn);
            this.Controls.Add(this.londonbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button londonbtn;
        private System.Windows.Forms.Button bakubtn;
    }
}

