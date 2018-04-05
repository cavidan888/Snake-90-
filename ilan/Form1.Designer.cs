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
            this.SuspendLayout();
            // 
            // Down
            // 
            this.Down.Location = new System.Drawing.Point(629, 395);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(59, 23);
            this.Down.TabIndex = 1;
            this.Down.Text = "Down";
            this.Down.UseVisualStyleBackColor = true;
            this.Down.Click += new System.EventHandler(this.Down_Click_1);
            // 
            // uP
            // 
            this.uP.Location = new System.Drawing.Point(630, 337);
            this.uP.Name = "uP";
            this.uP.Size = new System.Drawing.Size(59, 23);
            this.uP.TabIndex = 2;
            this.uP.Text = "Yuxari";
            this.uP.UseVisualStyleBackColor = true;
            this.uP.Click += new System.EventHandler(this.uP_Click_1);
            // 
            // Right
            // 
            this.Right.Location = new System.Drawing.Point(697, 366);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(59, 23);
            this.Right.TabIndex = 3;
            this.Right.Text = "Sag";
            this.Right.UseVisualStyleBackColor = true;
            this.Right.Click += new System.EventHandler(this.Right_Click);
            // 
            // Left
            // 
            this.Left.Location = new System.Drawing.Point(561, 366);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(59, 23);
            this.Left.TabIndex = 4;
            this.Left.Text = "Sol";
            this.Left.UseVisualStyleBackColor = true;
            this.Left.Click += new System.EventHandler(this.Left_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 425);
            this.Controls.Add(this.Down);
            this.Controls.Add(this.uP);
            this.Controls.Add(this.Right);
            this.Controls.Add(this.Left);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Down;
        private System.Windows.Forms.Button uP;
        private System.Windows.Forms.Button Right;
        private System.Windows.Forms.Button Left;
    }
}

