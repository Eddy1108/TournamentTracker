namespace TrackerUI
{
    partial class CreateTournamentForm
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
            tournamentLabel = new Label();
            tournamentNameValue = new TextBox();
            tournamentNameLabel = new Label();
            entryFeeValue = new TextBox();
            entryFeeLabel = new Label();
            selectTeamDropDown = new ComboBox();
            selectTeamLabel = new Label();
            createNewTeamLink = new LinkLabel();
            addTeamButton = new Button();
            createPrizeButton = new Button();
            tournamentTeamsListBox = new ListBox();
            tournamentPlayersLabel = new Label();
            RemoveSelectedPlayersButton = new Button();
            RemoveSelectedPrizesButton = new Button();
            prizesListLabel = new Label();
            prizesListBox = new ListBox();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // tournamentLabel
            // 
            tournamentLabel.AutoSize = true;
            tournamentLabel.Font = new Font("Segoe UI Light", 28F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentLabel.ForeColor = Color.FromArgb(51, 153, 255);
            tournamentLabel.Location = new Point(29, 29);
            tournamentLabel.Name = "tournamentLabel";
            tournamentLabel.Size = new Size(323, 51);
            tournamentLabel.TabIndex = 1;
            tournamentLabel.Text = "Create Tournament";
            // 
            // tournamentNameValue
            // 
            tournamentNameValue.Location = new Point(45, 153);
            tournamentNameValue.Name = "tournamentNameValue";
            tournamentNameValue.Size = new Size(336, 35);
            tournamentNameValue.TabIndex = 11;
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            tournamentNameLabel.Location = new Point(45, 113);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(225, 37);
            tournamentNameLabel.TabIndex = 10;
            tournamentNameLabel.Text = "Tournament Name";
            // 
            // entryFeeValue
            // 
            entryFeeValue.Location = new Point(175, 231);
            entryFeeValue.Name = "entryFeeValue";
            entryFeeValue.Size = new Size(100, 35);
            entryFeeValue.TabIndex = 13;
            entryFeeValue.Text = "0";
            // 
            // entryFeeLabel
            // 
            entryFeeLabel.AutoSize = true;
            entryFeeLabel.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            entryFeeLabel.ForeColor = Color.FromArgb(51, 153, 255);
            entryFeeLabel.Location = new Point(45, 228);
            entryFeeLabel.Name = "entryFeeLabel";
            entryFeeLabel.Size = new Size(124, 37);
            entryFeeLabel.TabIndex = 12;
            entryFeeLabel.Text = "Entry Fee";
            // 
            // selectTeamDropDown
            // 
            selectTeamDropDown.BackColor = SystemColors.Window;
            selectTeamDropDown.Cursor = Cursors.Hand;
            selectTeamDropDown.FormattingEnabled = true;
            selectTeamDropDown.Location = new Point(45, 347);
            selectTeamDropDown.Name = "selectTeamDropDown";
            selectTeamDropDown.Size = new Size(336, 38);
            selectTeamDropDown.TabIndex = 15;
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamLabel.ForeColor = Color.FromArgb(51, 153, 255);
            selectTeamLabel.Location = new Point(45, 307);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(150, 37);
            selectTeamLabel.TabIndex = 14;
            selectTeamLabel.Text = "Select Team";
            // 
            // createNewTeamLink
            // 
            createNewTeamLink.AutoSize = true;
            createNewTeamLink.Location = new Point(263, 313);
            createNewTeamLink.Name = "createNewTeamLink";
            createNewTeamLink.Size = new Size(114, 30);
            createNewTeamLink.TabIndex = 16;
            createNewTeamLink.TabStop = true;
            createNewTeamLink.Text = "create new";
            createNewTeamLink.LinkClicked += createNewTeamLink_LinkClicked;
            // 
            // addTeamButton
            // 
            addTeamButton.FlatAppearance.BorderColor = Color.Silver;
            addTeamButton.FlatAppearance.BorderSize = 2;
            addTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            addTeamButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            addTeamButton.ForeColor = Color.FromArgb(51, 153, 255);
            addTeamButton.Location = new Point(115, 401);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(195, 46);
            addTeamButton.TabIndex = 17;
            addTeamButton.Text = "Add Team";
            addTeamButton.UseVisualStyleBackColor = true;
            addTeamButton.Click += addTeamButton_Click;
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.BorderSize = 2;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createPrizeButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            createPrizeButton.ForeColor = Color.FromArgb(51, 153, 255);
            createPrizeButton.Location = new Point(115, 473);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(195, 46);
            createPrizeButton.TabIndex = 18;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += createPrizeButton_Click;
            // 
            // tournamentTeamsListBox
            // 
            tournamentTeamsListBox.BorderStyle = BorderStyle.FixedSingle;
            tournamentTeamsListBox.FormattingEnabled = true;
            tournamentTeamsListBox.ItemHeight = 30;
            tournamentTeamsListBox.Location = new Point(493, 153);
            tournamentTeamsListBox.Name = "tournamentTeamsListBox";
            tournamentTeamsListBox.Size = new Size(315, 152);
            tournamentTeamsListBox.TabIndex = 19;
            // 
            // tournamentPlayersLabel
            // 
            tournamentPlayersLabel.AutoSize = true;
            tournamentPlayersLabel.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentPlayersLabel.ForeColor = Color.FromArgb(51, 153, 255);
            tournamentPlayersLabel.Location = new Point(493, 113);
            tournamentPlayersLabel.Name = "tournamentPlayersLabel";
            tournamentPlayersLabel.Size = new Size(189, 37);
            tournamentPlayersLabel.TabIndex = 20;
            tournamentPlayersLabel.Text = "Teams / Players";
            // 
            // RemoveSelectedPlayersButton
            // 
            RemoveSelectedPlayersButton.FlatAppearance.BorderColor = Color.Silver;
            RemoveSelectedPlayersButton.FlatAppearance.BorderSize = 2;
            RemoveSelectedPlayersButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            RemoveSelectedPlayersButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            RemoveSelectedPlayersButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            RemoveSelectedPlayersButton.ForeColor = Color.FromArgb(51, 153, 255);
            RemoveSelectedPlayersButton.Location = new Point(837, 174);
            RemoveSelectedPlayersButton.Name = "RemoveSelectedPlayersButton";
            RemoveSelectedPlayersButton.Size = new Size(128, 92);
            RemoveSelectedPlayersButton.TabIndex = 21;
            RemoveSelectedPlayersButton.Text = "Remove Selected";
            RemoveSelectedPlayersButton.UseVisualStyleBackColor = true;
            RemoveSelectedPlayersButton.Click += RemoveSelectedPlayersButton_Click;
            // 
            // RemoveSelectedPrizesButton
            // 
            RemoveSelectedPrizesButton.FlatAppearance.BorderColor = Color.Silver;
            RemoveSelectedPrizesButton.FlatAppearance.BorderSize = 2;
            RemoveSelectedPrizesButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            RemoveSelectedPrizesButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            RemoveSelectedPrizesButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            RemoveSelectedPrizesButton.ForeColor = Color.FromArgb(51, 153, 255);
            RemoveSelectedPrizesButton.Location = new Point(837, 421);
            RemoveSelectedPrizesButton.Name = "RemoveSelectedPrizesButton";
            RemoveSelectedPrizesButton.Size = new Size(128, 86);
            RemoveSelectedPrizesButton.TabIndex = 24;
            RemoveSelectedPrizesButton.Text = "Remove Selected";
            RemoveSelectedPrizesButton.UseVisualStyleBackColor = true;
            RemoveSelectedPrizesButton.Click += RemoveSelectedPrizesButton_Click;
            // 
            // prizesListLabel
            // 
            prizesListLabel.AutoSize = true;
            prizesListLabel.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            prizesListLabel.ForeColor = Color.FromArgb(51, 153, 255);
            prizesListLabel.Location = new Point(493, 350);
            prizesListLabel.Name = "prizesListLabel";
            prizesListLabel.Size = new Size(84, 37);
            prizesListLabel.TabIndex = 23;
            prizesListLabel.Text = "Prizes";
            // 
            // prizesListBox
            // 
            prizesListBox.BorderStyle = BorderStyle.FixedSingle;
            prizesListBox.FormattingEnabled = true;
            prizesListBox.ItemHeight = 30;
            prizesListBox.Location = new Point(493, 390);
            prizesListBox.Name = "prizesListBox";
            prizesListBox.Size = new Size(315, 152);
            prizesListBox.TabIndex = 22;
            // 
            // createTournamentButton
            // 
            createTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            createTournamentButton.FlatAppearance.BorderSize = 2;
            createTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTournamentButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            createTournamentButton.ForeColor = Color.FromArgb(51, 153, 255);
            createTournamentButton.Location = new Point(366, 593);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(283, 77);
            createTournamentButton.TabIndex = 25;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            createTournamentButton.Click += createTournamentButton_Click;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1048, 719);
            Controls.Add(createTournamentButton);
            Controls.Add(RemoveSelectedPrizesButton);
            Controls.Add(prizesListLabel);
            Controls.Add(prizesListBox);
            Controls.Add(RemoveSelectedPlayersButton);
            Controls.Add(tournamentPlayersLabel);
            Controls.Add(tournamentTeamsListBox);
            Controls.Add(createPrizeButton);
            Controls.Add(addTeamButton);
            Controls.Add(createNewTeamLink);
            Controls.Add(selectTeamDropDown);
            Controls.Add(selectTeamLabel);
            Controls.Add(entryFeeValue);
            Controls.Add(entryFeeLabel);
            Controls.Add(tournamentNameValue);
            Controls.Add(tournamentNameLabel);
            Controls.Add(tournamentLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(51, 153, 255);
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateTournamentForm";
            Text = "Create Tournament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tournamentLabel;
        private TextBox tournamentNameValue;
        private Label tournamentNameLabel;
        private TextBox entryFeeValue;
        private Label entryFeeLabel;
        private ComboBox selectTeamDropDown;
        private Label selectTeamLabel;
        private LinkLabel createNewTeamLink;
        private Button addTeamButton;
        private Button createPrizeButton;
        private ListBox tournamentTeamsListBox;
        private Label tournamentPlayersLabel;
        private Button RemoveSelectedPlayersButton;
        private Button RemoveSelectedPrizesButton;
        private Label prizesListLabel;
        private ListBox prizesListBox;
        private Button createTournamentButton;
    }
}