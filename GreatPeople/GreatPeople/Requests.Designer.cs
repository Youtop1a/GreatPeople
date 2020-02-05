namespace GreatPeople
{
    partial class Requests
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
            this.escapeButton = new System.Windows.Forms.Button();
            this.requestsGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.requestsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // escapeButton
            // 
            this.escapeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.escapeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.escapeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.escapeButton.ForeColor = System.Drawing.Color.White;
            this.escapeButton.Location = new System.Drawing.Point(341, 282);
            this.escapeButton.Name = "escapeButton";
            this.escapeButton.Size = new System.Drawing.Size(150, 34);
            this.escapeButton.TabIndex = 15;
            this.escapeButton.Text = "Назад";
            this.escapeButton.UseVisualStyleBackColor = false;
            this.escapeButton.Click += new System.EventHandler(this.escapeButton_Click);
            // 
            // requestsGrid
            // 
            this.requestsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requestsGrid.Location = new System.Drawing.Point(39, 30);
            this.requestsGrid.Name = "requestsGrid";
            this.requestsGrid.Size = new System.Drawing.Size(452, 233);
            this.requestsGrid.TabIndex = 16;
            this.requestsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Requests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(522, 341);
            this.Controls.Add(this.requestsGrid);
            this.Controls.Add(this.escapeButton);
            this.Name = "Requests";
            this.Text = "Запросы";
            ((System.ComponentModel.ISupportInitialize)(this.requestsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button escapeButton;
        private System.Windows.Forms.DataGridView requestsGrid;
    }
}