namespace GreatPeople
{
    partial class Authorization
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
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.Button();
            this.loginInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.registrationButton = new System.Windows.Forms.Button();
            this.escapeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(60, 30);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(52, 16);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Логин";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.Location = new System.Drawing.Point(60, 80);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(63, 16);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Пароль";
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.enterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterButton.ForeColor = System.Drawing.Color.White;
            this.enterButton.Location = new System.Drawing.Point(60, 130);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(150, 34);
            this.enterButton.TabIndex = 2;
            this.enterButton.Text = "Вход";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // loginInput
            // 
            this.loginInput.Location = new System.Drawing.Point(60, 50);
            this.loginInput.Name = "loginInput";
            this.loginInput.Size = new System.Drawing.Size(150, 20);
            this.loginInput.TabIndex = 3;
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(60, 100);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(150, 20);
            this.passwordInput.TabIndex = 4;
            // 
            // registrationButton
            // 
            this.registrationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.registrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationButton.ForeColor = System.Drawing.Color.White;
            this.registrationButton.Location = new System.Drawing.Point(60, 170);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(150, 34);
            this.registrationButton.TabIndex = 5;
            this.registrationButton.Text = "Регистрация";
            this.registrationButton.UseVisualStyleBackColor = false;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // escapeButton
            // 
            this.escapeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.escapeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.escapeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.escapeButton.ForeColor = System.Drawing.Color.White;
            this.escapeButton.Location = new System.Drawing.Point(60, 210);
            this.escapeButton.Name = "escapeButton";
            this.escapeButton.Size = new System.Drawing.Size(150, 34);
            this.escapeButton.TabIndex = 6;
            this.escapeButton.Text = "Назад";
            this.escapeButton.UseVisualStyleBackColor = false;
            this.escapeButton.Click += new System.EventHandler(this.escapeButton_Click);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(274, 277);
            this.Controls.Add(this.escapeButton);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.loginInput);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Name = "Authorization";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.TextBox loginInput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.Button escapeButton;
    }
}