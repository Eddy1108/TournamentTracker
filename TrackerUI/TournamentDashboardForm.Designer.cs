namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            createPrizeLabel = new Label();
            loadExistingTournamentDropDown = new ComboBox();
            loadExistingTournamentLabel = new Label();
            loadTournamentButton = new Button();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // createPrizeLabel
            // 
            createPrizeLabel.AutoSize = true;
            createPrizeLabel.Font = new Font("Segoe UI Light", 28F, FontStyle.Regular, GraphicsUnit.Point);
            createPrizeLabel.ForeColor = Color.FromArgb(51, 153, 255);
            createPrizeLabel.Location = new Point(172, 31);
            createPrizeLabel.Name = "createPrizeLabel";
            createPrizeLabel.Size = new Size(393, 51);
            createPrizeLabel.TabIndex = 14;
            createPrizeLabel.Text = "Tournament Dashboard";
            // 
            // loadExistingTournamentDropDown
            // 
            loadExistingTournamentDropDown.BackColor = SystemColors.Window;
            loadExistingTournamentDropDown.Cursor = Cursors.Hand;
            loadExistingTournamentDropDown.FormattingEnabled = true;
            loadExistingTournamentDropDown.Location = new Point(155, 153);
            loadExistingTournamentDropDown.Name = "loadExistingTournamentDropDown";
            loadExistingTournamentDropDown.Size = new Size(426, 38);
            loadExistingTournamentDropDown.TabIndex = 21;
            // 
            // loadExistingTournamentLabel
            // 
            loadExistingTournamentLabel.AutoSize = true;
            loadExistingTournamentLabel.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            loadExistingTournamentLabel.ForeColor = Color.FromArgb(51, 153, 255);
            loadExistingTournamentLabel.Location = new Point(217, 113);
            loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
            loadExistingTournamentLabel.Size = new Size(303, 37);
            loadExistingTournamentLabel.TabIndex = 20;
            loadExistingTournamentLabel.Text = "Load Existing Tournament";
            // 
            // loadTournamentButton
            // 
            loadTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            loadTournamentButton.FlatAppearance.BorderSize = 2;
            loadTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            loadTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            loadTournamentButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            loadTournamentButton.ForeColor = Color.FromArgb(51, 153, 255);
            loadTournamentButton.Location = new Point(271, 197);
            loadTournamentButton.Name = "loadTournamentButton";
            loadTournamentButton.Size = new Size(195, 46);
            loadTournamentButton.TabIndex = 22;
            loadTournamentButton.Text = "Load Tournament";
            loadTournamentButton.UseVisualStyleBackColor = true;
            loadTournamentButton.Click += loadTournamentButton_Click;
            // 
            // createTournamentButton
            // 
            createTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            createTournamentButton.FlatAppearance.BorderSize = 2;
            createTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTournamentButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            createTournamentButton.ForeColor = Color.FromArgb(51, 153, 255);
            createTournamentButton.Location = new Point(227, 276);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(283, 77);
            createTournamentButton.TabIndex = 28;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            createTournamentButton.Click += createTournamentButton_Click;
            // 
            // TournamentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(737, 410);
            Controls.Add(createTournamentButton);
            Controls.Add(loadTournamentButton);
            Controls.Add(loadExistingTournamentDropDown);
            Controls.Add(loadExistingTournamentLabel);
            Controls.Add(createPrizeLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "TournamentDashboardForm";
            Text = "Tournament Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createPrizeLabel;
        private ComboBox loadExistingTournamentDropDown;
        private Label loadExistingTournamentLabel;
        private Button loadTournamentButton;
        private Button createTournamentButton;
    }
}