namespace ShrinkingGame
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
            this.btnRoll = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtP1Name = new System.Windows.Forms.TextBox();
            this.txtSize1 = new System.Windows.Forms.TextBox();
            this.txtP2Name = new System.Windows.Forms.TextBox();
            this.txtSize2 = new System.Windows.Forms.TextBox();
            this.txtRecap = new System.Windows.Forms.RichTextBox();
            this.txtBFLink = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStartP1 = new System.Windows.Forms.TextBox();
            this.txtStartP2 = new System.Windows.Forms.TextBox();
            this.btnCheckpoint = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(29, 559);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(167, 71);
            this.btnRoll.TabIndex = 7;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(257, 559);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(167, 71);
            this.btnCopy.TabIndex = 8;
            this.btnCopy.Text = "Copy Link";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(705, 559);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(167, 71);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(13, 13);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(608, 351);
            this.txtDisplay.TabIndex = 10;
            this.txtDisplay.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(668, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Player 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(775, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Player 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(627, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(627, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = "Starting\r\nHeight";
            // 
            // txtP1Name
            // 
            this.txtP1Name.Location = new System.Drawing.Point(671, 52);
            this.txtP1Name.Name = "txtP1Name";
            this.txtP1Name.Size = new System.Drawing.Size(100, 20);
            this.txtP1Name.TabIndex = 1;
            // 
            // txtSize1
            // 
            this.txtSize1.Location = new System.Drawing.Point(671, 90);
            this.txtSize1.Name = "txtSize1";
            this.txtSize1.Size = new System.Drawing.Size(100, 20);
            this.txtSize1.TabIndex = 3;
            this.txtSize1.Text = "6";
            // 
            // txtP2Name
            // 
            this.txtP2Name.Location = new System.Drawing.Point(778, 52);
            this.txtP2Name.Name = "txtP2Name";
            this.txtP2Name.Size = new System.Drawing.Size(100, 20);
            this.txtP2Name.TabIndex = 2;
            // 
            // txtSize2
            // 
            this.txtSize2.Location = new System.Drawing.Point(778, 90);
            this.txtSize2.Name = "txtSize2";
            this.txtSize2.Size = new System.Drawing.Size(100, 20);
            this.txtSize2.TabIndex = 4;
            this.txtSize2.Text = "6";
            // 
            // txtRecap
            // 
            this.txtRecap.Location = new System.Drawing.Point(13, 390);
            this.txtRecap.Name = "txtRecap";
            this.txtRecap.Size = new System.Drawing.Size(609, 86);
            this.txtRecap.TabIndex = 11;
            this.txtRecap.Text = "";
            // 
            // txtBFLink
            // 
            this.txtBFLink.Location = new System.Drawing.Point(12, 510);
            this.txtBFLink.Name = "txtBFLink";
            this.txtBFLink.Size = new System.Drawing.Size(866, 20);
            this.txtBFLink.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(627, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Name";
            // 
            // txtStartP1
            // 
            this.txtStartP1.Location = new System.Drawing.Point(671, 129);
            this.txtStartP1.Name = "txtStartP1";
            this.txtStartP1.Size = new System.Drawing.Size(100, 20);
            this.txtStartP1.TabIndex = 5;
            this.txtStartP1.Text = "1828800";
            // 
            // txtStartP2
            // 
            this.txtStartP2.Location = new System.Drawing.Point(777, 129);
            this.txtStartP2.Name = "txtStartP2";
            this.txtStartP2.Size = new System.Drawing.Size(100, 20);
            this.txtStartP2.TabIndex = 6;
            this.txtStartP2.Text = "1828800";
            // 
            // btnCheckpoint
            // 
            this.btnCheckpoint.Location = new System.Drawing.Point(481, 559);
            this.btnCheckpoint.Name = "btnCheckpoint";
            this.btnCheckpoint.Size = new System.Drawing.Size(167, 71);
            this.btnCheckpoint.TabIndex = 23;
            this.btnCheckpoint.Text = "Checkpoint";
            this.btnCheckpoint.UseVisualStyleBackColor = true;
            this.btnCheckpoint.Click += new System.EventHandler(this.btnCheckpoint_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(671, 293);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(167, 71);
            this.btnTest.TabIndex = 24;
            this.btnTest.Text = "Purely For Testing";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 654);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnCheckpoint);
            this.Controls.Add(this.txtStartP2);
            this.Controls.Add(this.txtStartP1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBFLink);
            this.Controls.Add(this.txtRecap);
            this.Controls.Add(this.txtSize2);
            this.Controls.Add(this.txtP2Name);
            this.Controls.Add(this.txtSize1);
            this.Controls.Add(this.txtP1Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnRoll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RichTextBox txtDisplay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtP1Name;
        private System.Windows.Forms.TextBox txtSize1;
        private System.Windows.Forms.TextBox txtP2Name;
        private System.Windows.Forms.TextBox txtSize2;
        private System.Windows.Forms.RichTextBox txtRecap;
        private System.Windows.Forms.TextBox txtBFLink;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStartP1;
        private System.Windows.Forms.TextBox txtStartP2;
        private System.Windows.Forms.Button btnCheckpoint;
        private System.Windows.Forms.Button btnTest;
    }
}

