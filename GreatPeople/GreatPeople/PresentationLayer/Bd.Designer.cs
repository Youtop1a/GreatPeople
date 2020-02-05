namespace GreatPeople
{
    partial class Bd
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
            this.fioLabel = new System.Windows.Forms.Label();
            this.workLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.lifeLabel = new System.Windows.Forms.Label();
            this.escapeButton = new System.Windows.Forms.Button();
            this.addNewButton = new System.Windows.Forms.Button();
            this.fioInput = new System.Windows.Forms.TextBox();
            this.workInput = new System.Windows.Forms.TextBox();
            this.yearInput = new System.Windows.Forms.TextBox();
            this.countryInput = new System.Windows.Forms.TextBox();
            this.lifeInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fioLabel
            // 
            this.fioLabel.AutoSize = true;
            this.fioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fioLabel.Location = new System.Drawing.Point(60, 30);
            this.fioLabel.Name = "fioLabel";
            this.fioLabel.Size = new System.Drawing.Size(109, 16);
            this.fioLabel.TabIndex = 0;
            this.fioLabel.Text = "Введите ФИО";
            // 
            // workLabel
            // 
            this.workLabel.AutoSize = true;
            this.workLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workLabel.Location = new System.Drawing.Point(60, 60);
            this.workLabel.Name = "workLabel";
            this.workLabel.Size = new System.Drawing.Size(177, 16);
            this.workLabel.TabIndex = 1;
            this.workLabel.Text = "Область деятельности";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearLabel.Location = new System.Drawing.Point(60, 90);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(110, 16);
            this.yearLabel.TabIndex = 2;
            this.yearLabel.Text = "Год рождения";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countryLabel.Location = new System.Drawing.Point(60, 120);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(62, 16);
            this.countryLabel.TabIndex = 3;
            this.countryLabel.Text = "Страна";
            // 
            // lifeLabel
            // 
            this.lifeLabel.AutoSize = true;
            this.lifeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lifeLabel.Location = new System.Drawing.Point(60, 150);
            this.lifeLabel.Name = "lifeLabel";
            this.lifeLabel.Size = new System.Drawing.Size(209, 16);
            this.lifeLabel.TabIndex = 4;
            this.lifeLabel.Text = "Продолжительность жизни";
            // 
            // escapeButton
            // 
            this.escapeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.escapeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.escapeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.escapeButton.ForeColor = System.Drawing.Color.White;
            this.escapeButton.Location = new System.Drawing.Point(360, 207);
            this.escapeButton.Name = "escapeButton";
            this.escapeButton.Size = new System.Drawing.Size(150, 34);
            this.escapeButton.TabIndex = 5;
            this.escapeButton.Text = "Назад";
            this.escapeButton.UseVisualStyleBackColor = false;
            this.escapeButton.Click += new System.EventHandler(this.escapeButton_Click);
            // 
            // addNewButton
            // 
            this.addNewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewButton.ForeColor = System.Drawing.Color.White;
            this.addNewButton.Location = new System.Drawing.Point(63, 207);
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.Size = new System.Drawing.Size(150, 34);
            this.addNewButton.TabIndex = 6;
            this.addNewButton.Text = "Добавить";
            this.addNewButton.UseVisualStyleBackColor = false;
            this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click);
            // 
            // fioInput
            // 
            this.fioInput.Location = new System.Drawing.Point(285, 30);
            this.fioInput.Name = "fioInput";
            this.fioInput.Size = new System.Drawing.Size(225, 20);
            this.fioInput.TabIndex = 7;
            // 
            // workInput
            // 
            this.workInput.Location = new System.Drawing.Point(285, 60);
            this.workInput.Name = "workInput";
            this.workInput.Size = new System.Drawing.Size(225, 20);
            this.workInput.TabIndex = 8;
            // 
            // yearInput
            // 
            this.yearInput.Location = new System.Drawing.Point(285, 90);
            this.yearInput.Name = "yearInput";
            this.yearInput.Size = new System.Drawing.Size(225, 20);
            this.yearInput.TabIndex = 9;
            // 
            // countryInput
            // 
            this.countryInput.Location = new System.Drawing.Point(285, 120);
            this.countryInput.Name = "countryInput";
            this.countryInput.Size = new System.Drawing.Size(225, 20);
            this.countryInput.TabIndex = 10;
            // 
            // lifeInput
            // 
            this.lifeInput.Location = new System.Drawing.Point(285, 150);
            this.lifeInput.Name = "lifeInput";
            this.lifeInput.Size = new System.Drawing.Size(225, 20);
            this.lifeInput.TabIndex = 11;
            // 
            // Bd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(565, 332);
            this.Controls.Add(this.lifeInput);
            this.Controls.Add(this.countryInput);
            this.Controls.Add(this.yearInput);
            this.Controls.Add(this.workInput);
            this.Controls.Add(this.fioInput);
            this.Controls.Add(this.addNewButton);
            this.Controls.Add(this.escapeButton);
            this.Controls.Add(this.lifeLabel);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.workLabel);
            this.Controls.Add(this.fioLabel);
            this.Name = "Bd";
            this.Text = "Добавить";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fioLabel;
        private System.Windows.Forms.Label workLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label lifeLabel;
        private System.Windows.Forms.Button escapeButton;
        private System.Windows.Forms.Button addNewButton;
        private System.Windows.Forms.TextBox fioInput;
        private System.Windows.Forms.TextBox workInput;
        private System.Windows.Forms.TextBox yearInput;
        private System.Windows.Forms.TextBox countryInput;
        private System.Windows.Forms.TextBox lifeInput;
    }
}