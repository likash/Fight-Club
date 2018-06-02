namespace FightClub
{
    partial class MainForm
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
            this.EnterName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StartGamebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnterName
            // 
            this.EnterName.Location = new System.Drawing.Point(68, 95);
            this.EnterName.Name = "EnterName";
            this.EnterName.Size = new System.Drawing.Size(146, 20);
            this.EnterName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите имя";
            // 
            // StartGamebtn
            // 
            this.StartGamebtn.Location = new System.Drawing.Point(80, 147);
            this.StartGamebtn.Name = "StartGamebtn";
            this.StartGamebtn.Size = new System.Drawing.Size(133, 30);
            this.StartGamebtn.TabIndex = 2;
            this.StartGamebtn.Text = "Начать игру";
            this.StartGamebtn.UseVisualStyleBackColor = true;
            this.StartGamebtn.Click += new System.EventHandler(this.StartGamebtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 198);
            this.Controls.Add(this.StartGamebtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnterName);
            this.Name = "MainForm";
            this.Text = "Fight Club";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EnterName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartGamebtn;
    }
}

