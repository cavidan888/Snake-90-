namespace ilan
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
            this.Down = new System.Windows.Forms.Button();
            this.uP = new System.Windows.Forms.Button();
            this.Right = new System.Windows.Forms.Button();
            this.Left = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Down
            // 
            this.Down.Location = new System.Drawing.Point(617, 289);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(59, 23);
            this.Down.TabIndex = 1;
            this.Down.Text = "Down";
            this.Down.UseVisualStyleBackColor = true;
          
            // 
            // uP
            // 
            this.uP.Location = new System.Drawing.Point(618, 231);
            this.uP.Name = "uP";
            this.uP.Size = new System.Drawing.Size(59, 23);
            this.uP.TabIndex = 2;
            this.uP.Text = "Yuxari";
            this.uP.UseVisualStyleBackColor = true;
          
            // 
            // Right
            // 
            this.Right.Location = new System.Drawing.Point(685, 261);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(59, 23);
            this.Right.TabIndex = 3;
            this.Right.Text = "Sag";
            this.Right.UseVisualStyleBackColor = true;

            // 
            // Left
            // 
            this.Left.Location = new System.Drawing.Point(549, 260);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(59, 23);
            this.Left.TabIndex = 4;
            this.Left.Text = "Sol";
            this.Left.UseVisualStyleBackColor = true;
       
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Down);
            this.panel1.Controls.Add(this.Right);
            this.panel1.Controls.Add(this.Left);
            this.panel1.Controls.Add(this.uP);
            this.panel1.Location = new System.Drawing.Point(172, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 349);
            this.panel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1105, 514);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Down;
        private System.Windows.Forms.Button uP;
        private System.Windows.Forms.Button Right;
        private System.Windows.Forms.Button Left;
        private System.Windows.Forms.Panel panel1;
    }
}

