
namespace onemoretry
{
    partial class Ex2
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
            this.ex2DataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ex2DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ex2DataGridView
            // 
            this.ex2DataGridView.AllowUserToAddRows = false;
            this.ex2DataGridView.AllowUserToDeleteRows = false;
            this.ex2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ex2DataGridView.Location = new System.Drawing.Point(12, 52);
            this.ex2DataGridView.Name = "ex2DataGridView";
            this.ex2DataGridView.ReadOnly = true;
            this.ex2DataGridView.Size = new System.Drawing.Size(457, 345);
            this.ex2DataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Найти марки автомобилей, норма затрат которых не более 22 100 руб. \r\nи не меньше " +
    "15 400 руб.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ex2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 409);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ex2DataGridView);
            this.Name = "Ex2";
            this.Text = "Ex2";
            ((System.ComponentModel.ISupportInitialize)(this.ex2DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ex2DataGridView;
        private System.Windows.Forms.Label label1;
    }
}