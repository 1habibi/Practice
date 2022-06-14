
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
            this.printButton = new System.Windows.Forms.Button();
            this.printDataGridView = new System.Drawing.Printing.PrintDocument();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.updateMarkTextBox = new System.Windows.Forms.TextBox();
            this.updateMileageTextBox = new System.Windows.Forms.TextBox();
            this.updateCostTextBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
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
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(319, 393);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(135, 52);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete Selected Row";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(16, 393);
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
            this.addRowButton.Size = new System.Drawing.Size(192, 52);
            this.addRowButton.TabIndex = 15;
            this.addRowButton.Text = "Add Row";
            this.addRowButton.UseVisualStyleBackColor = true;
            this.addRowButton.Click += new System.EventHandler(this.addRowButton_Click);
            // 
            // ex1Button
            // 
            this.ex1Button.Location = new System.Drawing.Point(490, 252);
            this.ex1Button.Name = "ex1Button";
            this.ex1Button.Size = new System.Drawing.Size(75, 23);
            this.ex1Button.TabIndex = 16;
            this.ex1Button.Text = "Exercise 1";
            this.ex1Button.UseVisualStyleBackColor = true;
            this.ex1Button.Click += new System.EventHandler(this.ex1Button_Click);
            // 
            // ex2Button
            // 
            this.ex2Button.Location = new System.Drawing.Point(490, 281);
            this.ex2Button.Name = "ex2Button";
            this.ex2Button.Size = new System.Drawing.Size(75, 23);
            this.ex2Button.TabIndex = 17;
            this.ex2Button.Text = "Exercise 2";
            this.ex2Button.UseVisualStyleBackColor = true;
            this.ex2Button.Click += new System.EventHandler(this.ex2Button_Click);
            // 
            // ex3Button
            // 
            this.ex3Button.Location = new System.Drawing.Point(490, 310);
            this.ex3Button.Name = "ex3Button";
            this.ex3Button.Size = new System.Drawing.Size(75, 23);
            this.ex3Button.TabIndex = 18;
            this.ex3Button.Text = "Exercise 3";
            this.ex3Button.UseVisualStyleBackColor = true;
            this.ex3Button.Click += new System.EventHandler(this.ex3Button_Click);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(16, 422);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(99, 23);
            this.printButton.TabIndex = 19;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // printDataGridView
            // 
            this.printDataGridView.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDataGridView_PrintPage);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(509, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mark";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(502, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Mileage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(512, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Cost";
            // 
            // updateMarkTextBox
            // 
            this.updateMarkTextBox.Location = new System.Drawing.Point(475, 62);
            this.updateMarkTextBox.Name = "updateMarkTextBox";
            this.updateMarkTextBox.Size = new System.Drawing.Size(100, 20);
            this.updateMarkTextBox.TabIndex = 23;
            // 
            // updateMileageTextBox
            // 
            this.updateMileageTextBox.Location = new System.Drawing.Point(474, 101);
            this.updateMileageTextBox.Name = "updateMileageTextBox";
            this.updateMileageTextBox.Size = new System.Drawing.Size(100, 20);
            this.updateMileageTextBox.TabIndex = 24;
            // 
            // updateCostTextBox
            // 
            this.updateCostTextBox.Location = new System.Drawing.Point(475, 141);
            this.updateCostTextBox.Name = "updateCostTextBox";
            this.updateCostTextBox.Size = new System.Drawing.Size(100, 20);
            this.updateCostTextBox.TabIndex = 25;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(490, 167);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 26;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 453);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.updateCostTextBox);
            this.Controls.Add(this.updateMileageTextBox);
            this.Controls.Add(this.updateMarkTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.printButton);
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
        private System.Windows.Forms.Button printButton;
        private System.Drawing.Printing.PrintDocument printDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox updateMarkTextBox;
        private System.Windows.Forms.TextBox updateMileageTextBox;
        private System.Windows.Forms.TextBox updateCostTextBox;
        private System.Windows.Forms.Button updateButton;
    }
}

