namespace TrackerUI
{
    partial class CreatePrizeForm
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
            placeNumberValue = new TextBox();
            placeNumberLabel = new Label();
            placeNameValue = new TextBox();
            placeNameLabel = new Label();
            prizeAmountValue = new TextBox();
            prizeAmountLabel = new Label();
            prizePercentageValue = new TextBox();
            prizePercentageLabel = new Label();
            orLabel = new Label();
            createPrizeButton = new Button();
            SuspendLayout();
            // 
            // createPrizeLabel
            // 
            createPrizeLabel.AutoSize = true;
            createPrizeLabel.Font = new Font("Segoe UI Light", 28F, FontStyle.Regular, GraphicsUnit.Point);
            createPrizeLabel.ForeColor = Color.FromArgb(51, 153, 255);
            createPrizeLabel.Location = new Point(34, 30);
            createPrizeLabel.Name = "createPrizeLabel";
            createPrizeLabel.Size = new Size(215, 51);
            createPrizeLabel.TabIndex = 13;
            createPrizeLabel.Text = "Create Prize";
            // 
            // placeNumberValue
            // 
            placeNumberValue.Location = new Point(249, 108);
            placeNumberValue.Name = "placeNumberValue";
            placeNumberValue.Size = new Size(230, 35);
            placeNumberValue.TabIndex = 15;
            // 
            // placeNumberLabel
            // 
            placeNumberLabel.AutoSize = true;
            placeNumberLabel.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            placeNumberLabel.ForeColor = Color.FromArgb(51, 153, 255);
            placeNumberLabel.Location = new Point(34, 105);
            placeNumberLabel.Name = "placeNumberLabel";
            placeNumberLabel.Size = new Size(177, 37);
            placeNumberLabel.TabIndex = 14;
            placeNumberLabel.Text = "Place Number";
            // 
            // placeNameValue
            // 
            placeNameValue.Location = new Point(249, 164);
            placeNameValue.Name = "placeNameValue";
            placeNameValue.Size = new Size(230, 35);
            placeNameValue.TabIndex = 17;
            // 
            // placeNameLabel
            // 
            placeNameLabel.AutoSize = true;
            placeNameLabel.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            placeNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            placeNameLabel.Location = new Point(34, 161);
            placeNameLabel.Name = "placeNameLabel";
            placeNameLabel.Size = new Size(152, 37);
            placeNameLabel.TabIndex = 16;
            placeNameLabel.Text = "Place Name";
            // 
            // prizeAmountValue
            // 
            prizeAmountValue.Location = new Point(249, 220);
            prizeAmountValue.Name = "prizeAmountValue";
            prizeAmountValue.Size = new Size(230, 35);
            prizeAmountValue.TabIndex = 19;
            // 
            // prizeAmountLabel
            // 
            prizeAmountLabel.AutoSize = true;
            prizeAmountLabel.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            prizeAmountLabel.ForeColor = Color.FromArgb(51, 153, 255);
            prizeAmountLabel.Location = new Point(34, 217);
            prizeAmountLabel.Name = "prizeAmountLabel";
            prizeAmountLabel.Size = new Size(174, 37);
            prizeAmountLabel.TabIndex = 18;
            prizeAmountLabel.Text = "Place Amount";
            // 
            // prizePercentageValue
            // 
            prizePercentageValue.Location = new Point(249, 344);
            prizePercentageValue.Name = "prizePercentageValue";
            prizePercentageValue.Size = new Size(230, 35);
            prizePercentageValue.TabIndex = 21;
            // 
            // prizePercentageLabel
            // 
            prizePercentageLabel.AutoSize = true;
            prizePercentageLabel.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            prizePercentageLabel.ForeColor = Color.FromArgb(51, 153, 255);
            prizePercentageLabel.Location = new Point(34, 342);
            prizePercentageLabel.Name = "prizePercentageLabel";
            prizePercentageLabel.Size = new Size(209, 37);
            prizePercentageLabel.TabIndex = 20;
            prizePercentageLabel.Text = "Place Percentage";
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            orLabel.ForeColor = Color.FromArgb(51, 153, 255);
            orLabel.Location = new Point(214, 278);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(77, 37);
            orLabel.TabIndex = 22;
            orLabel.Text = "- or -";
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.BorderSize = 2;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createPrizeButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            createPrizeButton.ForeColor = Color.FromArgb(51, 153, 255);
            createPrizeButton.Location = new Point(120, 445);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(283, 77);
            createPrizeButton.TabIndex = 27;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(531, 561);
            Controls.Add(createPrizeButton);
            Controls.Add(orLabel);
            Controls.Add(prizePercentageValue);
            Controls.Add(prizePercentageLabel);
            Controls.Add(prizeAmountValue);
            Controls.Add(prizeAmountLabel);
            Controls.Add(placeNameValue);
            Controls.Add(placeNameLabel);
            Controls.Add(placeNumberValue);
            Controls.Add(placeNumberLabel);
            Controls.Add(createPrizeLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreatePrizeForm";
            Text = "Create Prize";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createPrizeLabel;
        private TextBox placeNumberValue;
        private Label placeNumberLabel;
        private TextBox placeNameValue;
        private Label placeNameLabel;
        private TextBox prizeAmountValue;
        private Label prizeAmountLabel;
        private TextBox prizePercentageValue;
        private Label prizePercentageLabel;
        private Label orLabel;
        private Button createPrizeButton;
    }
}