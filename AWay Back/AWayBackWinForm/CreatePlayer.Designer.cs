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
            this.grpBoxUsernamePassword = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.grpBoxRace = new System.Windows.Forms.GroupBox();
            this.radioBtnElf = new System.Windows.Forms.RadioButton();
            this.radioBtnDracokin = new System.Windows.Forms.RadioButton();
            this.radioBtnDwarf = new System.Windows.Forms.RadioButton();
            this.radioBtnHuman = new System.Windows.Forms.RadioButton();
            this.grpBoxClass = new System.Windows.Forms.GroupBox();
            this.radioBtnSpecialist = new System.Windows.Forms.RadioButton();
            this.radioBtnTrapper = new System.Windows.Forms.RadioButton();
            this.radioBtnSwordsman = new System.Windows.Forms.RadioButton();
            this.radioBtnMarksman = new System.Windows.Forms.RadioButton();
            this.grpPasswordRequirements = new System.Windows.Forms.GroupBox();
            this.lblPasswordRequirements = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.grpBoxUsernamePassword.SuspendLayout();
            this.grpBoxRace.SuspendLayout();
            this.grpBoxClass.SuspendLayout();
            this.grpPasswordRequirements.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.59F);
            this.lblUserName.Location = new System.Drawing.Point(6, 16);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(226, 15);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "What is the username for your character:";
            // 
            // lblPlayerClass
            // 
            this.lblPlayerClass.AutoSize = true;
            this.lblPlayerClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.59F);
            this.lblPlayerClass.Location = new System.Drawing.Point(6, 16);
            this.lblPlayerClass.Name = "lblPlayerClass";
            this.lblPlayerClass.Size = new System.Drawing.Size(194, 15);
            this.lblPlayerClass.TabIndex = 1;
            this.lblPlayerClass.Text = "What is the class of your character:";
            // 
            // lblPlayerRace
            // 
            this.lblPlayerRace.AutoSize = true;
            this.lblPlayerRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.59F);
            this.lblPlayerRace.Location = new System.Drawing.Point(6, 16);
            this.lblPlayerRace.Name = "lblPlayerRace";
            this.lblPlayerRace.Size = new System.Drawing.Size(190, 15);
            this.lblPlayerRace.TabIndex = 2;
            this.lblPlayerRace.Text = "What is the race of your character:";
            // 
            // grpBoxUsernamePassword
            // 
            this.grpBoxUsernamePassword.Controls.Add(this.textBox1);
            this.grpBoxUsernamePassword.Controls.Add(this.lblPassword);
            this.grpBoxUsernamePassword.Controls.Add(this.txtBoxUsername);
            this.grpBoxUsernamePassword.Controls.Add(this.lblUserName);
            this.grpBoxUsernamePassword.Location = new System.Drawing.Point(12, 13);
            this.grpBoxUsernamePassword.Name = "grpBoxUsernamePassword";
            this.grpBoxUsernamePassword.Size = new System.Drawing.Size(244, 196);
            this.grpBoxUsernamePassword.TabIndex = 3;
            this.grpBoxUsernamePassword.TabStop = false;
            this.grpBoxUsernamePassword.Text = "Username/Password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 20);
            this.textBox1.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(9, 110);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(200, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Please create a password for this player: ";
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.Location = new System.Drawing.Point(9, 54);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(223, 20);
            this.txtBoxUsername.TabIndex = 1;
            // 
            // grpBoxRace
            // 
            this.grpBoxRace.Controls.Add(this.radioBtnElf);
            this.grpBoxRace.Controls.Add(this.radioBtnDracokin);
            this.grpBoxRace.Controls.Add(this.radioBtnDwarf);
            this.grpBoxRace.Controls.Add(this.radioBtnHuman);
            this.grpBoxRace.Controls.Add(this.lblPlayerRace);
            this.grpBoxRace.Location = new System.Drawing.Point(272, 13);
            this.grpBoxRace.Name = "grpBoxRace";
            this.grpBoxRace.Size = new System.Drawing.Size(258, 196);
            this.grpBoxRace.TabIndex = 4;
            this.grpBoxRace.TabStop = false;
            this.grpBoxRace.Text = "Race";
            // 
            // radioBtnElf
            // 
            this.radioBtnElf.AutoSize = true;
            this.radioBtnElf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.59F);
            this.radioBtnElf.Location = new System.Drawing.Point(9, 154);
            this.radioBtnElf.Name = "radioBtnElf";
            this.radioBtnElf.Size = new System.Drawing.Size(39, 19);
            this.radioBtnElf.TabIndex = 6;
            this.radioBtnElf.TabStop = true;
            this.radioBtnElf.Text = "Elf";
            this.radioBtnElf.UseVisualStyleBackColor = true;
            // 
            // radioBtnDracokin
            // 
            this.radioBtnDracokin.AutoSize = true;
            this.radioBtnDracokin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.59F);
            this.radioBtnDracokin.Location = new System.Drawing.Point(9, 110);
            this.radioBtnDracokin.Name = "radioBtnDracokin";
            this.radioBtnDracokin.Size = new System.Drawing.Size(74, 19);
            this.radioBtnDracokin.TabIndex = 5;
            this.radioBtnDracokin.TabStop = true;
            this.radioBtnDracokin.Text = "Dracokin";
            this.radioBtnDracokin.UseVisualStyleBackColor = true;
            // 
            // radioBtnDwarf
            // 
            this.radioBtnDwarf.AutoSize = true;
            this.radioBtnDwarf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.59F);
            this.radioBtnDwarf.Location = new System.Drawing.Point(9, 70);
            this.radioBtnDwarf.Name = "radioBtnDwarf";
            this.radioBtnDwarf.Size = new System.Drawing.Size(57, 19);
            this.radioBtnDwarf.TabIndex = 4;
            this.radioBtnDwarf.TabStop = true;
            this.radioBtnDwarf.Text = "Dwarf";
            this.radioBtnDwarf.UseVisualStyleBackColor = true;
            // 
            // radioBtnHuman
            // 
            this.radioBtnHuman.AutoSize = true;
            this.radioBtnHuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.59F);
            this.radioBtnHuman.Location = new System.Drawing.Point(9, 35);
            this.radioBtnHuman.Name = "radioBtnHuman";
            this.radioBtnHuman.Size = new System.Drawing.Size(66, 19);
            this.radioBtnHuman.TabIndex = 3;
            this.radioBtnHuman.TabStop = true;
            this.radioBtnHuman.Text = "Human";
            this.radioBtnHuman.UseVisualStyleBackColor = true;
            // 
            // grpBoxClass
            // 
            this.grpBoxClass.Controls.Add(this.radioBtnSpecialist);
            this.grpBoxClass.Controls.Add(this.radioBtnTrapper);
            this.grpBoxClass.Controls.Add(this.radioBtnSwordsman);
            this.grpBoxClass.Controls.Add(this.radioBtnMarksman);
            this.grpBoxClass.Controls.Add(this.lblPlayerClass);
            this.grpBoxClass.Location = new System.Drawing.Point(536, 13);
            this.grpBoxClass.Name = "grpBoxClass";
            this.grpBoxClass.Size = new System.Drawing.Size(252, 196);
            this.grpBoxClass.TabIndex = 5;
            this.grpBoxClass.TabStop = false;
            this.grpBoxClass.Text = "Class";
            // 
            // radioBtnSpecialist
            // 
            this.radioBtnSpecialist.AutoSize = true;
            this.radioBtnSpecialist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.59F);
            this.radioBtnSpecialist.Location = new System.Drawing.Point(9, 154);
            this.radioBtnSpecialist.Name = "radioBtnSpecialist";
            this.radioBtnSpecialist.Size = new System.Drawing.Size(78, 19);
            this.radioBtnSpecialist.TabIndex = 5;
            this.radioBtnSpecialist.TabStop = true;
            this.radioBtnSpecialist.Text = "Specialist";
            this.radioBtnSpecialist.UseVisualStyleBackColor = true;
            // 
            // radioBtnTrapper
            // 
            this.radioBtnTrapper.AutoSize = true;
            this.radioBtnTrapper.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.59F);
            this.radioBtnTrapper.Location = new System.Drawing.Point(9, 110);
            this.radioBtnTrapper.Name = "radioBtnTrapper";
            this.radioBtnTrapper.Size = new System.Drawing.Size(68, 19);
            this.radioBtnTrapper.TabIndex = 4;
            this.radioBtnTrapper.TabStop = true;
            this.radioBtnTrapper.Text = "Trapper";
            this.radioBtnTrapper.UseVisualStyleBackColor = true;
            // 
            // radioBtnSwordsman
            // 
            this.radioBtnSwordsman.AutoSize = true;
            this.radioBtnSwordsman.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.59F);
            this.radioBtnSwordsman.Location = new System.Drawing.Point(9, 70);
            this.radioBtnSwordsman.Name = "radioBtnSwordsman";
            this.radioBtnSwordsman.Size = new System.Drawing.Size(91, 19);
            this.radioBtnSwordsman.TabIndex = 3;
            this.radioBtnSwordsman.TabStop = true;
            this.radioBtnSwordsman.Text = "Swordsman";
            this.radioBtnSwordsman.UseVisualStyleBackColor = true;
            // 
            // radioBtnMarksman
            // 
            this.radioBtnMarksman.AutoSize = true;
            this.radioBtnMarksman.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.59F);
            this.radioBtnMarksman.Location = new System.Drawing.Point(9, 35);
            this.radioBtnMarksman.Name = "radioBtnMarksman";
            this.radioBtnMarksman.Size = new System.Drawing.Size(84, 19);
            this.radioBtnMarksman.TabIndex = 2;
            this.radioBtnMarksman.TabStop = true;
            this.radioBtnMarksman.Text = "Marksman";
            this.radioBtnMarksman.UseVisualStyleBackColor = true;
            // 
            // grpPasswordRequirements
            // 
            this.grpPasswordRequirements.Controls.Add(this.lblPasswordRequirements);
            this.grpPasswordRequirements.Location = new System.Drawing.Point(12, 232);
            this.grpPasswordRequirements.Name = "grpPasswordRequirements";
            this.grpPasswordRequirements.Size = new System.Drawing.Size(405, 100);
            this.grpPasswordRequirements.TabIndex = 6;
            this.grpPasswordRequirements.TabStop = false;
            this.grpPasswordRequirements.Text = "Passwords Requirements";
            // 
            // lblPasswordRequirements
            // 
            this.lblPasswordRequirements.AutoSize = true;
            this.lblPasswordRequirements.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.59F);
            this.lblPasswordRequirements.Location = new System.Drawing.Point(9, 20);
            this.lblPasswordRequirements.Name = "lblPasswordRequirements";
            this.lblPasswordRequirements.Size = new System.Drawing.Size(386, 60);
            this.lblPasswordRequirements.TabIndex = 0;
            this.lblPasswordRequirements.Text = "Password Requirements: Length must be between 8 to 15 characters.\r\nMust Contain a" +
    "t least one Capital Letter\r\nMust Contain at least one Lowercase Letter\r\nMust Con" +
    "tain at least one Punctuation Mark";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSubmit.Location = new System.Drawing.Point(445, 245);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(343, 76);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Create Player";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // CreatePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 377);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.grpPasswordRequirements);
            this.Controls.Add(this.grpBoxClass);
            this.Controls.Add(this.grpBoxRace);
            this.Controls.Add(this.grpBoxUsernamePassword);
            this.Name = "CreatePlayer";
            this.Text = "CreatePlayer";
            this.Load += new System.EventHandler(this.CreatePlayer_Load);
            this.grpBoxUsernamePassword.ResumeLayout(false);
            this.grpBoxUsernamePassword.PerformLayout();
            this.grpBoxRace.ResumeLayout(false);
            this.grpBoxRace.PerformLayout();
            this.grpBoxClass.ResumeLayout(false);
            this.grpBoxClass.PerformLayout();
            this.grpPasswordRequirements.ResumeLayout(false);
            this.grpPasswordRequirements.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPlayerClass;
        private System.Windows.Forms.Label lblPlayerRace;
        private System.Windows.Forms.GroupBox grpBoxUsernamePassword;
        private System.Windows.Forms.GroupBox grpBoxRace;
        private System.Windows.Forms.GroupBox grpBoxClass;
        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.RadioButton radioBtnElf;
        private System.Windows.Forms.RadioButton radioBtnDracokin;
        private System.Windows.Forms.RadioButton radioBtnDwarf;
        private System.Windows.Forms.RadioButton radioBtnHuman;
        private System.Windows.Forms.RadioButton radioBtnSpecialist;
        private System.Windows.Forms.RadioButton radioBtnTrapper;
        private System.Windows.Forms.RadioButton radioBtnSwordsman;
        private System.Windows.Forms.RadioButton radioBtnMarksman;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.GroupBox grpPasswordRequirements;
        private System.Windows.Forms.Label lblPasswordRequirements;
        private System.Windows.Forms.Button btnSubmit;
    }
}