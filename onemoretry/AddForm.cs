using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace onemoretry
{
    public partial class AddForm : Form
    {
        Form1 mainForm;
        public AddForm(Form1 form1)
        {
            InitializeComponent();
            this.mainForm = form1;
        }

        private void addRowButton_Click(object sender, EventArgs e)
        {
            if (mainForm.dataGridView1.Columns.Count <= 0)
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                {
                    mainForm.dataGridView1.Columns.Add("mark", "mark");
                    mainForm.dataGridView1.Columns.Add("mileage", "mileage");
                    mainForm.dataGridView1.Columns.Add("cost", "cost");
                    mainForm.dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text);
                    mainForm.dataGridView1.Refresh();
                }
            }
            else
            {
                if (mainForm.isOpen == true)
                {
                    if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                    {
                        DataRow workRow = mainForm.dt.NewRow();
                        workRow[0] = textBox1.Text;
                        workRow[1] = textBox2.Text;
                        workRow[2] = textBox3.Text;
                        mainForm.dt.Rows.Add(workRow);
                        mainForm.dataGridView1.DataSource = mainForm.dt;
                    }
                }
                else
                {
                    if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                    {
                        mainForm.dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text);
                        mainForm.dataGridView1.Refresh();
                    }
                }
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letter = e.KeyChar;

            if (!Char.IsLetter(letter) && letter != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
