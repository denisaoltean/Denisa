namespace Ludo
{
    partial class fLudo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLudo));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.tbPlayer = new System.Windows.Forms.TextBox();
            this.tbPlayerr = new System.Windows.Forms.TextBox();
            this.tbPlayerrr = new System.Windows.Forms.TextBox();
            this.tbPlayerrrr = new System.Windows.Forms.TextBox();
            this.cbPlayer = new System.Windows.Forms.CheckBox();
            this.cbPlayerr = new System.Windows.Forms.CheckBox();
            this.cbPlayerrr = new System.Windows.Forms.CheckBox();
            this.cbPlayerrrr = new System.Windows.Forms.CheckBox();
            this.btnRosu = new System.Windows.Forms.Button();
            this.btnGalben = new System.Windows.Forms.Button();
            this.btnAlbastru = new System.Windows.Forms.Button();
            this.btnVerde = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(576, 255);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 33);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "EXIT";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.UseCompatibleTextRendering = true;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Location = new System.Drawing.Point(576, 182);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 33);
            this.btnAbout.TabIndex = 2;
            this.btnAbout.Text = "ABOUT";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // tbPlayer
            // 
            this.tbPlayer.Location = new System.Drawing.Point(201, 76);
            this.tbPlayer.Name = "tbPlayer";
            this.tbPlayer.Size = new System.Drawing.Size(100, 20);
            this.tbPlayer.TabIndex = 3;
            this.tbPlayer.Text = "Player 1";
            this.tbPlayer.TextChanged += new System.EventHandler(this.tbPlayer_TextChanged);
            // 
            // tbPlayerr
            // 
            this.tbPlayerr.Location = new System.Drawing.Point(201, 141);
            this.tbPlayerr.Name = "tbPlayerr";
            this.tbPlayerr.Size = new System.Drawing.Size(100, 20);
            this.tbPlayerr.TabIndex = 4;
            this.tbPlayerr.Text = "Player 2";
            this.tbPlayerr.TextChanged += new System.EventHandler(this.tbPlayerr_TextChanged);
            // 
            // tbPlayerrr
            // 
            this.tbPlayerrr.Location = new System.Drawing.Point(201, 201);
            this.tbPlayerrr.Name = "tbPlayerrr";
            this.tbPlayerrr.Size = new System.Drawing.Size(100, 20);
            this.tbPlayerrr.TabIndex = 5;
            this.tbPlayerrr.Text = "Player 3";
            this.tbPlayerrr.TextChanged += new System.EventHandler(this.tbPlayerrr_TextChanged);
            // 
            // tbPlayerrrr
            // 
            this.tbPlayerrrr.Location = new System.Drawing.Point(201, 260);
            this.tbPlayerrrr.Name = "tbPlayerrrr";
            this.tbPlayerrrr.Size = new System.Drawing.Size(100, 20);
            this.tbPlayerrrr.TabIndex = 6;
            this.tbPlayerrrr.Text = "Player 4";
            this.tbPlayerrrr.TextChanged += new System.EventHandler(this.tbPlayerrrr_TextChanged);
            // 
            // cbPlayer
            // 
            this.cbPlayer.AutoSize = true;
            this.cbPlayer.Location = new System.Drawing.Point(153, 79);
            this.cbPlayer.Name = "cbPlayer";
            this.cbPlayer.Size = new System.Drawing.Size(15, 14);
            this.cbPlayer.TabIndex = 7;
            this.cbPlayer.UseVisualStyleBackColor = true;
            this.cbPlayer.CheckedChanged += new System.EventHandler(this.cbPlayer_CheckedChanged);
            // 
            // cbPlayerr
            // 
            this.cbPlayerr.AutoSize = true;
            this.cbPlayerr.Location = new System.Drawing.Point(153, 141);
            this.cbPlayerr.Name = "cbPlayerr";
            this.cbPlayerr.Size = new System.Drawing.Size(15, 14);
            this.cbPlayerr.TabIndex = 8;
            this.cbPlayerr.UseVisualStyleBackColor = true;
            this.cbPlayerr.CheckedChanged += new System.EventHandler(this.cbPlayerr_CheckedChanged);
            // 
            // cbPlayerrr
            // 
            this.cbPlayerrr.AutoSize = true;
            this.cbPlayerrr.Location = new System.Drawing.Point(153, 201);
            this.cbPlayerrr.Name = "cbPlayerrr";
            this.cbPlayerrr.Size = new System.Drawing.Size(15, 14);
            this.cbPlayerrr.TabIndex = 9;
            this.cbPlayerrr.UseVisualStyleBackColor = true;
            this.cbPlayerrr.CheckedChanged += new System.EventHandler(this.cbPlayerrr_CheckedChanged);
            // 
            // cbPlayerrrr
            // 
            this.cbPlayerrrr.AutoSize = true;
            this.cbPlayerrrr.Location = new System.Drawing.Point(153, 263);
            this.cbPlayerrrr.Name = "cbPlayerrrr";
            this.cbPlayerrrr.Size = new System.Drawing.Size(15, 14);
            this.cbPlayerrrr.TabIndex = 10;
            this.cbPlayerrrr.UseVisualStyleBackColor = true;
            this.cbPlayerrrr.CheckedChanged += new System.EventHandler(this.cbPlayerrrr_CheckedChanged);
            // 
            // btnRosu
            // 
            this.btnRosu.Image = ((System.Drawing.Image)(resources.GetObject("btnRosu.Image")));
            this.btnRosu.Location = new System.Drawing.Point(339, 61);
            this.btnRosu.Name = "btnRosu";
            this.btnRosu.Size = new System.Drawing.Size(56, 48);
            this.btnRosu.TabIndex = 11;
            this.btnRosu.UseVisualStyleBackColor = true;
            // 
            // btnGalben
            // 
            this.btnGalben.Image = ((System.Drawing.Image)(resources.GetObject("btnGalben.Image")));
            this.btnGalben.Location = new System.Drawing.Point(339, 183);
            this.btnGalben.Name = "btnGalben";
            this.btnGalben.Size = new System.Drawing.Size(56, 48);
            this.btnGalben.TabIndex = 12;
            this.btnGalben.UseVisualStyleBackColor = true;
            // 
            // btnAlbastru
            // 
            this.btnAlbastru.Image = ((System.Drawing.Image)(resources.GetObject("btnAlbastru.Image")));
            this.btnAlbastru.Location = new System.Drawing.Point(339, 245);
            this.btnAlbastru.Name = "btnAlbastru";
            this.btnAlbastru.Size = new System.Drawing.Size(56, 48);
            this.btnAlbastru.TabIndex = 13;
            this.btnAlbastru.UseVisualStyleBackColor = true;
            // 
            // btnVerde
            // 
            this.btnVerde.Image = ((System.Drawing.Image)(resources.GetObject("btnVerde.Image")));
            this.btnVerde.Location = new System.Drawing.Point(339, 123);
            this.btnVerde.Name = "btnVerde";
            this.btnVerde.Size = new System.Drawing.Size(56, 48);
            this.btnVerde.TabIndex = 14;
            this.btnVerde.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStart.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnStart.Location = new System.Drawing.Point(576, 110);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 36);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // fLudo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVerde);
            this.Controls.Add(this.btnAlbastru);
            this.Controls.Add(this.btnGalben);
            this.Controls.Add(this.btnRosu);
            this.Controls.Add(this.cbPlayerrrr);
            this.Controls.Add(this.cbPlayerrr);
            this.Controls.Add(this.cbPlayerr);
            this.Controls.Add(this.cbPlayer);
            this.Controls.Add(this.tbPlayerrrr);
            this.Controls.Add(this.tbPlayerrr);
            this.Controls.Add(this.tbPlayerr);
            this.Controls.Add(this.tbPlayer);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Name = "fLudo";
            this.Text = "Ludo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.TextBox tbPlayer;
        private System.Windows.Forms.TextBox tbPlayerr;
        private System.Windows.Forms.TextBox tbPlayerrr;
        private System.Windows.Forms.TextBox tbPlayerrrr;
        private System.Windows.Forms.CheckBox cbPlayer;
        private System.Windows.Forms.CheckBox cbPlayerr;
        private System.Windows.Forms.CheckBox cbPlayerrr;
        private System.Windows.Forms.CheckBox cbPlayerrrr;
        private System.Windows.Forms.Button btnRosu;
        private System.Windows.Forms.Button btnGalben;
        private System.Windows.Forms.Button btnAlbastru;
        private System.Windows.Forms.Button btnVerde;
        private System.Windows.Forms.Button btnStart;
    }
}

