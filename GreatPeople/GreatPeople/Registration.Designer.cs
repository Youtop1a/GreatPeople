namespace GreatPeople
{
    partial class Registration
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
            this.enterButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.rePasswordInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.loginInput = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.rePasswordLabel = new System.Windows.Forms.Label();
            this.escapeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.enterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterButton.ForeColor = System.Drawing.Color.White;
            this.enterButton.Location = new System.Drawing.Point(60, 200);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(150, 34);
            this.enterButton.TabIndex = 0;
            this.enterButton.Text = "Вход";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okButton.ForeColor = System.Drawing.Color.White;
            this.okButton.Location = new System.Drawing.Point(60, 160);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(150, 34);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "ОК";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // rePasswordInput
            // 
            this.rePasswordInput.Location = new System.Drawing.Point(60, 130);
            this.rePasswordInput.Name = "rePasswordInput";
            this.rePasswordInput.Size = new System.Drawing.Size(150, 20);
            this.rePasswordInput.TabIndex = 2;
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(60, 90);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(150, 20);
            this.passwordInput.TabIndex = 3;
            // 
            // loginInput
            // 
            this.loginInput.Location = new System.Drawing.Point(60, 50);
            this.loginInput.Name = "loginInput";
            this.loginInput.Size = new System.Drawing.Size(150, 20);
            this.loginInput.TabIndex = 4;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(60, 30);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(147, 16);
            this.loginLabel.TabIndex = 5;
            this.loginLabel.Text = "Придумайте логин";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.Location = new System.Drawing.Point(60, 70);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(157, 16);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Придумайте пароль";
            // 
            // rePasswordLabel
            // 
            this.rePasswordLabel.AutoSize = true;
            this.rePasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rePasswordLabel.Location = new System.Drawing.Point(60, 110);
            this.rePasswordLabel.Name = "rePasswordLabel";
            this.rePasswordLabel.Size = new System.Drawing.Size(146, 16);
            this.rePasswordLabel.TabIndex = 7;
            this.rePasswordLabel.Text = "Повторите пароль";
            // 
            // escapeButton
            // 
            this.escapeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.escapeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.escapeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.escapeButton.ForeColor = System.Drawing.Color.White;
            this.escapeButton.Location = new System.Drawing.Point(60, 240);
            this.escapeButton.Name = "escapeButton";
            this.escapeButton.Size = new System.Drawing.Size(150, 34);
            this.escapeButton.TabIndex = 8;
            this.escapeButton.Text = "Назад";
            this.escapeButton.UseVisualStyleBackColor = false;
            this.escapeButton.Click += new System.EventHandler(this.escapeButton_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(266, 313);
            this.Controls.Add(this.escapeButton);
            this.Controls.Add(this.rePasswordLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.loginInput);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.rePasswordInput);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.enterButton);
            this.Name = "Registration";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox rePasswordInput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.TextBox loginInput;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label rePasswordLabel;
        private System.Windows.Forms.Button escapeButton;
    }
}