namespace GreatPeople
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.fioInput = new System.Windows.Forms.TextBox();
            this.fioLabel = new System.Windows.Forms.Label();
            this.fioButton = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.userExitButton = new System.Windows.Forms.Button();
            this.startBar = new System.Windows.Forms.TrackBar();
            this.endBar = new System.Windows.Forms.TrackBar();
            this.diapazonButton = new System.Windows.Forms.Button();
            this.adminAddButton = new System.Windows.Forms.Button();
            this.diapazonLabel = new System.Windows.Forms.Label();
            this.userStatisticButton = new System.Windows.Forms.Button();
            this.authGuestButton = new System.Windows.Forms.Button();
            this.regGuestButton = new System.Windows.Forms.Button();
            this.adminRequestsButton = new System.Windows.Forms.Button();
            this.adminExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endBar)).BeginInit();
            this.SuspendLayout();
            // 
            // fioInput
            // 
            this.fioInput.Location = new System.Drawing.Point(245, 30);
            this.fioInput.Name = "fioInput";
            this.fioInput.Size = new System.Drawing.Size(320, 20);
            this.fioInput.TabIndex = 0;
            // 
            // fioLabel
            // 
            this.fioLabel.AutoSize = true;
            this.fioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fioLabel.Location = new System.Drawing.Point(60, 30);
            this.fioLabel.Name = "fioLabel";
            this.fioLabel.Size = new System.Drawing.Size(109, 16);
            this.fioLabel.TabIndex = 1;
            this.fioLabel.Text = "Введите ФИО";
            // 
            // fioButton
            // 
            this.fioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fioButton.ForeColor = System.Drawing.Color.White;
            this.fioButton.Location = new System.Drawing.Point(589, 16);
            this.fioButton.Name = "fioButton";
            this.fioButton.Size = new System.Drawing.Size(150, 34);
            this.fioButton.TabIndex = 2;
            this.fioButton.Text = " Найти";
            this.fioButton.UseVisualStyleBackColor = false;
            this.fioButton.Click += new System.EventHandler(this.fioButton_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(63, 111);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(676, 258);
            this.dataGrid.TabIndex = 3;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // userExitButton
            // 
            this.userExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.userExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userExitButton.ForeColor = System.Drawing.Color.White;
            this.userExitButton.Location = new System.Drawing.Point(589, 386);
            this.userExitButton.Name = "userExitButton";
            this.userExitButton.Size = new System.Drawing.Size(150, 34);
            this.userExitButton.TabIndex = 4;
            this.userExitButton.Text = "Выход";
            this.userExitButton.UseVisualStyleBackColor = false;
            this.userExitButton.Click += new System.EventHandler(this.userExitButton_Click);
            // 
            // startBar
            // 
            this.startBar.Location = new System.Drawing.Point(245, 60);
            this.startBar.Name = "startBar";
            this.startBar.Size = new System.Drawing.Size(104, 45);
            this.startBar.TabIndex = 5;
            // 
            // endBar
            // 
            this.endBar.Location = new System.Drawing.Point(390, 60);
            this.endBar.Name = "endBar";
            this.endBar.Size = new System.Drawing.Size(104, 45);
            this.endBar.TabIndex = 6;
            // 
            // diapazonButton
            // 
            this.diapazonButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.diapazonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diapazonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.diapazonButton.ForeColor = System.Drawing.Color.White;
            this.diapazonButton.Location = new System.Drawing.Point(589, 60);
            this.diapazonButton.Name = "diapazonButton";
            this.diapazonButton.Size = new System.Drawing.Size(150, 34);
            this.diapazonButton.TabIndex = 7;
            this.diapazonButton.Text = "Найти";
            this.diapazonButton.UseVisualStyleBackColor = false;
            this.diapazonButton.Click += new System.EventHandler(this.diapazonButton_Click);
            // 
            // adminAddButton
            // 
            this.adminAddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.adminAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adminAddButton.ForeColor = System.Drawing.Color.White;
            this.adminAddButton.Location = new System.Drawing.Point(63, 386);
            this.adminAddButton.Name = "adminAddButton";
            this.adminAddButton.Size = new System.Drawing.Size(150, 34);
            this.adminAddButton.TabIndex = 8;
            this.adminAddButton.Text = "Добавить";
            this.adminAddButton.UseVisualStyleBackColor = false;
            this.adminAddButton.Click += new System.EventHandler(this.adminAddButton_Click);
            // 
            // diapazonLabel
            // 
            this.diapazonLabel.AutoSize = true;
            this.diapazonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.diapazonLabel.Location = new System.Drawing.Point(60, 60);
            this.diapazonLabel.Name = "diapazonLabel";
            this.diapazonLabel.Size = new System.Drawing.Size(157, 16);
            this.diapazonLabel.TabIndex = 9;
            this.diapazonLabel.Text = "Выберите диапозон";
            // 
            // userStatisticButton
            // 
            this.userStatisticButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.userStatisticButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userStatisticButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userStatisticButton.ForeColor = System.Drawing.Color.White;
            this.userStatisticButton.Location = new System.Drawing.Point(63, 386);
            this.userStatisticButton.Name = "userStatisticButton";
            this.userStatisticButton.Size = new System.Drawing.Size(150, 34);
            this.userStatisticButton.TabIndex = 10;
            this.userStatisticButton.Text = "Статистика";
            this.userStatisticButton.UseVisualStyleBackColor = false;
            this.userStatisticButton.Click += new System.EventHandler(this.userStatisticButton_Click);
            // 
            // authGuestButton
            // 
            this.authGuestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.authGuestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.authGuestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authGuestButton.ForeColor = System.Drawing.Color.White;
            this.authGuestButton.Location = new System.Drawing.Point(589, 320);
            this.authGuestButton.Name = "authGuestButton";
            this.authGuestButton.Size = new System.Drawing.Size(150, 34);
            this.authGuestButton.TabIndex = 11;
            this.authGuestButton.Text = "Авторизация";
            this.authGuestButton.UseVisualStyleBackColor = false;
            this.authGuestButton.Click += new System.EventHandler(this.authGuestButton_Click);
            // 
            // regGuestButton
            // 
            this.regGuestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.regGuestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regGuestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regGuestButton.ForeColor = System.Drawing.Color.White;
            this.regGuestButton.Location = new System.Drawing.Point(433, 386);
            this.regGuestButton.Name = "regGuestButton";
            this.regGuestButton.Size = new System.Drawing.Size(150, 34);
            this.regGuestButton.TabIndex = 12;
            this.regGuestButton.Text = "Регистрация";
            this.regGuestButton.UseVisualStyleBackColor = false;
            this.regGuestButton.Click += new System.EventHandler(this.regGuestButton_Click);
            // 
            // adminRequestsButton
            // 
            this.adminRequestsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.adminRequestsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminRequestsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adminRequestsButton.ForeColor = System.Drawing.Color.White;
            this.adminRequestsButton.Location = new System.Drawing.Point(229, 386);
            this.adminRequestsButton.Name = "adminRequestsButton";
            this.adminRequestsButton.Size = new System.Drawing.Size(198, 34);
            this.adminRequestsButton.TabIndex = 13;
            this.adminRequestsButton.Text = "Просмотр запросов";
            this.adminRequestsButton.UseVisualStyleBackColor = false;
            this.adminRequestsButton.Click += new System.EventHandler(this.adminRequestsButton_Click);
            // 
            // adminExitButton
            // 
            this.adminExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.adminExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adminExitButton.ForeColor = System.Drawing.Color.White;
            this.adminExitButton.Location = new System.Drawing.Point(589, 320);
            this.adminExitButton.Name = "adminExitButton";
            this.adminExitButton.Size = new System.Drawing.Size(150, 34);
            this.adminExitButton.TabIndex = 14;
            this.adminExitButton.Text = "Выход";
            this.adminExitButton.UseVisualStyleBackColor = false;
            this.adminExitButton.Click += new System.EventHandler(this.adminExitButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(803, 546);
            this.Controls.Add(this.adminExitButton);
            this.Controls.Add(this.adminRequestsButton);
            this.Controls.Add(this.regGuestButton);
            this.Controls.Add(this.authGuestButton);
            this.Controls.Add(this.userStatisticButton);
            this.Controls.Add(this.diapazonLabel);
            this.Controls.Add(this.adminAddButton);
            this.Controls.Add(this.diapazonButton);
            this.Controls.Add(this.endBar);
            this.Controls.Add(this.startBar);
            this.Controls.Add(this.userExitButton);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.fioButton);
            this.Controls.Add(this.fioLabel);
            this.Controls.Add(this.fioInput);
            this.Name = "Main";
            this.Text = "Великие люди";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fioInput;
        private System.Windows.Forms.Label fioLabel;
        private System.Windows.Forms.Button fioButton;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button userExitButton;
        private System.Windows.Forms.TrackBar startBar;
        private System.Windows.Forms.TrackBar endBar;
        private System.Windows.Forms.Button diapazonButton;
        private System.Windows.Forms.Button adminAddButton;
        private System.Windows.Forms.Label diapazonLabel;
        private System.Windows.Forms.Button userStatisticButton;
        private System.Windows.Forms.Button authGuestButton;
        private System.Windows.Forms.Button regGuestButton;
        private System.Windows.Forms.Button adminRequestsButton;
        private System.Windows.Forms.Button adminExitButton;
    }
}

