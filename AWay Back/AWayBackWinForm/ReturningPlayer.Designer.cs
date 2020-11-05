namespace AWayBackWinForm
{
    partial class ReturningPlayer
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
            this.lblReturningPlayer = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblReturningPlayer
            // 
            this.lblReturningPlayer.AutoSize = true;
            this.lblReturningPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblReturningPlayer.Location = new System.Drawing.Point(92, 54);
            this.lblReturningPlayer.Name = "lblReturningPlayer";
            this.lblReturningPlayer.Size = new System.Drawing.Size(246, 25);
            this.lblReturningPlayer.TabIndex = 0;
            this.lblReturningPlayer.Text = "Are you a returning player?";
            // 
            // btnYes
            // 
            this.btnYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.59F);
            this.btnYes.Location = new System.Drawing.Point(46, 115);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(108, 36);
            this.btnYes.TabIndex = 1;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.59F);
            this.btnNo.Location = new System.Drawing.Point(280, 115);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(108, 36);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // ReturningPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 177);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblReturningPlayer);
            this.Name = "ReturningPlayer";
            this.Text = "ReturningPlayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReturningPlayer;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
    }
}