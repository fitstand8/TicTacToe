namespace TicTacToe
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.C1 = new System.Windows.Forms.PictureBox();
            this.C2 = new System.Windows.Forms.PictureBox();
            this.C3 = new System.Windows.Forms.PictureBox();
            this.B3 = new System.Windows.Forms.PictureBox();
            this.B2 = new System.Windows.Forms.PictureBox();
            this.B1 = new System.Windows.Forms.PictureBox();
            this.A1 = new System.Windows.Forms.PictureBox();
            this.A2 = new System.Windows.Forms.PictureBox();
            this.A3 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startSsXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startAsOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTurn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.C1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // C1
            // 
            this.C1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.C1.Location = new System.Drawing.Point(12, 207);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(70, 70);
            this.C1.TabIndex = 0;
            this.C1.TabStop = false;
            this.C1.Click += new System.EventHandler(this.btnClick);
            // 
            // C2
            // 
            this.C2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.C2.Location = new System.Drawing.Point(88, 207);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(70, 70);
            this.C2.TabIndex = 1;
            this.C2.TabStop = false;
            this.C2.Click += new System.EventHandler(this.btnClick);
            // 
            // C3
            // 
            this.C3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.C3.Location = new System.Drawing.Point(164, 207);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(70, 70);
            this.C3.TabIndex = 2;
            this.C3.TabStop = false;
            this.C3.Click += new System.EventHandler(this.btnClick);
            // 
            // B3
            // 
            this.B3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.B3.Location = new System.Drawing.Point(164, 131);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(70, 70);
            this.B3.TabIndex = 3;
            this.B3.TabStop = false;
            this.B3.Click += new System.EventHandler(this.btnClick);
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.B2.Location = new System.Drawing.Point(88, 131);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(70, 70);
            this.B2.TabIndex = 4;
            this.B2.TabStop = false;
            this.B2.Click += new System.EventHandler(this.btnClick);
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.B1.Location = new System.Drawing.Point(12, 131);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(70, 70);
            this.B1.TabIndex = 5;
            this.B1.TabStop = false;
            this.B1.Click += new System.EventHandler(this.btnClick);
            // 
            // A1
            // 
            this.A1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.A1.Location = new System.Drawing.Point(12, 55);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(70, 70);
            this.A1.TabIndex = 6;
            this.A1.TabStop = false;
            this.A1.Click += new System.EventHandler(this.btnClick);
            // 
            // A2
            // 
            this.A2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.A2.Location = new System.Drawing.Point(88, 55);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(70, 70);
            this.A2.TabIndex = 7;
            this.A2.TabStop = false;
            this.A2.Click += new System.EventHandler(this.btnClick);
            // 
            // A3
            // 
            this.A3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.A3.Location = new System.Drawing.Point(164, 55);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(70, 70);
            this.A3.TabIndex = 8;
            this.A3.TabStop = false;
            this.A3.Click += new System.EventHandler(this.btnClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(246, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startSsXToolStripMenuItem,
            this.startAsOToolStripMenuItem});
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            // 
            // startSsXToolStripMenuItem
            // 
            this.startSsXToolStripMenuItem.Name = "startSsXToolStripMenuItem";
            this.startSsXToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.startSsXToolStripMenuItem.Text = "Start as X";
            this.startSsXToolStripMenuItem.Click += new System.EventHandler(this.StartAsXMenuStrip);
            // 
            // startAsOToolStripMenuItem
            // 
            this.startAsOToolStripMenuItem.Name = "startAsOToolStripMenuItem";
            this.startAsOToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.startAsOToolStripMenuItem.Text = "Start as O";
            this.startAsOToolStripMenuItem.Click += new System.EventHandler(this.StartAsOMenuStrip);
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTurn.Location = new System.Drawing.Point(12, 33);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(0, 17);
            this.lblTurn.TabIndex = 10;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 287);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.C1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox C1;
        private System.Windows.Forms.PictureBox C2;
        private System.Windows.Forms.PictureBox C3;
        private System.Windows.Forms.PictureBox B3;
        private System.Windows.Forms.PictureBox B2;
        private System.Windows.Forms.PictureBox B1;
        private System.Windows.Forms.PictureBox A1;
        private System.Windows.Forms.PictureBox A2;
        private System.Windows.Forms.PictureBox A3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startSsXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startAsOToolStripMenuItem;
        private System.Windows.Forms.Label lblTurn;
    }
}

