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
            this.roomBox1 = new System.Windows.Forms.GroupBox();
            this.roomBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.inventoryBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.combatBox1 = new System.Windows.Forms.GroupBox();
            this.moveNorthButton = new System.Windows.Forms.Button();
            this.moveWestButton = new System.Windows.Forms.Button();
            this.moveSouthButton = new System.Windows.Forms.Button();
            this.moveEastButton = new System.Windows.Forms.Button();
            this.scanButton = new System.Windows.Forms.Button();
            this.lookButton = new System.Windows.Forms.Button();
            this.combatButton = new System.Windows.Forms.Button();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.enviromentBox = new System.Windows.Forms.GroupBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.roomBox1.SuspendLayout();
            this.roomBox2.SuspendLayout();
            this.inventoryBox1.SuspendLayout();
            this.combatBox1.SuspendLayout();
            this.enviromentBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // roomBox1
            // 
            this.roomBox1.Controls.Add(this.lookButton);
            this.roomBox1.Controls.Add(this.scanButton);
            this.roomBox1.Controls.Add(this.moveEastButton);
            this.roomBox1.Controls.Add(this.moveSouthButton);
            this.roomBox1.Controls.Add(this.moveWestButton);
            this.roomBox1.Controls.Add(this.moveNorthButton);
            this.roomBox1.Location = new System.Drawing.Point(246, 12);
            this.roomBox1.Name = "roomBox1";
            this.roomBox1.Size = new System.Drawing.Size(256, 171);
            this.roomBox1.TabIndex = 0;
            this.roomBox1.TabStop = false;
            this.roomBox1.Text = "Room Control";
            // 
            // roomBox2
            // 
            this.roomBox2.Controls.Add(this.richTextBox1);
            this.roomBox2.Location = new System.Drawing.Point(509, 13);
            this.roomBox2.Name = "roomBox2";
            this.roomBox2.Size = new System.Drawing.Size(279, 170);
            this.roomBox2.TabIndex = 1;
            this.roomBox2.TabStop = false;
            this.roomBox2.Text = "Current Room";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(7, 20);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(266, 144);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // inventoryBox1
            // 
            this.inventoryBox1.Controls.Add(this.richTextBox2);
            this.inventoryBox1.Location = new System.Drawing.Point(12, 209);
            this.inventoryBox1.Name = "inventoryBox1";
            this.inventoryBox1.Size = new System.Drawing.Size(233, 305);
            this.inventoryBox1.TabIndex = 2;
            this.inventoryBox1.TabStop = false;
            this.inventoryBox1.Text = "Player Inventory";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(7, 20);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(220, 273);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // combatBox1
            // 
            this.combatBox1.Controls.Add(this.richTextBox3);
            this.combatBox1.Controls.Add(this.combatButton);
            this.combatBox1.Location = new System.Drawing.Point(252, 209);
            this.combatBox1.Name = "combatBox1";
            this.combatBox1.Size = new System.Drawing.Size(250, 305);
            this.combatBox1.TabIndex = 3;
            this.combatBox1.TabStop = false;
            this.combatBox1.Text = "Combat";
            // 
            // moveNorthButton
            // 
            this.moveNorthButton.Location = new System.Drawing.Point(87, 21);
            this.moveNorthButton.Name = "moveNorthButton";
            this.moveNorthButton.Size = new System.Drawing.Size(75, 23);
            this.moveNorthButton.TabIndex = 0;
            this.moveNorthButton.Text = "Go North";
            this.moveNorthButton.UseVisualStyleBackColor = true;
            // 
            // moveWestButton
            // 
            this.moveWestButton.Location = new System.Drawing.Point(6, 50);
            this.moveWestButton.Name = "moveWestButton";
            this.moveWestButton.Size = new System.Drawing.Size(75, 23);
            this.moveWestButton.TabIndex = 1;
            this.moveWestButton.Text = "Go West";
            this.moveWestButton.UseVisualStyleBackColor = true;
            // 
            // moveSouthButton
            // 
            this.moveSouthButton.Location = new System.Drawing.Point(87, 79);
            this.moveSouthButton.Name = "moveSouthButton";
            this.moveSouthButton.Size = new System.Drawing.Size(75, 23);
            this.moveSouthButton.TabIndex = 2;
            this.moveSouthButton.Text = "Go South";
            this.moveSouthButton.UseVisualStyleBackColor = true;
            // 
            // moveEastButton
            // 
            this.moveEastButton.Location = new System.Drawing.Point(168, 50);
            this.moveEastButton.Name = "moveEastButton";
            this.moveEastButton.Size = new System.Drawing.Size(75, 23);
            this.moveEastButton.TabIndex = 3;
            this.moveEastButton.Text = "Go East";
            this.moveEastButton.UseVisualStyleBackColor = true;
            // 
            // scanButton
            // 
            this.scanButton.Location = new System.Drawing.Point(7, 141);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(75, 23);
            this.scanButton.TabIndex = 4;
            this.scanButton.Text = "Scan";
            this.scanButton.UseVisualStyleBackColor = true;
            // 
            // lookButton
            // 
            this.lookButton.Location = new System.Drawing.Point(175, 141);
            this.lookButton.Name = "lookButton";
            this.lookButton.Size = new System.Drawing.Size(75, 23);
            this.lookButton.TabIndex = 5;
            this.lookButton.Text = "Look";
            this.lookButton.UseVisualStyleBackColor = true;
            // 
            // combatButton
            // 
            this.combatButton.Location = new System.Drawing.Point(81, 276);
            this.combatButton.Name = "combatButton";
            this.combatButton.Size = new System.Drawing.Size(75, 23);
            this.combatButton.TabIndex = 0;
            this.combatButton.Text = "Attack";
            this.combatButton.UseVisualStyleBackColor = true;
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(7, 20);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(237, 250);
            this.richTextBox3.TabIndex = 1;
            this.richTextBox3.Text = "";
            // 
            // enviromentBox
            // 
            this.enviromentBox.Controls.Add(this.richTextBox4);
            this.enviromentBox.Location = new System.Drawing.Point(516, 209);
            this.enviromentBox.Name = "enviromentBox";
            this.enviromentBox.Size = new System.Drawing.Size(272, 305);
            this.enviromentBox.TabIndex = 4;
            this.enviromentBox.TabStop = false;
            this.enviromentBox.Text = "Enviroment";
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(7, 20);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(259, 273);
            this.richTextBox4.TabIndex = 0;
            this.richTextBox4.Text = "";
            // 
            // AWayBackInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 526);
            this.Controls.Add(this.enviromentBox);
            this.Controls.Add(this.combatBox1);
            this.Controls.Add(this.inventoryBox1);
            this.Controls.Add(this.roomBox2);
            this.Controls.Add(this.roomBox1);
            this.Name = "AWayBackInterface";
            this.Text = "AWayBackInterface";
            this.roomBox1.ResumeLayout(false);
            this.roomBox2.ResumeLayout(false);
            this.inventoryBox1.ResumeLayout(false);
            this.combatBox1.ResumeLayout(false);
            this.enviromentBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox roomBox1;
        private System.Windows.Forms.GroupBox roomBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button lookButton;
        private System.Windows.Forms.Button scanButton;
        private System.Windows.Forms.Button moveEastButton;
        private System.Windows.Forms.Button moveSouthButton;
        private System.Windows.Forms.Button moveWestButton;
        private System.Windows.Forms.Button moveNorthButton;
        private System.Windows.Forms.GroupBox inventoryBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.GroupBox combatBox1;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Button combatButton;
        private System.Windows.Forms.GroupBox enviromentBox;
        private System.Windows.Forms.RichTextBox richTextBox4;
    }
}