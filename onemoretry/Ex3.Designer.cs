
namespace onemoretry
{
    partial class Ex3
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
            this.ex3DataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.avgValueBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ex3DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ex3DataGridView
            // 
            this.ex3DataGridView.AllowUserToAddRows = false;
            this.ex3DataGridView.AllowUserToDeleteRows = false;
            this.ex3DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ex3DataGridView.Location = new System.Drawing.Point(12, 79);
            this.ex3DataGridView.Name = "ex3DataGridView";
            this.ex3DataGridView.ReadOnly = true;
            this.ex3DataGridView.Size = new System.Drawing.Size(457, 345);
            this.ex3DataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Выдать информацию о марках автомобилей чьи значения по норме затрат \r\nвыше средне" +
    "го значения по всем представленным автомобилям.\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "AVG value = ";
            // 
            // avgValueBox
            // 
            this.avgValueBox.Location = new System.Drawing.Point(87, 51);
            this.avgValueBox.Name = "avgValueBox";
            this.avgValueBox.ReadOnly = true;
            this.avgValueBox.Size = new System.Drawing.Size(372, 20);
            this.avgValueBox.TabIndex = 8;
            // 
            // Ex3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 436);
            this.Controls.Add(this.avgValueBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ex3DataGridView);
            this.Name = "Ex3";
            this.Text = "Ex3";
            ((System.ComponentModel.ISupportInitialize)(this.ex3DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ex3DataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox avgValueBox;
    }
}