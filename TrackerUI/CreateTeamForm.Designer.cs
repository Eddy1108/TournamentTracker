namespace TrackerUI
{
    partial class CreateTeamForm
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
            tournamentNameValue = new TextBox();
            teamNameLabel = new Label();
            createTeamLabel = new Label();
            addTeamMemberButton = new Button();
            selectTeamMemberDropDown = new ComboBox();
            selectTeamMemberLabel = new Label();
            groupBox1 = new GroupBox();
            firstNameValue = new TextBox();
            firstNameLabel = new Label();
            lastNameValue = new TextBox();
            lastNameLabel = new Label();
            emailValue = new TextBox();
            emailLabel = new Label();
            cellphoneValue = new TextBox();
            cellphoneLabel = new Label();
            createMemberButton = new Button();
            teamMembersListBox = new ListBox();
            DeleteSelectedMemberButton = new Button();
            createTeamButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tournamentNameValue
            // 
            tournamentNameValue.Location = new Point(36, 145);
            tournamentNameValue.Name = "tournamentNameValue";
            tournamentNameValue.Size = new Size(426, 36);
            tournamentNameValue.TabIndex = 14;
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            teamNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            teamNameLabel.Location = new Point(36, 105);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(151, 37);
            teamNameLabel.TabIndex = 13;
            teamNameLabel.Text = "Team Name";
            // 
            // createTeamLabel
            // 
            createTeamLabel.AutoSize = true;
            createTeamLabel.Font = new Font("Segoe UI Light", 28F, FontStyle.Regular, GraphicsUnit.Point);
            createTeamLabel.ForeColor = Color.FromArgb(51, 153, 255);
            createTeamLabel.Location = new Point(36, 29);
            createTeamLabel.Name = "createTeamLabel";
            createTeamLabel.Size = new Size(218, 51);
            createTeamLabel.TabIndex = 12;
            createTeamLabel.Text = "Create Team";
            // 
            // addTeamMemberButton
            // 
            addTeamMemberButton.FlatAppearance.BorderColor = Color.Silver;
            addTeamMemberButton.FlatAppearance.BorderSize = 2;
            addTeamMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addTeamMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            addTeamMemberButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            addTeamMemberButton.ForeColor = Color.FromArgb(51, 153, 255);
            addTeamMemberButton.Location = new Point(152, 315);
            addTeamMemberButton.Name = "addTeamMemberButton";
            addTeamMemberButton.Size = new Size(195, 46);
            addTeamMemberButton.TabIndex = 20;
            addTeamMemberButton.Text = "Add Member";
            addTeamMemberButton.UseVisualStyleBackColor = true;
            // 
            // selectTeamMemberDropDown
            // 
            selectTeamMemberDropDown.BackColor = SystemColors.Window;
            selectTeamMemberDropDown.Cursor = Cursors.Hand;
            selectTeamMemberDropDown.FormattingEnabled = true;
            selectTeamMemberDropDown.Location = new Point(36, 262);
            selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            selectTeamMemberDropDown.Size = new Size(426, 38);
            selectTeamMemberDropDown.TabIndex = 19;
            // 
            // selectTeamMemberLabel
            // 
            selectTeamMemberLabel.AutoSize = true;
            selectTeamMemberLabel.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamMemberLabel.ForeColor = Color.FromArgb(51, 153, 255);
            selectTeamMemberLabel.Location = new Point(36, 222);
            selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            selectTeamMemberLabel.Size = new Size(253, 37);
            selectTeamMemberLabel.TabIndex = 18;
            selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(createMemberButton);
            groupBox1.Controls.Add(cellphoneValue);
            groupBox1.Controls.Add(cellphoneLabel);
            groupBox1.Controls.Add(emailValue);
            groupBox1.Controls.Add(emailLabel);
            groupBox1.Controls.Add(lastNameValue);
            groupBox1.Controls.Add(lastNameLabel);
            groupBox1.Controls.Add(firstNameValue);
            groupBox1.Controls.Add(firstNameLabel);
            groupBox1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.FromArgb(51, 153, 255);
            groupBox1.Location = new Point(36, 391);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(426, 358);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add New Member";
            // 
            // firstNameValue
            // 
            firstNameValue.Location = new Point(150, 52);
            firstNameValue.Name = "firstNameValue";
            firstNameValue.Size = new Size(230, 43);
            firstNameValue.TabIndex = 11;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            firstNameLabel.Location = new Point(6, 49);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(138, 37);
            firstNameLabel.TabIndex = 10;
            firstNameLabel.Text = "First Name";
            // 
            // lastNameValue
            // 
            lastNameValue.Location = new Point(150, 106);
            lastNameValue.Name = "lastNameValue";
            lastNameValue.Size = new Size(230, 43);
            lastNameValue.TabIndex = 13;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            lastNameLabel.Location = new Point(6, 103);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(135, 37);
            lastNameLabel.TabIndex = 12;
            lastNameLabel.Text = "Last Name";
            // 
            // emailValue
            // 
            emailValue.Location = new Point(150, 163);
            emailValue.Name = "emailValue";
            emailValue.Size = new Size(230, 43);
            emailValue.TabIndex = 15;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.ForeColor = Color.FromArgb(51, 153, 255);
            emailLabel.Location = new Point(6, 160);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(78, 37);
            emailLabel.TabIndex = 14;
            emailLabel.Text = "Email";
            // 
            // cellphoneValue
            // 
            cellphoneValue.Location = new Point(150, 222);
            cellphoneValue.Name = "cellphoneValue";
            cellphoneValue.Size = new Size(230, 43);
            cellphoneValue.TabIndex = 17;
            // 
            // cellphoneLabel
            // 
            cellphoneLabel.AutoSize = true;
            cellphoneLabel.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            cellphoneLabel.ForeColor = Color.FromArgb(51, 153, 255);
            cellphoneLabel.Location = new Point(6, 219);
            cellphoneLabel.Name = "cellphoneLabel";
            cellphoneLabel.Size = new Size(132, 37);
            cellphoneLabel.TabIndex = 16;
            cellphoneLabel.Text = "Cellphone";
            // 
            // createMemberButton
            // 
            createMemberButton.FlatAppearance.BorderColor = Color.Silver;
            createMemberButton.FlatAppearance.BorderSize = 2;
            createMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createMemberButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            createMemberButton.ForeColor = Color.FromArgb(51, 153, 255);
            createMemberButton.Location = new Point(116, 297);
            createMemberButton.Name = "createMemberButton";
            createMemberButton.Size = new Size(195, 46);
            createMemberButton.TabIndex = 21;
            createMemberButton.Text = "Create Member";
            createMemberButton.UseVisualStyleBackColor = true;
            // 
            // teamMembersListBox
            // 
            teamMembersListBox.FormattingEnabled = true;
            teamMembersListBox.ItemHeight = 30;
            teamMembersListBox.Location = new Point(536, 145);
            teamMembersListBox.Name = "teamMembersListBox";
            teamMembersListBox.Size = new Size(352, 604);
            teamMembersListBox.TabIndex = 22;
            // 
            // DeleteSelectedMemberButton
            // 
            DeleteSelectedMemberButton.FlatAppearance.BorderColor = Color.Silver;
            DeleteSelectedMemberButton.FlatAppearance.BorderSize = 2;
            DeleteSelectedMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            DeleteSelectedMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            DeleteSelectedMemberButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteSelectedMemberButton.ForeColor = Color.FromArgb(51, 153, 255);
            DeleteSelectedMemberButton.Location = new Point(921, 375);
            DeleteSelectedMemberButton.Name = "DeleteSelectedMemberButton";
            DeleteSelectedMemberButton.Size = new Size(128, 92);
            DeleteSelectedMemberButton.TabIndex = 23;
            DeleteSelectedMemberButton.Text = "Delete Selected";
            DeleteSelectedMemberButton.UseVisualStyleBackColor = true;
            // 
            // createTeamButton
            // 
            createTeamButton.FlatAppearance.BorderColor = Color.Silver;
            createTeamButton.FlatAppearance.BorderSize = 2;
            createTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTeamButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            createTeamButton.ForeColor = Color.FromArgb(51, 153, 255);
            createTeamButton.Location = new Point(401, 766);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(283, 77);
            createTeamButton.TabIndex = 26;
            createTeamButton.Text = "Create Team";
            createTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1086, 866);
            Controls.Add(createTeamButton);
            Controls.Add(DeleteSelectedMemberButton);
            Controls.Add(teamMembersListBox);
            Controls.Add(groupBox1);
            Controls.Add(addTeamMemberButton);
            Controls.Add(selectTeamMemberDropDown);
            Controls.Add(selectTeamMemberLabel);
            Controls.Add(tournamentNameValue);
            Controls.Add(teamNameLabel);
            Controls.Add(createTeamLabel);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateTeamForm";
            Text = "Create Team";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tournamentNameValue;
        private Label teamNameLabel;
        private Label createTeamLabel;
        private Button addTeamMemberButton;
        private ComboBox selectTeamMemberDropDown;
        private Label selectTeamMemberLabel;
        private GroupBox groupBox1;
        private TextBox firstNameValue;
        private Label firstNameLabel;
        private Button createMemberButton;
        private TextBox cellphoneValue;
        private Label cellphoneLabel;
        private TextBox emailValue;
        private Label emailLabel;
        private TextBox lastNameValue;
        private Label lastNameLabel;
        private ListBox teamMembersListBox;
        private Button DeleteSelectedMemberButton;
        private Button createTeamButton;
    }
}