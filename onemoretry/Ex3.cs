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
    public partial class Ex3 : Form
    {
        Form1 mainForm;
        
        public int rowIndex;
        public int avgValue = 0;

        public Ex3(Form1 form1)
        {
            InitializeComponent();
            this.mainForm = form1;
            Work();
        }

        private void Work()
        {
            ex3DataGridView.Columns.Clear();
            ex3DataGridView.Rows.Clear();

            ex3DataGridView.Columns.Add("mark", "mark");
            ex3DataGridView.Columns.Add("mileage", "mileage");
            ex3DataGridView.Columns.Add("cost", "cost");

            for (int i = 0; i < mainForm.dataGridView1.RowCount; i++)
            {
                avgValue += Convert.ToInt32(mainForm.dataGridView1.Rows[i].Cells[2].Value);
            }
            avgValue = avgValue / mainForm.dataGridView1.RowCount;
            avgValueBox.Text = avgValue.ToString();
            
            for (int i = 0; i < mainForm.dataGridView1.RowCount; i++)
            {
                if (Convert.ToInt32(mainForm.dataGridView1.Rows[i].Cells[2].Value) > avgValue)
                {
                    ex3DataGridView.Rows.Add(mainForm.dataGridView1.Rows[i].Cells[0].Value, mainForm.dataGridView1.Rows[i].Cells[1].Value, mainForm.dataGridView1.Rows[i].Cells[2].Value);
                }
            }

        }
    }
}
