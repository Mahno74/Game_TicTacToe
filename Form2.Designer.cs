namespace TicTacToe_TheGame
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.p1_name_label = new System.Windows.Forms.Label();
            this.p2_name_lable = new System.Windows.Forms.Label();
            this.p1_textBox = new System.Windows.Forms.TextBox();
            this.p2_textBox = new System.Windows.Forms.TextBox();
            this.accept_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // p1_name_label
            // 
            this.p1_name_label.AutoSize = true;
            this.p1_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.p1_name_label.Location = new System.Drawing.Point(14, 18);
            this.p1_name_label.Name = "p1_name_label";
            this.p1_name_label.Size = new System.Drawing.Size(73, 20);
            this.p1_name_label.TabIndex = 0;
            this.p1_name_label.Text = "Player 1";
            // 
            // p2_name_lable
            // 
            this.p2_name_lable.AutoSize = true;
            this.p2_name_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.p2_name_lable.Location = new System.Drawing.Point(14, 50);
            this.p2_name_lable.Name = "p2_name_lable";
            this.p2_name_lable.Size = new System.Drawing.Size(73, 20);
            this.p2_name_lable.TabIndex = 0;
            this.p2_name_lable.Text = "Player 2";
            // 
            // p1_textBox
            // 
            this.p1_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.p1_textBox.Location = new System.Drawing.Point(93, 15);
            this.p1_textBox.Name = "p1_textBox";
            this.p1_textBox.Size = new System.Drawing.Size(179, 26);
            this.p1_textBox.TabIndex = 1;
            // 
            // p2_textBox
            // 
            this.p2_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.p2_textBox.Location = new System.Drawing.Point(93, 47);
            this.p2_textBox.Name = "p2_textBox";
            this.p2_textBox.Size = new System.Drawing.Size(179, 26);
            this.p2_textBox.TabIndex = 2;
            // 
            // accept_button
            // 
            this.accept_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accept_button.Location = new System.Drawing.Point(197, 79);
            this.accept_button.Name = "accept_button";
            this.accept_button.Size = new System.Drawing.Size(75, 32);
            this.accept_button.TabIndex = 3;
            this.accept_button.Text = "Play";
            this.accept_button.UseVisualStyleBackColor = true;
            this.accept_button.Click += new System.EventHandler(this.Accept_button_Click);
            // 
            // Form2
            // 
            this.AcceptButton = this.accept_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 121);
            this.Controls.Add(this.accept_button);
            this.Controls.Add(this.p2_textBox);
            this.Controls.Add(this.p1_textBox);
            this.Controls.Add(this.p2_name_lable);
            this.Controls.Add(this.p1_name_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Select players";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label p1_name_label;
        private System.Windows.Forms.Label p2_name_lable;
        private System.Windows.Forms.TextBox p1_textBox;
        private System.Windows.Forms.TextBox p2_textBox;
        private System.Windows.Forms.Button accept_button;
    }
}