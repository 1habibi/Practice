
namespace onemoretry
{
    partial class AddForm
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
            this.mileage = new System.Windows.Forms.Label();
            this.cost = new System.Windows.Forms.Label();
            this.mark = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addRowButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mileage
            // 
            this.mileage.AutoSize = true;
            this.mileage.Location = new System.Drawing.Point(85, 52);
            this.mileage.Name = "mileage";
            this.mileage.Size = new System.Drawing.Size(44, 13);
            this.mileage.TabIndex = 21;
            this.mileage.Text = "Mileage";
            // 
            // cost
            // 
            this.cost.AutoSize = true;
            this.cost.Location = new System.Drawing.Point(98, 78);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(28, 13);
            this.cost.TabIndex = 20;
            this.cost.Text = "Cost";
            // 
            // mark
            // 
            this.mark.AutoSize = true;
            this.mark.Location = new System.Drawing.Point(94, 28);
            this.mark.Name = "mark";
            this.mark.Size = new System.Drawing.Size(31, 13);
            this.mark.TabIndex = 19;
            this.mark.Text = "Mark";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(131, 75);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(183, 20);
            this.textBox3.TabIndex = 18;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(131, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(183, 20);
            this.textBox2.TabIndex = 17;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 20);
            this.textBox1.TabIndex = 16;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // addRowButton
            // 
            this.addRowButton.Location = new System.Drawing.Point(148, 101);
            this.addRowButton.Name = "addRowButton";
            this.addRowButton.Size = new System.Drawing.Size(148, 23);
            this.addRowButton.TabIndex = 15;
            this.addRowButton.Text = "Add";
            this.addRowButton.UseVisualStyleBackColor = true;
            this.addRowButton.Click += new System.EventHandler(this.addRowButton_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 161);
            this.Controls.Add(this.mileage);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.mark);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.addRowButton);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mileage;
        private System.Windows.Forms.Label cost;
        private System.Windows.Forms.Label mark;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addRowButton;
    }
}