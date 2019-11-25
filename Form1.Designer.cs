namespace TicTacToe_TheGame
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restWinCountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.O_WinCount_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.X_WinCount_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.Draw_Count_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(254, 24);
            this.menuStrip1.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.restWinCountsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // restWinCountsToolStripMenuItem
            // 
            this.restWinCountsToolStripMenuItem.Name = "restWinCountsToolStripMenuItem";
            this.restWinCountsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.restWinCountsToolStripMenuItem.Text = "Reset win counts";
            this.restWinCountsToolStripMenuItem.Click += new System.EventHandler(this.Reset_win_counts);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitMenuItem);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutMenuItem);
            // 
            // A1
            // 
            this.A1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A1.Location = new System.Drawing.Point(9, 35);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(75, 75);
            this.A1.TabIndex = 1;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.Button_click);
            this.A1.MouseEnter += new System.EventHandler(this.Mouse_enter);
            this.A1.MouseLeave += new System.EventHandler(this.Mouse_leave);
            // 
            // A2
            // 
            this.A2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A2.Location = new System.Drawing.Point(90, 35);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(75, 75);
            this.A2.TabIndex = 1;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.Button_click);
            this.A2.MouseEnter += new System.EventHandler(this.Mouse_enter);
            this.A2.MouseLeave += new System.EventHandler(this.Mouse_leave);
            // 
            // A3
            // 
            this.A3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A3.Location = new System.Drawing.Point(171, 35);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(75, 75);
            this.A3.TabIndex = 1;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.Button_click);
            this.A3.MouseEnter += new System.EventHandler(this.Mouse_enter);
            this.A3.MouseLeave += new System.EventHandler(this.Mouse_leave);
            // 
            // B1
            // 
            this.B1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B1.Location = new System.Drawing.Point(9, 116);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(75, 75);
            this.B1.TabIndex = 1;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.Button_click);
            this.B1.MouseEnter += new System.EventHandler(this.Mouse_enter);
            this.B1.MouseLeave += new System.EventHandler(this.Mouse_leave);
            // 
            // B2
            // 
            this.B2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B2.Location = new System.Drawing.Point(90, 116);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(75, 75);
            this.B2.TabIndex = 1;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.Button_click);
            this.B2.MouseEnter += new System.EventHandler(this.Mouse_enter);
            this.B2.MouseLeave += new System.EventHandler(this.Mouse_leave);
            // 
            // B3
            // 
            this.B3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B3.Location = new System.Drawing.Point(171, 116);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(75, 75);
            this.B3.TabIndex = 1;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.Button_click);
            this.B3.MouseEnter += new System.EventHandler(this.Mouse_enter);
            this.B3.MouseLeave += new System.EventHandler(this.Mouse_leave);
            // 
            // C1
            // 
            this.C1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.C1.Location = new System.Drawing.Point(9, 197);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(75, 75);
            this.C1.TabIndex = 1;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.Button_click);
            this.C1.MouseEnter += new System.EventHandler(this.Mouse_enter);
            this.C1.MouseLeave += new System.EventHandler(this.Mouse_leave);
            // 
            // C2
            // 
            this.C2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.C2.Location = new System.Drawing.Point(90, 197);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(75, 75);
            this.C2.TabIndex = 1;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.Button_click);
            this.C2.MouseEnter += new System.EventHandler(this.Mouse_enter);
            this.C2.MouseLeave += new System.EventHandler(this.Mouse_leave);
            // 
            // C3
            // 
            this.C3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.C3.Location = new System.Drawing.Point(171, 197);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(75, 75);
            this.C3.TabIndex = 1;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.Button_click);
            this.C3.MouseEnter += new System.EventHandler(this.Mouse_enter);
            this.C3.MouseLeave += new System.EventHandler(this.Mouse_leave);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.O_WinCount_label,
            this.X_WinCount_label,
            this.Draw_Count_label});
            this.statusStrip1.Location = new System.Drawing.Point(0, 292);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(254, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // O_WinCount_label
            // 
            this.O_WinCount_label.Name = "O_WinCount_label";
            this.O_WinCount_label.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.O_WinCount_label.Size = new System.Drawing.Size(73, 17);
            this.O_WinCount_label.Text = "O wins = 0";
            // 
            // X_WinCount_label
            // 
            this.X_WinCount_label.Name = "X_WinCount_label";
            this.X_WinCount_label.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.X_WinCount_label.Size = new System.Drawing.Size(71, 17);
            this.X_WinCount_label.Text = "X wins = 0";
            // 
            // Draw_Count_label
            // 
            this.Draw_Count_label.Name = "Draw_Count_label";
            this.Draw_Count_label.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.Draw_Count_label.Size = new System.Drawing.Size(69, 17);
            this.Draw_Count_label.Text = "Draws = 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 314);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = " Tic Tac Toe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel O_WinCount_label;
        private System.Windows.Forms.ToolStripStatusLabel X_WinCount_label;
        private System.Windows.Forms.ToolStripStatusLabel Draw_Count_label;
        private System.Windows.Forms.ToolStripMenuItem restWinCountsToolStripMenuItem;
    }
}

