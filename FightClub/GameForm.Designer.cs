namespace FightClub
{
    partial class GameForm
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
            this.EnemySkin = new System.Windows.Forms.PictureBox();
            this.PlayerSkin = new System.Windows.Forms.PictureBox();
            this.RoundNumber = new System.Windows.Forms.Label();
            this.ThePlayerOnMove = new System.Windows.Forms.Label();
            this.EnemyLife = new System.Windows.Forms.ProgressBar();
            this.PlayerLife = new System.Windows.Forms.ProgressBar();
            this.LegsHitBtn = new System.Windows.Forms.Button();
            this.BodyHitBtn = new System.Windows.Forms.Button();
            this.HeadHitBtn = new System.Windows.Forms.Button();
            this.LegsBlockBtn = new System.Windows.Forms.Button();
            this.BodyBlockBtn = new System.Windows.Forms.Button();
            this.HeadBlockBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EnemySkin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerSkin)).BeginInit();
            this.SuspendLayout();
            // 
            // EnemySkin
            // 
            this.EnemySkin.Location = new System.Drawing.Point(549, 62);
            this.EnemySkin.Name = "EnemySkin";
            this.EnemySkin.Size = new System.Drawing.Size(127, 129);
            this.EnemySkin.TabIndex = 18;
            this.EnemySkin.TabStop = false;
            // 
            // PlayerSkin
            // 
            this.PlayerSkin.Location = new System.Drawing.Point(57, 61);
            this.PlayerSkin.Name = "PlayerSkin";
            this.PlayerSkin.Size = new System.Drawing.Size(127, 129);
            this.PlayerSkin.TabIndex = 17;
            this.PlayerSkin.TabStop = false;
            // 
            // RoundNumber
            // 
            this.RoundNumber.AutoSize = true;
            this.RoundNumber.Location = new System.Drawing.Point(40, 237);
            this.RoundNumber.Name = "RoundNumber";
            this.RoundNumber.Size = new System.Drawing.Size(49, 13);
            this.RoundNumber.TabIndex = 16;
            this.RoundNumber.Text = "Раунд: 1";
            // 
            // ThePlayerOnMove
            // 
            this.ThePlayerOnMove.AutoSize = true;
            this.ThePlayerOnMove.Location = new System.Drawing.Point(223, 32);
            this.ThePlayerOnMove.Name = "ThePlayerOnMove";
            this.ThePlayerOnMove.Size = new System.Drawing.Size(55, 13);
            this.ThePlayerOnMove.TabIndex = 15;
            this.ThePlayerOnMove.Text = "Твой ход!";
            // 
            // EnemyLife
            // 
            this.EnemyLife.Location = new System.Drawing.Point(682, 56);
            this.EnemyLife.Name = "EnemyLife";
            this.EnemyLife.Size = new System.Drawing.Size(26, 139);
            this.EnemyLife.TabIndex = 14;
            // 
            // PlayerLife
            // 
            this.PlayerLife.Location = new System.Drawing.Point(15, 55);
            this.PlayerLife.Name = "PlayerLife";
            this.PlayerLife.Size = new System.Drawing.Size(26, 139);
            this.PlayerLife.TabIndex = 13;
            // 
            // LegsHitBtn
            // 
            this.LegsHitBtn.Location = new System.Drawing.Point(226, 158);
            this.LegsHitBtn.Name = "LegsHitBtn";
            this.LegsHitBtn.Size = new System.Drawing.Size(131, 33);
            this.LegsHitBtn.TabIndex = 12;
            this.LegsHitBtn.Text = "Attack Legs";
            this.LegsHitBtn.UseVisualStyleBackColor = true;
            // 
            // BodyHitBtn
            // 
            this.BodyHitBtn.Location = new System.Drawing.Point(226, 119);
            this.BodyHitBtn.Name = "BodyHitBtn";
            this.BodyHitBtn.Size = new System.Drawing.Size(131, 33);
            this.BodyHitBtn.TabIndex = 11;
            this.BodyHitBtn.Text = "Attack Body";
            this.BodyHitBtn.UseVisualStyleBackColor = true;
            // 
            // HeadHitBtn
            // 
            this.HeadHitBtn.Location = new System.Drawing.Point(226, 80);
            this.HeadHitBtn.Name = "HeadHitBtn";
            this.HeadHitBtn.Size = new System.Drawing.Size(131, 33);
            this.HeadHitBtn.TabIndex = 10;
            this.HeadHitBtn.Text = "Attack Head";
            this.HeadHitBtn.UseVisualStyleBackColor = true;
            this.HeadHitBtn.Click += new System.EventHandler(this.HeadHitBtn_Click);
            // 
            // LegsBlockBtn
            // 
            this.LegsBlockBtn.Location = new System.Drawing.Point(363, 157);
            this.LegsBlockBtn.Name = "LegsBlockBtn";
            this.LegsBlockBtn.Size = new System.Drawing.Size(131, 33);
            this.LegsBlockBtn.TabIndex = 21;
            this.LegsBlockBtn.Text = "Block Legs";
            this.LegsBlockBtn.UseVisualStyleBackColor = true;
            // 
            // BodyBlockBtn
            // 
            this.BodyBlockBtn.Location = new System.Drawing.Point(363, 118);
            this.BodyBlockBtn.Name = "BodyBlockBtn";
            this.BodyBlockBtn.Size = new System.Drawing.Size(131, 33);
            this.BodyBlockBtn.TabIndex = 20;
            this.BodyBlockBtn.Text = "Block Body";
            this.BodyBlockBtn.UseVisualStyleBackColor = true;
            // 
            // HeadBlockBtn
            // 
            this.HeadBlockBtn.Location = new System.Drawing.Point(363, 79);
            this.HeadBlockBtn.Name = "HeadBlockBtn";
            this.HeadBlockBtn.Size = new System.Drawing.Size(131, 33);
            this.HeadBlockBtn.TabIndex = 19;
            this.HeadBlockBtn.Text = "Block Head";
            this.HeadBlockBtn.UseVisualStyleBackColor = true;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 293);
            this.Controls.Add(this.LegsBlockBtn);
            this.Controls.Add(this.BodyBlockBtn);
            this.Controls.Add(this.HeadBlockBtn);
            this.Controls.Add(this.EnemySkin);
            this.Controls.Add(this.PlayerSkin);
            this.Controls.Add(this.RoundNumber);
            this.Controls.Add(this.ThePlayerOnMove);
            this.Controls.Add(this.EnemyLife);
            this.Controls.Add(this.PlayerLife);
            this.Controls.Add(this.LegsHitBtn);
            this.Controls.Add(this.BodyHitBtn);
            this.Controls.Add(this.HeadHitBtn);
            this.Name = "GameForm";
            this.Text = "GameForm";
            ((System.ComponentModel.ISupportInitialize)(this.EnemySkin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerSkin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox EnemySkin;
        private System.Windows.Forms.PictureBox PlayerSkin;
        private System.Windows.Forms.Label RoundNumber;
        private System.Windows.Forms.Label ThePlayerOnMove;
        private System.Windows.Forms.ProgressBar EnemyLife;
        private System.Windows.Forms.ProgressBar PlayerLife;
        private System.Windows.Forms.Button LegsHitBtn;
        private System.Windows.Forms.Button BodyHitBtn;
        private System.Windows.Forms.Button HeadHitBtn;
        private System.Windows.Forms.Button LegsBlockBtn;
        private System.Windows.Forms.Button BodyBlockBtn;
        private System.Windows.Forms.Button HeadBlockBtn;
    }
}