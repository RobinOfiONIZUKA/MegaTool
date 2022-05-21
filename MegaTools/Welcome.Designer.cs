namespace MegaTools
{
    partial class Welcome
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
            this.darkDockPanel1 = new DarkUI.Docking.DarkDockPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // darkDockPanel1
            // 
            this.darkDockPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkDockPanel1.Location = new System.Drawing.Point(12, 12);
            this.darkDockPanel1.Name = "darkDockPanel1";
            this.darkDockPanel1.Size = new System.Drawing.Size(714, 387);
            this.darkDockPanel1.TabIndex = 3;
            this.darkDockPanel1.Load += new System.EventHandler(this.darkDockPanel1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(127, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 128);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(241, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 50);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 24.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(703, 180);
            this.label3.TabIndex = 6;
            this.label3.Text = "If you want to use any fortnite tool just \r\nhit the fortnite button, if you want " +
    "to use \r\nany roblox tool just hit \r\nthe button named roblox";
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(739, 418);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.darkDockPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DarkUI.Docking.DarkDockPanel darkDockPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}