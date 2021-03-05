namespace TicTacToe
{
    partial class FormChoosePlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChoosePlayer));
            this.label1 = new System.Windows.Forms.Label();
            this.XPic = new System.Windows.Forms.PictureBox();
            this.OPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.XPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OPic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Who makes the first move?";
            // 
            // XPic
            // 
            this.XPic.Image = ((System.Drawing.Image)(resources.GetObject("XPic.Image")));
            this.XPic.Location = new System.Drawing.Point(113, 79);
            this.XPic.Name = "XPic";
            this.XPic.Size = new System.Drawing.Size(70, 70);
            this.XPic.TabIndex = 1;
            this.XPic.TabStop = false;
            this.XPic.Click += new System.EventHandler(this.XPic_Click);
            // 
            // OPic
            // 
            this.OPic.Image = ((System.Drawing.Image)(resources.GetObject("OPic.Image")));
            this.OPic.Location = new System.Drawing.Point(202, 79);
            this.OPic.Name = "OPic";
            this.OPic.Size = new System.Drawing.Size(70, 70);
            this.OPic.TabIndex = 2;
            this.OPic.TabStop = false;
            this.OPic.Click += new System.EventHandler(this.OPic_Click);
            // 
            // FormChoosePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.OPic);
            this.Controls.Add(this.XPic);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormChoosePlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose a player";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormChoosePlayer_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.XPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox XPic;
        private System.Windows.Forms.PictureBox OPic;
    }
}