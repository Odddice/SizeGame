namespace ShrinkingGame
{
    partial class StartUp
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
            this.btn_Game1 = new System.Windows.Forms.Button();
            this.btn_Game2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Game1
            // 
            this.btn_Game1.Location = new System.Drawing.Point(12, 12);
            this.btn_Game1.Name = "btn_Game1";
            this.btn_Game1.Size = new System.Drawing.Size(258, 113);
            this.btn_Game1.TabIndex = 0;
            this.btn_Game1.Text = "Original Size Game";
            this.btn_Game1.UseVisualStyleBackColor = true;
            this.btn_Game1.Click += new System.EventHandler(this.btn_Game1_Click);
            // 
            // btn_Game2
            // 
            this.btn_Game2.Location = new System.Drawing.Point(287, 12);
            this.btn_Game2.Name = "btn_Game2";
            this.btn_Game2.Size = new System.Drawing.Size(252, 113);
            this.btn_Game2.TabIndex = 1;
            this.btn_Game2.Text = "Size Combat Game";
            this.btn_Game2.UseVisualStyleBackColor = true;
            this.btn_Game2.Click += new System.EventHandler(this.btn_Game2_Click);
            // 
            // StartUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 137);
            this.Controls.Add(this.btn_Game2);
            this.Controls.Add(this.btn_Game1);
            this.Name = "StartUp";
            this.Text = "StartUp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Game1;
        private System.Windows.Forms.Button btn_Game2;
    }
}