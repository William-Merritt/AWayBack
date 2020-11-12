namespace AWayBackWinForm
{
    partial class AWayBackInterface
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
            this.playerControlsGroupBox = new System.Windows.Forms.GroupBox();
            this.lookButton = new System.Windows.Forms.Button();
            this.moveEastButton = new System.Windows.Forms.Button();
            this.moveSouthButton = new System.Windows.Forms.Button();
            this.moveWestButton = new System.Windows.Forms.Button();
            this.moveNorthButton = new System.Windows.Forms.Button();
            this.currentRoomGroupBox = new System.Windows.Forms.GroupBox();
            this.roomDescRichTextBox = new System.Windows.Forms.RichTextBox();
            this.inventoryGroupBox = new System.Windows.Forms.GroupBox();
            this.inventoryRichTextBox = new System.Windows.Forms.RichTextBox();
            this.combatGroupBox = new System.Windows.Forms.GroupBox();
            this.combatRichTextBox = new System.Windows.Forms.RichTextBox();
            this.combatButton = new System.Windows.Forms.Button();
            this.enviromentGroupBox = new System.Windows.Forms.GroupBox();
            this.enviromentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.btnCheckInventory = new System.Windows.Forms.Button();
            this.playerControlsGroupBox.SuspendLayout();
            this.currentRoomGroupBox.SuspendLayout();
            this.inventoryGroupBox.SuspendLayout();
            this.combatGroupBox.SuspendLayout();
            this.enviromentGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // playerControlsGroupBox
            // 
            this.playerControlsGroupBox.Controls.Add(this.lookButton);
            this.playerControlsGroupBox.Controls.Add(this.moveEastButton);
            this.playerControlsGroupBox.Controls.Add(this.moveSouthButton);
            this.playerControlsGroupBox.Controls.Add(this.moveWestButton);
            this.playerControlsGroupBox.Controls.Add(this.moveNorthButton);
            this.playerControlsGroupBox.Location = new System.Drawing.Point(246, 12);
            this.playerControlsGroupBox.Name = "playerControlsGroupBox";
            this.playerControlsGroupBox.Size = new System.Drawing.Size(256, 171);
            this.playerControlsGroupBox.TabIndex = 0;
            this.playerControlsGroupBox.TabStop = false;
            this.playerControlsGroupBox.Text = "Room Control";
            // 
            // lookButton
            // 
            this.lookButton.Location = new System.Drawing.Point(6, 141);
            this.lookButton.Name = "lookButton";
            this.lookButton.Size = new System.Drawing.Size(244, 23);
            this.lookButton.TabIndex = 5;
            this.lookButton.Text = "Look";
            this.lookButton.UseVisualStyleBackColor = true;
            this.lookButton.Click += new System.EventHandler(this.lookButton_Click);
            // 
            // moveEastButton
            // 
            this.moveEastButton.Location = new System.Drawing.Point(168, 50);
            this.moveEastButton.Name = "moveEastButton";
            this.moveEastButton.Size = new System.Drawing.Size(75, 23);
            this.moveEastButton.TabIndex = 3;
            this.moveEastButton.Text = "Go East";
            this.moveEastButton.UseVisualStyleBackColor = true;
            this.moveEastButton.Click += new System.EventHandler(this.moveEastButton_Click);
            // 
            // moveSouthButton
            // 
            this.moveSouthButton.Location = new System.Drawing.Point(87, 79);
            this.moveSouthButton.Name = "moveSouthButton";
            this.moveSouthButton.Size = new System.Drawing.Size(75, 23);
            this.moveSouthButton.TabIndex = 2;
            this.moveSouthButton.Text = "Go South";
            this.moveSouthButton.UseVisualStyleBackColor = true;
            this.moveSouthButton.Click += new System.EventHandler(this.moveSouthButton_Click);
            // 
            // moveWestButton
            // 
            this.moveWestButton.Location = new System.Drawing.Point(6, 50);
            this.moveWestButton.Name = "moveWestButton";
            this.moveWestButton.Size = new System.Drawing.Size(75, 23);
            this.moveWestButton.TabIndex = 1;
            this.moveWestButton.Text = "Go West";
            this.moveWestButton.UseVisualStyleBackColor = true;
            this.moveWestButton.Click += new System.EventHandler(this.moveWestButton_Click);
            // 
            // moveNorthButton
            // 
            this.moveNorthButton.Location = new System.Drawing.Point(87, 21);
            this.moveNorthButton.Name = "moveNorthButton";
            this.moveNorthButton.Size = new System.Drawing.Size(75, 23);
            this.moveNorthButton.TabIndex = 0;
            this.moveNorthButton.Text = "Go North";
            this.moveNorthButton.UseVisualStyleBackColor = true;
            this.moveNorthButton.Click += new System.EventHandler(this.moveNorthButton_Click);
            // 
            // currentRoomGroupBox
            // 
            this.currentRoomGroupBox.Controls.Add(this.roomDescRichTextBox);
            this.currentRoomGroupBox.Location = new System.Drawing.Point(509, 13);
            this.currentRoomGroupBox.Name = "currentRoomGroupBox";
            this.currentRoomGroupBox.Size = new System.Drawing.Size(279, 170);
            this.currentRoomGroupBox.TabIndex = 1;
            this.currentRoomGroupBox.TabStop = false;
            this.currentRoomGroupBox.Text = "Current Room";
            // 
            // roomDescRichTextBox
            // 
            this.roomDescRichTextBox.Location = new System.Drawing.Point(7, 20);
            this.roomDescRichTextBox.Name = "roomDescRichTextBox";
            this.roomDescRichTextBox.Size = new System.Drawing.Size(266, 144);
            this.roomDescRichTextBox.TabIndex = 0;
            this.roomDescRichTextBox.Text = "";
            // 
            // inventoryGroupBox
            // 
            this.inventoryGroupBox.Controls.Add(this.btnCheckInventory);
            this.inventoryGroupBox.Controls.Add(this.inventoryRichTextBox);
            this.inventoryGroupBox.Location = new System.Drawing.Point(12, 209);
            this.inventoryGroupBox.Name = "inventoryGroupBox";
            this.inventoryGroupBox.Size = new System.Drawing.Size(233, 305);
            this.inventoryGroupBox.TabIndex = 2;
            this.inventoryGroupBox.TabStop = false;
            this.inventoryGroupBox.Text = "Player Inventory";
            // 
            // inventoryRichTextBox
            // 
            this.inventoryRichTextBox.Location = new System.Drawing.Point(7, 20);
            this.inventoryRichTextBox.Name = "inventoryRichTextBox";
            this.inventoryRichTextBox.Size = new System.Drawing.Size(220, 250);
            this.inventoryRichTextBox.TabIndex = 0;
            this.inventoryRichTextBox.Text = "";
            // 
            // combatGroupBox
            // 
            this.combatGroupBox.Controls.Add(this.combatRichTextBox);
            this.combatGroupBox.Controls.Add(this.combatButton);
            this.combatGroupBox.Location = new System.Drawing.Point(252, 209);
            this.combatGroupBox.Name = "combatGroupBox";
            this.combatGroupBox.Size = new System.Drawing.Size(250, 305);
            this.combatGroupBox.TabIndex = 3;
            this.combatGroupBox.TabStop = false;
            this.combatGroupBox.Text = "Combat";
            // 
            // combatRichTextBox
            // 
            this.combatRichTextBox.Location = new System.Drawing.Point(7, 20);
            this.combatRichTextBox.Name = "combatRichTextBox";
            this.combatRichTextBox.Size = new System.Drawing.Size(237, 250);
            this.combatRichTextBox.TabIndex = 1;
            this.combatRichTextBox.Text = "";
            // 
            // combatButton
            // 
            this.combatButton.Location = new System.Drawing.Point(81, 276);
            this.combatButton.Name = "combatButton";
            this.combatButton.Size = new System.Drawing.Size(75, 23);
            this.combatButton.TabIndex = 0;
            this.combatButton.Text = "Attack";
            this.combatButton.UseVisualStyleBackColor = true;
            this.combatButton.Click += new System.EventHandler(this.combatButton_Click);
            // 
            // enviromentGroupBox
            // 
            this.enviromentGroupBox.Controls.Add(this.enviromentRichTextBox);
            this.enviromentGroupBox.Location = new System.Drawing.Point(516, 209);
            this.enviromentGroupBox.Name = "enviromentGroupBox";
            this.enviromentGroupBox.Size = new System.Drawing.Size(272, 305);
            this.enviromentGroupBox.TabIndex = 4;
            this.enviromentGroupBox.TabStop = false;
            this.enviromentGroupBox.Text = "Enviroment";
            // 
            // enviromentRichTextBox
            // 
            this.enviromentRichTextBox.Location = new System.Drawing.Point(7, 20);
            this.enviromentRichTextBox.Name = "enviromentRichTextBox";
            this.enviromentRichTextBox.Size = new System.Drawing.Size(259, 273);
            this.enviromentRichTextBox.TabIndex = 0;
            this.enviromentRichTextBox.Text = "";
            // 
            // btnCheckInventory
            // 
            this.btnCheckInventory.Location = new System.Drawing.Point(79, 276);
            this.btnCheckInventory.Name = "btnCheckInventory";
            this.btnCheckInventory.Size = new System.Drawing.Size(75, 23);
            this.btnCheckInventory.TabIndex = 1;
            this.btnCheckInventory.Text = "Check";
            this.btnCheckInventory.UseVisualStyleBackColor = true;
            this.btnCheckInventory.Click += new System.EventHandler(this.btnCheckInventory_Click);
            // 
            // AWayBackInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 526);
            this.Controls.Add(this.enviromentGroupBox);
            this.Controls.Add(this.combatGroupBox);
            this.Controls.Add(this.inventoryGroupBox);
            this.Controls.Add(this.currentRoomGroupBox);
            this.Controls.Add(this.playerControlsGroupBox);
            this.Name = "AWayBackInterface";
            this.Text = "AWayBackInterface";
            this.playerControlsGroupBox.ResumeLayout(false);
            this.currentRoomGroupBox.ResumeLayout(false);
            this.inventoryGroupBox.ResumeLayout(false);
            this.combatGroupBox.ResumeLayout(false);
            this.enviromentGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox playerControlsGroupBox;
        private System.Windows.Forms.GroupBox currentRoomGroupBox;
        private System.Windows.Forms.RichTextBox roomDescRichTextBox;
        private System.Windows.Forms.Button lookButton;
        private System.Windows.Forms.Button moveEastButton;
        private System.Windows.Forms.Button moveSouthButton;
        private System.Windows.Forms.Button moveWestButton;
        private System.Windows.Forms.Button moveNorthButton;
        private System.Windows.Forms.GroupBox inventoryGroupBox;
        private System.Windows.Forms.RichTextBox inventoryRichTextBox;
        private System.Windows.Forms.GroupBox combatGroupBox;
        private System.Windows.Forms.RichTextBox combatRichTextBox;
        private System.Windows.Forms.Button combatButton;
        private System.Windows.Forms.GroupBox enviromentGroupBox;
        private System.Windows.Forms.RichTextBox enviromentRichTextBox;
        private System.Windows.Forms.Button btnCheckInventory;
    }
}