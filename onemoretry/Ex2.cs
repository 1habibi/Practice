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
    public partial class Ex2 : Form
    {
        Form1 mainForm;
        public Ex2(Form1 form1)
        {
            InitializeComponent();
            this.mainForm = form1;
            Work();
        }
        private void Work()
        {
            ex2DataGridView.Columns.Clear();
            ex2DataGridView.Rows.Clear();

            ex2DataGridView.Columns.Add("mark", "mark");
            ex2DataGridView.Columns.Add("mileage", "mileage");
            ex2DataGridView.Columns.Add("cost", "cost");

            for (int i = 0; i < mainForm.dataGridView1.RowCount; i++)
            {
                if (Convert.ToInt32(mainForm.dataGridView1.Rows[i].Cells[2].Value) >= 15400 && Convert.ToInt32(mainForm.dataGridView1.Rows[i].Cells[2].Value) <= 22100)
                {
                    ex2DataGridView.Rows.Add(mainForm.dataGridView1.Rows[i].Cells[0].Value, mainForm.dataGridView1.Rows[i].Cells[1].Value, mainForm.dataGridView1.Rows[i].Cells[2].Value);
                }
            }
        }
    }
}
