
namespace onemoretry
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.browseTextBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.addRowButton = new System.Windows.Forms.Button();
            this.ex1Button = new System.Windows.Forms.Button();
            this.ex2Button = new System.Windows.Forms.Button();
            this.ex3Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(457, 345);
            this.dataGridView1.TabIndex = 1;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(319, 400);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(135, 23);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete Selected Row";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(16, 400);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(99, 23);
            this.exportButton.TabIndex = 8;
            this.exportButton.Text = "Export To File";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // browseTextBox
            // 
            this.browseTextBox.Location = new System.Drawing.Point(93, 15);
            this.browseTextBox.Name = "browseTextBox";
            this.browseTextBox.Size = new System.Drawing.Size(376, 20);
            this.browseTextBox.TabIndex = 10;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(12, 12);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 11;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // addRowButton
            // 
            this.addRowButton.Location = new System.Drawing.Point(121, 393);
            this.addRowButton.Name = "addRowButton";
            this.addRowButton.Size = new System.Drawing.Size(192, 36);
            this.addRowButton.TabIndex = 15;
            this.addRowButton.Text = "Add Row";
            this.addRowButton.UseVisualStyleBackColor = true;
            this.addRowButton.Click += new System.EventHandler(this.addRowButton_Click);
            // 
            // ex1Button
            // 
            this.ex1Button.Location = new System.Drawing.Point(475, 164);
            this.ex1Button.Name = "ex1Button";
            this.ex1Button.Size = new System.Drawing.Size(75, 23);
            this.ex1Button.TabIndex = 16;
            this.ex1Button.Text = "Exercise 1";
            this.ex1Button.UseVisualStyleBackColor = true;
            this.ex1Button.Click += new System.EventHandler(this.ex1Button_Click);
            // 
            // ex2Button
            // 
            this.ex2Button.Location = new System.Drawing.Point(475, 193);
            this.ex2Button.Name = "ex2Button";
            this.ex2Button.Size = new System.Drawing.Size(75, 23);
            this.ex2Button.TabIndex = 17;
            this.ex2Button.Text = "Exercise 2";
            this.ex2Button.UseVisualStyleBackColor = true;
            // 
            // ex3Button
            // 
            this.ex3Button.Location = new System.Drawing.Point(475, 222);
            this.ex3Button.Name = "ex3Button";
            this.ex3Button.Size = new System.Drawing.Size(75, 23);
            this.ex3Button.TabIndex = 18;
            this.ex3Button.Text = "Exercise 3";
            this.ex3Button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 441);
            this.Controls.Add(this.ex3Button);
            this.Controls.Add(this.ex2Button);
            this.Controls.Add(this.ex1Button);
            this.Controls.Add(this.addRowButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.browseTextBox);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "CSV working application";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.TextBox browseTextBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button addRowButton;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ex1Button;
        private System.Windows.Forms.Button ex2Button;
        private System.Windows.Forms.Button ex3Button;
    }
}

