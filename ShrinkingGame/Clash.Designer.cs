namespace ShrinkingGame
{
    partial class Clash
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
            this.rtb_Output = new System.Windows.Forms.RichTextBox();
            this.rb_Player1 = new System.Windows.Forms.RadioButton();
            this.rb_Player2 = new System.Windows.Forms.RadioButton();
            this.txt_Player1 = new System.Windows.Forms.TextBox();
            this.txt_Player2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rtb_Output
            // 
            this.rtb_Output.Location = new System.Drawing.Point(12, 12);
            this.rtb_Output.Name = "rtb_Output";
            this.rtb_Output.Size = new System.Drawing.Size(871, 180);
            this.rtb_Output.TabIndex = 0;
            this.rtb_Output.Text = "";
            // 
            // rb_Player1
            // 
            this.rb_Player1.AutoSize = true;
            this.rb_Player1.Location = new System.Drawing.Point(189, 221);
            this.rb_Player1.Name = "rb_Player1";
            this.rb_Player1.Size = new System.Drawing.Size(14, 13);
            this.rb_Player1.TabIndex = 1;
            this.rb_Player1.TabStop = true;
            this.rb_Player1.UseVisualStyleBackColor = true;
            this.rb_Player1.Click += new System.EventHandler(this.rb_Player1_Clicked);
            // 
            // rb_Player2
            // 
            this.rb_Player2.AutoSize = true;
            this.rb_Player2.Location = new System.Drawing.Point(592, 221);
            this.rb_Player2.Name = "rb_Player2";
            this.rb_Player2.Size = new System.Drawing.Size(14, 13);
            this.rb_Player2.TabIndex = 2;
            this.rb_Player2.TabStop = true;
            this.rb_Player2.UseVisualStyleBackColor = true;
            this.rb_Player2.Click += new System.EventHandler(this.rb_Player2_Clicked);
            // 
            // txt_Player1
            // 
            this.txt_Player1.Location = new System.Drawing.Point(209, 218);
            this.txt_Player1.Name = "txt_Player1";
            this.txt_Player1.Size = new System.Drawing.Size(100, 20);
            this.txt_Player1.TabIndex = 3;
            // 
            // txt_Player2
            // 
            this.txt_Player2.Location = new System.Drawing.Point(612, 218);
            this.txt_Player2.Name = "txt_Player2";
            this.txt_Player2.Size = new System.Drawing.Size(100, 20);
            this.txt_Player2.TabIndex = 4;
            // 
            // Clash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 643);
            this.Controls.Add(this.txt_Player2);
            this.Controls.Add(this.txt_Player1);
            this.Controls.Add(this.rb_Player2);
            this.Controls.Add(this.rb_Player1);
            this.Controls.Add(this.rtb_Output);
            this.Name = "Clash";
            this.Text = "Clash";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_Output;
        private System.Windows.Forms.RadioButton rb_Player1;
        private System.Windows.Forms.RadioButton rb_Player2;
        private System.Windows.Forms.TextBox txt_Player1;
        private System.Windows.Forms.TextBox txt_Player2;
    }
}