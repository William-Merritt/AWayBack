using GameWorld;
namespace AWayBackWinForm
{
    partial class CreatePlayer
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPlayerClass = new System.Windows.Forms.Label();
            this.lblPlayerRace = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(13, 13);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(35, 13);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = StandardMessages.GetFirstName();
            // 
            // lblPlayerClass
            // 
            this.lblPlayerClass.AutoSize = true;
            this.lblPlayerClass.Location = new System.Drawing.Point(13, 41);
            this.lblPlayerClass.Name = "lblPlayerClass";
            this.lblPlayerClass.Size = new System.Drawing.Size(35, 13);
            this.lblPlayerClass.TabIndex = 1;
            this.lblPlayerClass.Text = StandardMessages.GetPlayerClass();
            // 
            // lblPlayerRace
            // 
            this.lblPlayerRace.AutoSize = true;
            this.lblPlayerRace.Location = new System.Drawing.Point(13, 69);
            this.lblPlayerRace.Name = "lblPlayerRace";
            this.lblPlayerRace.Size = new System.Drawing.Size(35, 13);
            this.lblPlayerRace.TabIndex = 2;
            this.lblPlayerRace.Text = StandardMessages.GetPlayerRace();
            // 
            // CreatePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPlayerRace);
            this.Controls.Add(this.lblPlayerClass);
            this.Controls.Add(this.lblUserName);
            this.Name = "CreatePlayer";
            this.Text = "CreatePlayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPlayerClass;
        private System.Windows.Forms.Label lblPlayerRace;
    }
}