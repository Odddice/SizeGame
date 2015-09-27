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
            this.txt_Player1 = new System.Windows.Forms.TextBox();
            this.txt_Player2 = new System.Windows.Forms.TextBox();
            this.btn_Shrink = new System.Windows.Forms.Button();
            this.btn_Grow = new System.Windows.Forms.Button();
            this.btn_Steal = new System.Windows.Forms.Button();
            this.btn_ShrinkDOT = new System.Windows.Forms.Button();
            this.btn_GrowDOT = new System.Windows.Forms.Button();
            this.btn_StealDOT = new System.Windows.Forms.Button();
            this.txt_Player3 = new System.Windows.Forms.TextBox();
            this.txt_Player4 = new System.Windows.Forms.TextBox();
            this.txt_P1Size = new System.Windows.Forms.TextBox();
            this.txt_P3Size = new System.Windows.Forms.TextBox();
            this.txt_P2Size = new System.Windows.Forms.TextBox();
            this.txt_P4Size = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCheckpoint = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.rtb_Desc = new System.Windows.Forms.RichTextBox();
            this.txt_BFLink = new System.Windows.Forms.TextBox();
            this.txt_P1Start = new System.Windows.Forms.TextBox();
            this.txt_P2Start = new System.Windows.Forms.TextBox();
            this.txt_P3Start = new System.Windows.Forms.TextBox();
            this.txt_P4Start = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
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
            // txt_Player1
            // 
            this.txt_Player1.Location = new System.Drawing.Point(90, 374);
            this.txt_Player1.Name = "txt_Player1";
            this.txt_Player1.Size = new System.Drawing.Size(100, 20);
            this.txt_Player1.TabIndex = 3;
            // 
            // txt_Player2
            // 
            this.txt_Player2.Location = new System.Drawing.Point(598, 374);
            this.txt_Player2.Name = "txt_Player2";
            this.txt_Player2.Size = new System.Drawing.Size(100, 20);
            this.txt_Player2.TabIndex = 4;
            // 
            // btn_Shrink
            // 
            this.btn_Shrink.Location = new System.Drawing.Point(409, 341);
            this.btn_Shrink.Name = "btn_Shrink";
            this.btn_Shrink.Size = new System.Drawing.Size(75, 23);
            this.btn_Shrink.TabIndex = 5;
            this.btn_Shrink.Text = "Shrink";
            this.btn_Shrink.UseVisualStyleBackColor = true;
            this.btn_Shrink.Click += new System.EventHandler(this.btn_Shrink_Click);
            // 
            // btn_Grow
            // 
            this.btn_Grow.Location = new System.Drawing.Point(409, 394);
            this.btn_Grow.Name = "btn_Grow";
            this.btn_Grow.Size = new System.Drawing.Size(75, 23);
            this.btn_Grow.TabIndex = 6;
            this.btn_Grow.Text = "Grow";
            this.btn_Grow.UseVisualStyleBackColor = true;
            this.btn_Grow.Click += new System.EventHandler(this.btn_Grow_Click);
            // 
            // btn_Steal
            // 
            this.btn_Steal.Location = new System.Drawing.Point(409, 449);
            this.btn_Steal.Name = "btn_Steal";
            this.btn_Steal.Size = new System.Drawing.Size(75, 23);
            this.btn_Steal.TabIndex = 7;
            this.btn_Steal.Text = "Steal";
            this.btn_Steal.UseVisualStyleBackColor = true;
            this.btn_Steal.Click += new System.EventHandler(this.btn_Steal_Click);
            // 
            // btn_ShrinkDOT
            // 
            this.btn_ShrinkDOT.Location = new System.Drawing.Point(409, 504);
            this.btn_ShrinkDOT.Name = "btn_ShrinkDOT";
            this.btn_ShrinkDOT.Size = new System.Drawing.Size(75, 23);
            this.btn_ShrinkDOT.TabIndex = 8;
            this.btn_ShrinkDOT.Text = "Shrink DOT";
            this.btn_ShrinkDOT.UseVisualStyleBackColor = true;
            this.btn_ShrinkDOT.Click += new System.EventHandler(this.btn_ShrinkDOT_Click);
            // 
            // btn_GrowDOT
            // 
            this.btn_GrowDOT.Location = new System.Drawing.Point(409, 560);
            this.btn_GrowDOT.Name = "btn_GrowDOT";
            this.btn_GrowDOT.Size = new System.Drawing.Size(75, 23);
            this.btn_GrowDOT.TabIndex = 9;
            this.btn_GrowDOT.Text = "Grow DOT";
            this.btn_GrowDOT.UseVisualStyleBackColor = true;
            this.btn_GrowDOT.Click += new System.EventHandler(this.btn_GrowDOT_Click);
            // 
            // btn_StealDOT
            // 
            this.btn_StealDOT.Location = new System.Drawing.Point(409, 621);
            this.btn_StealDOT.Name = "btn_StealDOT";
            this.btn_StealDOT.Size = new System.Drawing.Size(75, 23);
            this.btn_StealDOT.TabIndex = 10;
            this.btn_StealDOT.Text = "Steal DOT";
            this.btn_StealDOT.UseVisualStyleBackColor = true;
            this.btn_StealDOT.Click += new System.EventHandler(this.btn_StealDOT_Click);
            // 
            // txt_Player3
            // 
            this.txt_Player3.Location = new System.Drawing.Point(90, 516);
            this.txt_Player3.Name = "txt_Player3";
            this.txt_Player3.Size = new System.Drawing.Size(100, 20);
            this.txt_Player3.TabIndex = 13;
            // 
            // txt_Player4
            // 
            this.txt_Player4.Location = new System.Drawing.Point(598, 516);
            this.txt_Player4.Name = "txt_Player4";
            this.txt_Player4.Size = new System.Drawing.Size(100, 20);
            this.txt_Player4.TabIndex = 14;
            // 
            // txt_P1Size
            // 
            this.txt_P1Size.Location = new System.Drawing.Point(196, 374);
            this.txt_P1Size.Name = "txt_P1Size";
            this.txt_P1Size.Size = new System.Drawing.Size(100, 20);
            this.txt_P1Size.TabIndex = 15;
            // 
            // txt_P3Size
            // 
            this.txt_P3Size.Location = new System.Drawing.Point(196, 516);
            this.txt_P3Size.Name = "txt_P3Size";
            this.txt_P3Size.Size = new System.Drawing.Size(100, 20);
            this.txt_P3Size.TabIndex = 16;
            // 
            // txt_P2Size
            // 
            this.txt_P2Size.Location = new System.Drawing.Point(704, 374);
            this.txt_P2Size.Name = "txt_P2Size";
            this.txt_P2Size.Size = new System.Drawing.Size(100, 20);
            this.txt_P2Size.TabIndex = 17;
            // 
            // txt_P4Size
            // 
            this.txt_P4Size.Location = new System.Drawing.Point(704, 516);
            this.txt_P4Size.Name = "txt_P4Size";
            this.txt_P4Size.Size = new System.Drawing.Size(100, 20);
            this.txt_P4Size.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Player 1 Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 500);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Player 3 Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(595, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Player 2 Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(595, 500);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Player 4 Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Current Size";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 500);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Current Size";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(740, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Current Size";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(740, 500);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Current Size";
            // 
            // btnCheckpoint
            // 
            this.btnCheckpoint.Location = new System.Drawing.Point(108, 578);
            this.btnCheckpoint.Name = "btnCheckpoint";
            this.btnCheckpoint.Size = new System.Drawing.Size(167, 71);
            this.btnCheckpoint.TabIndex = 27;
            this.btnCheckpoint.Text = "Save";
            this.btnCheckpoint.UseVisualStyleBackColor = true;
            this.btnCheckpoint.Click += new System.EventHandler(this.btnCheckpoint_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(619, 578);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(167, 71);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // rtb_Desc
            // 
            this.rtb_Desc.Location = new System.Drawing.Point(12, 198);
            this.rtb_Desc.Name = "rtb_Desc";
            this.rtb_Desc.Size = new System.Drawing.Size(871, 86);
            this.rtb_Desc.TabIndex = 29;
            this.rtb_Desc.Text = "";
            // 
            // txt_BFLink
            // 
            this.txt_BFLink.Location = new System.Drawing.Point(12, 290);
            this.txt_BFLink.Name = "txt_BFLink";
            this.txt_BFLink.Size = new System.Drawing.Size(871, 20);
            this.txt_BFLink.TabIndex = 30;
            // 
            // txt_P1Start
            // 
            this.txt_P1Start.Location = new System.Drawing.Point(196, 400);
            this.txt_P1Start.Name = "txt_P1Start";
            this.txt_P1Start.Size = new System.Drawing.Size(100, 20);
            this.txt_P1Start.TabIndex = 31;
            this.txt_P1Start.Text = "1828800";
            // 
            // txt_P2Start
            // 
            this.txt_P2Start.Location = new System.Drawing.Point(704, 400);
            this.txt_P2Start.Name = "txt_P2Start";
            this.txt_P2Start.Size = new System.Drawing.Size(100, 20);
            this.txt_P2Start.TabIndex = 32;
            this.txt_P2Start.Text = "1828800";
            // 
            // txt_P3Start
            // 
            this.txt_P3Start.Location = new System.Drawing.Point(196, 542);
            this.txt_P3Start.Name = "txt_P3Start";
            this.txt_P3Start.Size = new System.Drawing.Size(100, 20);
            this.txt_P3Start.TabIndex = 33;
            this.txt_P3Start.Text = "1828800";
            // 
            // txt_P4Start
            // 
            this.txt_P4Start.Location = new System.Drawing.Point(704, 542);
            this.txt_P4Start.Name = "txt_P4Start";
            this.txt_P4Start.Size = new System.Drawing.Size(100, 20);
            this.txt_P4Start.TabIndex = 34;
            this.txt_P4Start.Text = "1828800";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(121, 403);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Starting Size:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(629, 403);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Starting Size:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(121, 545);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "Starting Size:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(629, 545);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "Starting Size:";
            // 
            // Clash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 682);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_P4Start);
            this.Controls.Add(this.txt_P3Start);
            this.Controls.Add(this.txt_P2Start);
            this.Controls.Add(this.txt_P1Start);
            this.Controls.Add(this.txt_BFLink);
            this.Controls.Add(this.rtb_Desc);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCheckpoint);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_P4Size);
            this.Controls.Add(this.txt_P2Size);
            this.Controls.Add(this.txt_P3Size);
            this.Controls.Add(this.txt_P1Size);
            this.Controls.Add(this.txt_Player4);
            this.Controls.Add(this.txt_Player3);
            this.Controls.Add(this.btn_StealDOT);
            this.Controls.Add(this.btn_GrowDOT);
            this.Controls.Add(this.btn_ShrinkDOT);
            this.Controls.Add(this.btn_Steal);
            this.Controls.Add(this.btn_Grow);
            this.Controls.Add(this.btn_Shrink);
            this.Controls.Add(this.txt_Player2);
            this.Controls.Add(this.txt_Player1);
            this.Controls.Add(this.rtb_Output);
            this.Name = "Clash";
            this.Text = "Clash";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_Output;
        private System.Windows.Forms.TextBox txt_Player1;
        private System.Windows.Forms.TextBox txt_Player2;
        private System.Windows.Forms.Button btn_Shrink;
        private System.Windows.Forms.Button btn_Grow;
        private System.Windows.Forms.Button btn_Steal;
        private System.Windows.Forms.Button btn_ShrinkDOT;
        private System.Windows.Forms.Button btn_GrowDOT;
        private System.Windows.Forms.Button btn_StealDOT;
        private System.Windows.Forms.TextBox txt_Player3;
        private System.Windows.Forms.TextBox txt_Player4;
        private System.Windows.Forms.TextBox txt_P1Size;
        private System.Windows.Forms.TextBox txt_P3Size;
        private System.Windows.Forms.TextBox txt_P2Size;
        private System.Windows.Forms.TextBox txt_P4Size;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCheckpoint;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RichTextBox rtb_Desc;
        private System.Windows.Forms.TextBox txt_BFLink;
        private System.Windows.Forms.TextBox txt_P1Start;
        private System.Windows.Forms.TextBox txt_P2Start;
        private System.Windows.Forms.TextBox txt_P3Start;
        private System.Windows.Forms.TextBox txt_P4Start;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}