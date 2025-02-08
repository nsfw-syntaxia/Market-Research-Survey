namespace MarketResearchSurvey
{
    partial class MarketResearchSurvey
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
            lblMRS = new Label();
            lblNote = new Label();
            lblEmail = new Label();
            tbxEmail = new TextBox();
            tbxName = new TextBox();
            lblName = new Label();
            btnNext = new Button();
            SuspendLayout();
            // 
            // lblMRS
            // 
            lblMRS.AutoSize = true;
            lblMRS.Font = new Font("Bahnschrift", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMRS.ForeColor = Color.DarkSlateGray;
            lblMRS.Location = new Point(12, 14);
            lblMRS.Name = "lblMRS";
            lblMRS.Size = new Size(370, 39);
            lblMRS.TabIndex = 0;
            lblMRS.Text = "Market Research Survey";
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Font = new Font("Bahnschrift SemiLight", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNote.ForeColor = Color.DarkSlateGray;
            lblNote.Location = new Point(16, 56);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(408, 42);
            lblNote.TabIndex = 2;
            lblNote.Text = "Please take a few minutes to tell us more about you\r\nand your preferences.";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Bahnschrift SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.DarkSlateGray;
            lblEmail.Location = new Point(16, 125);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(53, 21);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // tbxEmail
            // 
            tbxEmail.Font = new Font("Microsoft Sans Serif", 8.25F);
            tbxEmail.ForeColor = Color.DarkSlateGray;
            tbxEmail.Location = new Point(15, 152);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(409, 20);
            tbxEmail.TabIndex = 4;
            // 
            // tbxName
            // 
            tbxName.Font = new Font("Bahnschrift SemiLight", 12.75F);
            tbxName.ForeColor = Color.DarkSlateGray;
            tbxName.Location = new Point(15, 227);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(409, 28);
            tbxName.TabIndex = 6;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Bahnschrift SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.DarkSlateGray;
            lblName.Location = new Point(16, 200);
            lblName.Name = "lblName";
            lblName.Size = new Size(55, 21);
            lblName.TabIndex = 5;
            lblName.Text = "Name";
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Bahnschrift SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.DarkSlateGray;
            btnNext.Location = new Point(181, 287);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 28);
            btnNext.TabIndex = 8;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // MarketResearchSurvey
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(438, 342);
            Controls.Add(btnNext);
            Controls.Add(tbxName);
            Controls.Add(lblName);
            Controls.Add(tbxEmail);
            Controls.Add(lblEmail);
            Controls.Add(lblNote);
            Controls.Add(lblMRS);
            MaximizeBox = false;
            Name = "MarketResearchSurvey";
            ShowIcon = false;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMRS;
        private Label lblNote;
        private Label lblEmail;
        private TextBox tbxEmail;
        private TextBox tbxName;
        private Label lblName;
        private Button btnNext;
    }
}